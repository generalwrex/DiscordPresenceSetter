using DiscordPresenceSetter.Properties;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace DiscordPresenceSetter
{
    public partial class Form1 : Form
    {
        public DiscordRpc.RichPresence discordPresence;

        public string applicationId;
        public string optionalSteamId;

        public bool isRunning = false;

        private DiscordRpc.EventHandlers handlers;

        private BackgroundWorker m_oWorker;

        public void SaveSettings()
        {
            Settings.Default.ApplicationID = MyApplicationID.Text;
            Settings.Default.State = StateBox.Text;
            Settings.Default.Details = DetailsBox.Text;
            Settings.Default.SmallImageKey = SmallImageKeyBox.Text;
            Settings.Default.SmallImageText = SmallImageTextBox.Text;
            Settings.Default.LargeImageKey = LargeImageKeyBox.Text;
            Settings.Default.LargeImageText = LargeImageTextBox.Text;
            Settings.Default.PartyID = PartyIDBox.Text;
            Settings.Default.MatchSecret = MatchSecretBox.Text;
            Settings.Default.JoinSecret = JoinSecretBox.Text;
            Settings.Default.SpectateSecret = SpectateSecretBox.Text;
            Settings.Default.PartySize = int.Parse(CurrentPartySize.Value.ToString());
            Settings.Default.PartyMax = int.Parse(MaxPartySize.Value.ToString());

            Settings.Default.StartTimeStamp = DateTime.Now.Ticks;
            Settings.Default.EndTimeStamp = new TimeSpan(Settings.Default.StartTimeStamp + 5 * 60).Ticks;

            Settings.Default.Save();
        }

        public void LoadSettings()
        {
            MyApplicationID.Text = Settings.Default.ApplicationID;

            StateBox.Text = Settings.Default.State;
            DetailsBox.Text = Settings.Default.Details;
            SmallImageKeyBox.Text = Settings.Default.SmallImageKey;
            SmallImageTextBox.Text = Settings.Default.SmallImageText;
            LargeImageKeyBox.Text = Settings.Default.LargeImageKey;
            LargeImageTextBox.Text = Settings.Default.LargeImageText;
            PartyIDBox.Text = Settings.Default.PartyID;
            MatchSecretBox.Text = Settings.Default.MatchSecret;
            JoinSecretBox.Text = Settings.Default.JoinSecret;
            SpectateSecretBox.Text = Settings.Default.SpectateSecret;
            CurrentPartySize.Value = Settings.Default.PartySize;
            MaxPartySize.Value = Settings.Default.PartyMax;
        }


        public Form1()
        {
            InitializeComponent();

            LoadSettings();

            handlers = new DiscordRpc.EventHandlers();
            handlers.readyCallback = ReadyCallback;
            handlers.disconnectedCallback += DisconnectedCallback;
            handlers.errorCallback += ErrorCallback;
            handlers.joinCallback += JoinCallback;
            handlers.spectateCallback += SpectateCallback;
            handlers.requestCallback += RequestCallback;

            m_oWorker = new BackgroundWorker();


            m_oWorker.DoWork += delegate (object sender, DoWorkEventArgs e)
            {
                while (isRunning)
                {
                    DiscordRpc.RunCallbacks();                   
                };

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

                //Change the status of the buttons on the UI accordingly
                StartButton.Enabled = true;
                StopButton.Enabled = false;

            };

            m_oWorker.WorkerSupportsCancellation = true;

            Log("Discord Presence Setter Log \r\nReady To Start!");
        }

        public void UpdateDiscordPresence()
        {
            discordPresence.state = Settings.Default.State;
            discordPresence.details = Settings.Default.Details;
            discordPresence.startTimestamp = Settings.Default.StartTimeStamp;
            discordPresence.endTimestamp = Settings.Default.EndTimeStamp;
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
            discordPresence.instance = Settings.Default.Instance;

            DiscordRpc.UpdatePresence(ref discordPresence);
        }

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

        delegate void SetStringDelegate(string parameter);

        public void Log(string message)
        {
            if (FormLog.InvokeRequired)
                Invoke(new SetStringDelegate(Log), new object[] { message + "\r\n" });
            else
                FormLog.Text += message + "\r\n";
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SaveSettings();

            DiscordRpc.Initialize(Settings.Default.ApplicationID, ref handlers, true, "");

            UpdateDiscordPresence();
          
            StartButton.Enabled = false;
            StopButton.Enabled = true;

            isRunning = true;

            m_oWorker.RunWorkerAsync();
           
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (m_oWorker.IsBusy)
            {
                isRunning = false;

                m_oWorker.CancelAsync();
            }

            SaveSettings();
            Application.Restart();
        }
    }
}