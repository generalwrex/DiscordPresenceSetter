using DiscordPresenceSetter.Properties;
using System;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace DiscordPresenceSetter
{
    public partial class Form1 : Form
    {
        #region Fields

        public DiscordRpc.RichPresence discordPresence;

        public Timer timer;

        public bool isRunning = false;

        private DiscordRpc.EventHandlers handlers;

        private BackgroundWorker m_oWorker;

        #endregion Fields

        private delegate void SetStringDelegate(string parameter);

        #region Settings

        public bool SaveSettings()
        {
            try
            {
                Settings.Default.ApplicationID = MyApplicationID.Text;
                Settings.Default.State = LengthCapper(128, StateBox.Text);
                Settings.Default.Details = LengthCapper(128, DetailsBox.Text);
                Settings.Default.SmallImageKey = LengthCapper(32, SmallImageKeyBox.Text);
                Settings.Default.SmallImageText = LengthCapper(128, SmallImageTextBox.Text);
                Settings.Default.LargeImageKey = LengthCapper(32, LargeImageKeyBox.Text);
                Settings.Default.LargeImageText = LengthCapper(128, LargeImageTextBox.Text);
                Settings.Default.PartyID = LengthCapper(128, PartyIDBox.Text);
                Settings.Default.MatchSecret = LengthCapper(128, MatchSecretBox.Text);
                Settings.Default.JoinSecret = LengthCapper(128, JoinSecretBox.Text);
                Settings.Default.SpectateSecret = LengthCapper(128, SpectateSecretBox.Text);
                Settings.Default.PartySize = int.Parse(CurrentPartySize.Value.ToString());
                Settings.Default.PartyMax = int.Parse(MaxPartySize.Value.ToString());
                Settings.Default.PartyTimer = int.Parse(PartyTimerCounter.Value.ToString());
                Settings.Default.ResendPresence = ResendPresenceCheckbox.Checked;

                Settings.Default.Save();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n " + "StackTrace: " + ex.StackTrace, "Settings Configured Wrong");
            }

            return false;
        }

        public void LoadDefaults(bool save = true )
        {
            Settings.Default.ApplicationID = "0";
            Settings.Default.State = "My Lobby";
            Settings.Default.Details = "Rich Presence Is Cool!";
            Settings.Default.SmallImageKey = "";
            Settings.Default.SmallImageText = "";
            Settings.Default.LargeImageKey = "";
            Settings.Default.LargeImageText = "";
            Settings.Default.PartyID = "myparty";
            Settings.Default.MatchSecret = "match";
            Settings.Default.JoinSecret = "join";
            Settings.Default.SpectateSecret = "spectate";
            Settings.Default.PartySize = 1;
            Settings.Default.PartyMax = 6;
            Settings.Default.PartyTimer = 5;
            Settings.Default.ResendPresence = true;

            if(save)
                Settings.Default.Save();
        }

        public void LoadSettings()
        {
            try
            {
                MyApplicationID.Text = Settings.Default.ApplicationID;

                StateBox.Text = LengthCapper(64, Settings.Default.State);
                DetailsBox.Text = LengthCapper(64, Settings.Default.Details);
                SmallImageKeyBox.Text = LengthCapper(16, Settings.Default.SmallImageKey);
                SmallImageTextBox.Text = LengthCapper(64, Settings.Default.SmallImageText);
                LargeImageKeyBox.Text = LengthCapper(16, Settings.Default.LargeImageKey);
                LargeImageTextBox.Text = LengthCapper(64, Settings.Default.LargeImageText);
                PartyIDBox.Text = LengthCapper(64, Settings.Default.PartyID);
                MatchSecretBox.Text = LengthCapper(64, Settings.Default.MatchSecret);
                JoinSecretBox.Text = LengthCapper(64, Settings.Default.JoinSecret);
                SpectateSecretBox.Text = LengthCapper(64, Settings.Default.SpectateSecret);

                CurrentPartySize.Value = (Settings.Default.PartySize == 0 ? 1 : Settings.Default.PartySize);
                MaxPartySize.Value = Settings.Default.PartyMax;
                PartyTimerCounter.Value = decimal.Parse(Settings.Default.PartyTimer.ToString());

                ResendPresenceCheckbox.Checked = Settings.Default.ResendPresence;
            }
            catch(ConfigurationException ex)
            {
                var result = MessageBox.Show(ex.Message + "\r\n\r\nConfig is missing or is corrupted.\r\nWould you like to load the default settings?", "Config File Exception");
                if(result == DialogResult.OK)
                {
                    LoadDefaults();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n " + "StackTrace: " + ex.StackTrace, "Settings Configured Wrong");
            }
        }

        #endregion Settings

        public Form1()
        {
            string loc = Assembly.GetEntryAssembly().Location;
            string path = String.Concat(loc, ".config");

            LoadDefaults(false);

            InitializeComponent();

            FormLog.TextChanged += (sender, e) => {

                FormLog.SelectionStart = FormLog.TextLength;
                FormLog.ScrollToCaret();


            };

            FormLog.VisibleChanged += (sender, e) =>
            {
                if (FormLog.Visible)
                {
                    FormLog.SelectionStart = FormLog.TextLength;
                    FormLog.ScrollToCaret();
                }
            };

            StartButton.Enabled = !isRunning;
            StopButton.Enabled = isRunning;
            ResendPresenceButton.Enabled = isRunning;

            LoadSettings();

            Log("Creating Event Handlers...");
            handlers = new DiscordRpc.EventHandlers();
            handlers.readyCallback = ReadyCallback;
            handlers.disconnectedCallback += DisconnectedCallback;
            handlers.errorCallback += ErrorCallback;
            handlers.joinCallback += JoinCallback;
            handlers.spectateCallback += SpectateCallback;
            handlers.requestCallback += RequestCallback;

            m_oWorker = new BackgroundWorker();

            timer = new Timer();
            timer.Elapsed += TimerTick;

            m_oWorker.DoWork += delegate (object sender, DoWorkEventArgs e)
            {
                timer.Interval = TimeSpan.FromMinutes(Settings.Default.PartyTimer).TotalMilliseconds;
                timer.Start();

                Log("Starting...");

                while (isRunning)
                {
                    DiscordRpc.RunCallbacks();
                };

                Log("Stopping...");
                DiscordRpc.Shutdown();
            };

            m_oWorker.RunWorkerCompleted += delegate (object sender, RunWorkerCompletedEventArgs e)
            {
                if (e.Cancelled)
                {
                    Log("Task Cancelled.");
                }
                else if (e.Error != null)
                {
                    Log("Error " + e.Error.StackTrace);
                }
                else
                {
                    Log("Task Completed...");
                }

                DiscordRpc.Shutdown();

                timer.Stop();

                StartButton.Enabled = !isRunning;
                StopButton.Enabled = isRunning;
                ResendPresenceButton.Enabled = isRunning;
            };

            m_oWorker.WorkerSupportsCancellation = true;

            Log("Loaded Event Handlers");

            Log("Discord Presence Setter Log \r\nReady To Start!");
        }

        #region Helper Methods

        public string LengthCapper(int maxLength, string input)
        {
            return input.Length > maxLength ? input.Substring(0, maxLength) : input;
        }

        public long ToUnixtime(DateTime date)
        {
            DateTime unixStartTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan timeSpan = date - unixStartTime;
            return Convert.ToInt64(timeSpan.TotalSeconds);
        }

        public DateTime ToCSharpTime(long unixTime)
        {
            DateTime unixStartTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return unixStartTime.AddSeconds(Convert.ToDouble(unixTime));
        }

        public double ConvertMinutesToSeconds(double minutes)
        {
            return TimeSpan.FromMinutes(minutes).TotalSeconds;
        }

        #endregion Helper Methods

        #region Methods

        public void UpdateDiscordPresence()
        {
            try
            {
                discordPresence.state = Settings.Default.State;
                discordPresence.details = Settings.Default.Details;

                discordPresence.smallImageKey = Settings.Default.SmallImageKey;
                discordPresence.smallImageText = Settings.Default.SmallImageText;
                discordPresence.largeImageKey = Settings.Default.LargeImageKey;
                discordPresence.largeImageText = Settings.Default.LargeImageText;
                discordPresence.partyId = Settings.Default.PartyID;
                discordPresence.matchSecret = Settings.Default.MatchSecret;
                discordPresence.joinSecret = Settings.Default.JoinSecret;
                discordPresence.spectateSecret = Settings.Default.SpectateSecret;
                discordPresence.partySize = Settings.Default.PartySize;
                discordPresence.partyMax = Settings.Default.PartyMax;
                discordPresence.instance = false;

                discordPresence.startTimestamp = ToUnixtime(DateTime.UtcNow);
                discordPresence.endTimestamp = (ToUnixtime(DateTime.UtcNow) + 
                    Convert.ToInt64(TimeSpan.FromMinutes(Settings.Default.PartyTimer == 0 ? 5 : Settings.Default.PartyTimer).TotalSeconds));

                DiscordRpc.UpdatePresence(ref discordPresence);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n " + "StackTrace: " + ex.StackTrace, "Update Presence Exception");
            }
        }

        

        public void Log(string message)
        {
            if (FormLog.InvokeRequired)
                Invoke(new SetStringDelegate(Log), new object[] { message + "\r\n" });
            else
                FormLog.Text += message + "\r\n";
        }

        #endregion Methods

        #region Event Handlers

        private void TimerTick(object state, System.Timers.ElapsedEventArgs e)
        {
            if (Settings.Default.ResendPresence)
            {
                Log("Timer Elapsed: Resending Presence");
                UpdateDiscordPresence();
            }
        }

        #endregion Event Handlers

        #region Form Event Handlers

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            Log("Saving Current Settings...");
            if (SaveSettings())
                Log("Saved!");
        }

        System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();

        void timer2_Tick(object sender, System.EventArgs e)
        {
            ResendPresenceButton.Enabled = true;
            timer.Stop();
        }

        private void ResendPresenceButton_Click(object sender, EventArgs e)
        {
            Log("Timer Elapsed: Resending Presence, Wait 10 Seconds before Sending Again.");

            timer2.Interval = 10000; // here time in milliseconds
            timer2.Tick += timer2_Tick;
            timer2.Start();
            ResendPresenceButton.Enabled = false;

            Log("Timer Elapsed: Resending Presence");
            UpdateDiscordPresence();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            isRunning = true;

            try
            {
                Log("Saving Current Settings...");
                if (SaveSettings())
                    Log("Saved!");

                Log("Initializing Discord RPC...");
                DiscordRpc.Initialize(Settings.Default.ApplicationID, ref handlers, true, "");
                Log("Initialized!");

                Log("Sending Rich Presence Settings to Discord...");
                UpdateDiscordPresence();
                Log("Sent!");

                StartButton.Enabled = !isRunning;
                StopButton.Enabled = isRunning;
                ResendPresenceButton.Enabled = isRunning;

                Log("Starting Callbacks...");
                m_oWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n " + "StackTrace: " + ex.StackTrace, "Start Button Exception");
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Log("Stopping Callbacks");
            try
            {
                if (m_oWorker.IsBusy)
                {
                    isRunning = false;

                    m_oWorker.CancelAsync();
                }

                Log("Saving Settings...");
                if (SaveSettings())
                    Log("Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n " + "StackTrace: " + ex.StackTrace, "Stop Button Exception");
            }

            Log("Restarting App...");
            Application.Restart();
        }

        #endregion Form Event Handlers

        #region Discord Event Handlers

        public void ReadyCallback()
        {
            Log("Discord: ready");
        }

        public void DisconnectedCallback(int errorCode, string message)
        {
            Log(string.Format("Discord: disconnect {0}: {1}", errorCode, message));
        }

        public void ErrorCallback(int errorCode, string message)
        {
            Log(string.Format("Discord: error {0}: {1}", errorCode, message));
        }

        public void JoinCallback(string secret)
        {
            Log(string.Format("Discord: join ({0})", secret));
        }

        public void SpectateCallback(string secret)
        {
            Log(string.Format("Discord: spectate ({0})", secret));
        }

        public void RequestCallback(DiscordRpc.JoinRequest request)
        {
            Log(string.Format("Discord: join request {0}: {1}", request.username, request.userId));
        }

        #endregion Discord Event Handlers
    }
}