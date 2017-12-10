 # Creating a Discord App For DPS (Discord Presence Setter)

[Click Here To Create A New App](https://discordapp.com/developers/applications/me/create)

### You should see something like this!
![](https://i.gyazo.com/a91c456f090bf04135ed956565c561cd.png)

Type your **App Name** in and press **Create**

**Take Note of your Client ID under the App Details Section** You will need this to put into the **ApplicationID Area in DPS**

Now click **Enable Rich Presence**


Scroll Down to the **Rich Presence** Section

Do not set anything under Advanced Rich Presence Features

![](https://i.gyazo.com/e576081909eceb58143e5cd8c0c11d43.png)


Go to the Rich Presence Assets Section

The name of your asset is what goes in this area of DPS.

![](https://i.gyazo.com/08ea835c8be6bcef1da3c4d46d877e62.png)

If your asset is a **Large** type, then type the **Name** of the asset in the **Large Image Key**
Otherwise if your asset is a **Small** type, then type the name of the asset in the **Small Image Key**

Click on the circle to Add an image, select if its a Large Or Small Type, then click **Upload Asset**

Add as many Assets as you like, you can use any of them at any time by changing the Image Keys in DPS to
the name of the asset, then pressing Save Changes + Resend Presence

 ### Discord Presence Setter Details
![](https://i.gyazo.com/0c7b48f0d1eac47eb5373b609f382c9c.png)

![](https://i.gyazo.com/7a0295e7e871d4984d0f5febbf0043a5.png)

**Note:** All fields have a character limit, watch your Presence in discord to see if what you wrote fits!
 * Put your Client ID in the ApplicationID.
 * Set your Details
 * In your Assets add the name of a Small Image Asset into the Small Image Key
 * In your Assets add the name of a Large Image Asset into the Large Image Key
 * Add anything at all to Party ID, Match Secret, Join Secret and Spectate Secret, text in these fields are required.
 * Set the Current Party Size to a number between 1 and 100
 * Set the Max Party Size to a number between 1 and 100, Greater than your Current Size.

 **Party Timer**

This is the time thats shown in the presence, it will count down from the provided Time in minutes, till it reaches zero.
Check **Resend Precense On Timer Elapse** if you would like the presence to be resent when the timer reaches zero.

Now Click Save Changes, then click Run! Watch the Log to make sure it's actually sending the presence to Discord!

This guide is still under construction, please let me know if I missed anything in the issue area!

If the presence isn't showing, make sure you're using Discords Default Desktop Application on the same machine that you're running Discord Presence Setter on, and make sure your Details are set correctly!
 




