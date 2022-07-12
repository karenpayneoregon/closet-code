using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using JCS;
using ToggleSwitchDemo.Properties;

namespace ToggleSwitchDemo
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
            SetPropertiesForStylesTabSwitches();
            SetPropertiesForPropertiesTabSwitches();
            SetPropertiesForCustomizationsTabSwitches();
        }

        public void SetPropertiesForStylesTabSwitches()
        {
            //Set the properties for the ToggleSwitches on the "Styles" tab

            MetroStyleToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Metro; //Default
            MetroStyleToggleSwitch.Size = new Size(75, 23);

            IOS5StyleToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            IOS5StyleToggleSwitch.Size = new Size(98, 42);
            IOS5StyleToggleSwitch.OnText = "ON";
            IOS5StyleToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 12, FontStyle.Bold);
            IOS5StyleToggleSwitch.OnForeColor = Color.White;
            IOS5StyleToggleSwitch.OffText = "OFF";
            IOS5StyleToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 12, FontStyle.Bold);
            IOS5StyleToggleSwitch.OffForeColor = Color.FromArgb(141, 123, 141);

            AndroidStyleToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Android;
            AndroidStyleToggleSwitch.Size = new Size(78, 23);
            AndroidStyleToggleSwitch.OnText = "ON";
            AndroidStyleToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 8, FontStyle.Bold);
            AndroidStyleToggleSwitch.OnForeColor = Color.White;
            AndroidStyleToggleSwitch.OffText = "OFF";
            AndroidStyleToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 8, FontStyle.Bold);
            AndroidStyleToggleSwitch.OffForeColor = Color.FromArgb(141, 123, 141);

            BrushedMetalStyleToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.BrushedMetal;
            BrushedMetalStyleToggleSwitch.Size = new Size(93, 30);
            BrushedMetalStyleToggleSwitch.OnText = "ON";
            BrushedMetalStyleToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold);
            BrushedMetalStyleToggleSwitch.OnForeColor = Color.White;
            BrushedMetalStyleToggleSwitch.OffText = "OFF";
            BrushedMetalStyleToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold);
            BrushedMetalStyleToggleSwitch.OffForeColor = Color.White;

            IphoneStyleToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Iphone;
            IphoneStyleToggleSwitch.Size = new Size(93, 30);
            IphoneStyleToggleSwitch.OnText = "ON";
            IphoneStyleToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold);
            IphoneStyleToggleSwitch.OnForeColor = Color.White;
            IphoneStyleToggleSwitch.OffText = "OFF";
            IphoneStyleToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold);
            IphoneStyleToggleSwitch.OffForeColor = Color.FromArgb(92, 92, 92);

            ModernStyleToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            ModernStyleToggleSwitch.Size = new Size(85, 32);
            ModernStyleToggleSwitch.OnText = "ON";
            ModernStyleToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold);
            ModernStyleToggleSwitch.OnForeColor = Color.White;
            ModernStyleToggleSwitch.OffText = "OFF";
            ModernStyleToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold);
            ModernStyleToggleSwitch.OffForeColor = Color.FromArgb(153, 153, 153);

            CarbonStyleToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Carbon;
            CarbonStyleToggleSwitch.Size = new Size(93, 30);
            CarbonStyleToggleSwitch.OnText = "On";
            CarbonStyleToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold);
            CarbonStyleToggleSwitch.OnForeColor = Color.White;
            CarbonStyleToggleSwitch.OffText = "Off";
            CarbonStyleToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold);
            CarbonStyleToggleSwitch.OffForeColor = Color.White;

            OSXStyleToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.OSX;
            OSXStyleToggleSwitch.Size = new Size(93, 25);

            FancyStyleToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Fancy;
            FancyStyleToggleSwitch.Size = new Size(100, 30);
            FancyStyleToggleSwitch.OnText = "ON";
            FancyStyleToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold);
            FancyStyleToggleSwitch.OnForeColor = Color.White;
            FancyStyleToggleSwitch.OffText = "OFF";
            FancyStyleToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold);
            FancyStyleToggleSwitch.OffForeColor = Color.White;
            FancyStyleToggleSwitch.ButtonImage = Resources.handle;

            PlainAndSimpleStyleToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.PlainAndSimpel;
            PlainAndSimpleStyleToggleSwitch.Size = new Size(44, 22);
        }

        public void SetPropertiesForPropertiesTabSwitches()
        {
            //Set the properties for the ToggleSwitches on the "(Semi)-Important Properties" tab

            //AllowUserChange example:

            AllowUserChangeToggleSwitch1.AllowUserChange = false;
            AllowUserChangeToggleSwitch2.AllowUserChange = true;

            //Animation example:

            NoAnimationToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Carbon; //Only to provide an interesting look
            NoAnimationToggleSwitch.Size = new Size(93, 30); //Only to provide an interesting look
            NoAnimationToggleSwitch.OnText = "On"; //Only to provide an interesting look
            NoAnimationToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold); //Only to provide an interesting look
            NoAnimationToggleSwitch.OnForeColor = Color.White; //Only to provide an interesting look
            NoAnimationToggleSwitch.OffText = "Off"; //Only to provide an interesting look
            NoAnimationToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold); //Only to provide an interesting look
            NoAnimationToggleSwitch.OffForeColor = Color.White; //Only to provide an interesting look
            NoAnimationToggleSwitch.UseAnimation = false;

            FastAnimationToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Carbon; //Only to provide an interesting look
            FastAnimationToggleSwitch.Size = new Size(93, 30); //Only to provide an interesting look
            FastAnimationToggleSwitch.OnText = "On"; //Only to provide an interesting look
            FastAnimationToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold); //Only to provide an interesting look
            FastAnimationToggleSwitch.OnForeColor = Color.White; //Only to provide an interesting look
            FastAnimationToggleSwitch.OffText = "Off"; //Only to provide an interesting look
            FastAnimationToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold); //Only to provide an interesting look
            FastAnimationToggleSwitch.OffForeColor = Color.White; //Only to provide an interesting look
            FastAnimationToggleSwitch.UseAnimation = true; //Default
            FastAnimationToggleSwitch.AnimationInterval = 1; //Default
            FastAnimationToggleSwitch.AnimationStep = 10; //Default

            SlowAnimationToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Carbon; //Only to provide an interesting look
            SlowAnimationToggleSwitch.Size = new Size(93, 30); //Only to provide an interesting look
            SlowAnimationToggleSwitch.OnText = "On"; //Only to provide an interesting look
            SlowAnimationToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold); //Only to provide an interesting look
            SlowAnimationToggleSwitch.OnForeColor = Color.White; //Only to provide an interesting look
            SlowAnimationToggleSwitch.OffText = "Off"; //Only to provide an interesting look
            SlowAnimationToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold); //Only to provide an interesting look
            SlowAnimationToggleSwitch.OffForeColor = Color.White; //Only to provide an interesting look
            SlowAnimationToggleSwitch.UseAnimation = true; //Default
            SlowAnimationToggleSwitch.AnimationInterval = 10;
            SlowAnimationToggleSwitch.AnimationStep = 1;

            //GrayWhenDisabled example:

            GrayWhenDisabledToggleSwitch1.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Fancy; //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch1.Size = new Size(100, 30); //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch1.OnText = "ON"; //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch1.OnFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold); //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch1.OnForeColor = Color.White; //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch1.OffText = "OFF"; //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch1.OffFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold); //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch1.OffForeColor = Color.White; //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch1.ButtonImage = Resources.arrowright; //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch1.GrayWhenDisabled = false;

            GrayWhenDisabledToggleSwitch2.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Fancy; //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch2.Size = new Size(100, 30); //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch2.OnText = "ON"; //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch2.OnFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold); //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch2.OnForeColor = Color.White; //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch2.OffText = "OFF"; //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch2.OffFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold); //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch2.OffForeColor = Color.White; //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch2.ButtonImage = Resources.arrowright; //Only to provide an interesting look
            GrayWhenDisabledToggleSwitch2.GrayWhenDisabled = true; //Default

            //ThresholdPercentage example:

            ThresholdPercentageToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5; //Only to provide an interesting look
            ThresholdPercentageToggleSwitch.Size = new Size(98, 42); //Only to provide an interesting look
            ThresholdPercentageToggleSwitch.OnText = "ON"; //Only to provide an interesting look
            ThresholdPercentageToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 12, FontStyle.Bold); //Only to provide an interesting look
            ThresholdPercentageToggleSwitch.OnForeColor = Color.White; //Only to provide an interesting look
            ThresholdPercentageToggleSwitch.OffText = "OFF"; //Only to provide an interesting look
            ThresholdPercentageToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 12, FontStyle.Bold); //Only to provide an interesting look
            ThresholdPercentageToggleSwitch.OffForeColor = Color.FromArgb(141, 123, 141); //Only to provide an interesting look
            ThresholdPercentageToggleSwitch.ThresholdPercentage = 50; //Default

            //ToggleOnButtonClick & ToggleOnSideClick example:

            ToggleOnClickToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.BrushedMetal; //Only to provide an interesting look
            ToggleOnClickToggleSwitch.Size = new Size(93, 30); //Only to provide an interesting look
            ToggleOnClickToggleSwitch.OnText = "ON"; //Only to provide an interesting look
            ToggleOnClickToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold); //Only to provide an interesting look
            ToggleOnClickToggleSwitch.OnForeColor = Color.White; //Only to provide an interesting look
            ToggleOnClickToggleSwitch.OffText = "OFF"; //Only to provide an interesting look
            ToggleOnClickToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold); //Only to provide an interesting look
            ToggleOnClickToggleSwitch.OffForeColor = Color.White; //Only to provide an interesting look
            ToggleOnClickToggleSwitch.ToggleOnButtonClick = true; //Default
            ToggleOnClickToggleSwitch.ToggleOnSideClick = true; //Default
        }

        public void SetPropertiesForCustomizationsTabSwitches()
        {
            //Set the properties for the ToggleSwitches on the "Special Customizations" tab

            //Color customization example, Metro Style ToggleSwitch:

            NormalMetroToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Metro; //Default
            NormalMetroToggleSwitch.Size = new Size(75, 23);

            ToggleSwitchMetroRenderer customizedMetroRenderer = new ToggleSwitchMetroRenderer();
            customizedMetroRenderer.LeftSideColor = Color.Red;
            customizedMetroRenderer.LeftSideColorHovered = Color.FromArgb(210, 0, 0);
            customizedMetroRenderer.LeftSideColorPressed = Color.FromArgb(190, 0, 0);
            customizedMetroRenderer.RightSideColor = Color.Yellow;
            customizedMetroRenderer.RightSideColorHovered = Color.FromArgb(245, 245, 0);
            customizedMetroRenderer.RightSideColorPressed = Color.FromArgb(235, 235, 0);

            CustomizedMetroToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Metro; //Default
            CustomizedMetroToggleSwitch.Size = new Size(75, 23);
            CustomizedMetroToggleSwitch.SetRenderer(customizedMetroRenderer);

            //Color customization example, IOS5 Style ToggleSwitch:

            NormalIOS5ToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            NormalIOS5ToggleSwitch.Size = new Size(98, 42);
            NormalIOS5ToggleSwitch.OnText = "ON";
            NormalIOS5ToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 12, FontStyle.Bold);
            NormalIOS5ToggleSwitch.OnForeColor = Color.White;
            NormalIOS5ToggleSwitch.OffText = "OFF";
            NormalIOS5ToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 12, FontStyle.Bold);
            NormalIOS5ToggleSwitch.OffForeColor = Color.FromArgb(141, 123, 141);

            //Maybe not the prettiest color scheme in the world - It's just for demonstration :-)
            ToggleSwitchIOS5Renderer customizedIos5Renderer = new ToggleSwitchIOS5Renderer();
            customizedIos5Renderer.LeftSideUpperColor1 = Color.FromArgb(128, 0, 64);
            customizedIos5Renderer.LeftSideUpperColor2 = Color.FromArgb(180, 0, 90);
            customizedIos5Renderer.LeftSideLowerColor1 = Color.FromArgb(250, 0, 125);
            customizedIos5Renderer.LeftSideLowerColor2 = Color.FromArgb(255, 120, 190);
            customizedIos5Renderer.RightSideUpperColor1 = Color.FromArgb(0, 64, 128);
            customizedIos5Renderer.RightSideUpperColor2 = Color.FromArgb(0, 90, 180);
            customizedIos5Renderer.RightSideLowerColor1 = Color.FromArgb(0, 125, 250);
            customizedIos5Renderer.RightSideLowerColor2 = Color.FromArgb(120, 190, 255);
            customizedIos5Renderer.ButtonNormalOuterBorderColor = Color.Green;
            customizedIos5Renderer.ButtonNormalInnerBorderColor = Color.Green;
            customizedIos5Renderer.ButtonNormalSurfaceColor1 = Color.Red;
            customizedIos5Renderer.ButtonNormalSurfaceColor2 = Color.Red;
            customizedIos5Renderer.ButtonHoverOuterBorderColor = Color.Green;
            customizedIos5Renderer.ButtonHoverInnerBorderColor = Color.Green;
            customizedIos5Renderer.ButtonHoverSurfaceColor1 = Color.Red;
            customizedIos5Renderer.ButtonHoverSurfaceColor2 = Color.Red;
            customizedIos5Renderer.ButtonPressedOuterBorderColor = Color.Green;
            customizedIos5Renderer.ButtonPressedInnerBorderColor = Color.Green;
            customizedIos5Renderer.ButtonPressedSurfaceColor1 = Color.Red;
            customizedIos5Renderer.ButtonPressedSurfaceColor2 = Color.Red;

            CustomizedIOS5ToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            CustomizedIOS5ToggleSwitch.Size = new Size(98, 42);
            CustomizedIOS5ToggleSwitch.OnText = "ON";
            CustomizedIOS5ToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 12, FontStyle.Bold);
            CustomizedIOS5ToggleSwitch.OnForeColor = Color.White;
            CustomizedIOS5ToggleSwitch.OffText = "OFF";
            CustomizedIOS5ToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 12, FontStyle.Bold);
            CustomizedIOS5ToggleSwitch.OffForeColor = Color.White; //OBS: Need to change this for text visibility
            CustomizedIOS5ToggleSwitch.SetRenderer(customizedIos5Renderer);

            //Color customization example using RendererChanged event

            NormalPlainAndSimpleToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.PlainAndSimpel;
            NormalPlainAndSimpleToggleSwitch.Size = new Size(44, 22);

            CustomizedPlainAndSimpleToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.PlainAndSimpel;
            CustomizedPlainAndSimpleToggleSwitch.Size = new Size(44, 22);
            CustomizedPlainAndSimpleToggleSwitch.BeforeRendering += CustomizedPlainAndSimpleToggleSwitch_BeforeRendering;

            //Image customization example, Fancy Style ToggleSwitch:

            NormalFancyToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Fancy;
            NormalFancyToggleSwitch.Size = new Size(100, 30);
            NormalFancyToggleSwitch.OnText = "ON";
            NormalFancyToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold);
            NormalFancyToggleSwitch.OnForeColor = Color.White;
            NormalFancyToggleSwitch.OffText = "OFF";
            NormalFancyToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold);
            NormalFancyToggleSwitch.OffForeColor = Color.White;

            CustomizedFancyToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Fancy;
            CustomizedFancyToggleSwitch.Size = new Size(100, 30);
            CustomizedFancyToggleSwitch.OffButtonImage = Resources.arrowright;
            CustomizedFancyToggleSwitch.OffSideImage = Resources.cross;
            CustomizedFancyToggleSwitch.OnButtonImage = Resources.arrowleft;
            CustomizedFancyToggleSwitch.OnSideImage = Resources.check;

            //Advanced behavior example, Fancy Style ToggleSwitch:

            Color tempColor;

            ToggleSwitchFancyRenderer customizedFancyRenderer = new ToggleSwitchFancyRenderer();
            tempColor = customizedFancyRenderer.LeftSideBackColor1;
            customizedFancyRenderer.LeftSideBackColor1 = customizedFancyRenderer.RightSideBackColor1;
            customizedFancyRenderer.RightSideBackColor1 = tempColor;
            tempColor = customizedFancyRenderer.LeftSideBackColor2;
            customizedFancyRenderer.LeftSideBackColor2 = customizedFancyRenderer.RightSideBackColor2;
            customizedFancyRenderer.RightSideBackColor2 = tempColor;

            AdvancedBehaviorFancyToggleSwitch.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Fancy;
            AdvancedBehaviorFancyToggleSwitch.Size = new Size(150, 30);
            AdvancedBehaviorFancyToggleSwitch.OnText = "Restart";
            AdvancedBehaviorFancyToggleSwitch.OnFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold);
            AdvancedBehaviorFancyToggleSwitch.OnForeColor = Color.White;
            AdvancedBehaviorFancyToggleSwitch.OffText = "Online";
            AdvancedBehaviorFancyToggleSwitch.OffFont = new Font(DemoTabControl.Font.FontFamily, 10, FontStyle.Bold);
            AdvancedBehaviorFancyToggleSwitch.OffForeColor = Color.White;
            AdvancedBehaviorFancyToggleSwitch.OffButtonImage = Resources.arrowright;
            AdvancedBehaviorFancyToggleSwitch.UseAnimation = false;
            AdvancedBehaviorFancyToggleSwitch.SetRenderer(customizedFancyRenderer);
            AdvancedBehaviorFancyToggleSwitch.CheckedChanged += AdvancedBehaviorFancyToggleSwitch_CheckedChanged;

            AnimatedGifPictureBox.Parent = AdvancedBehaviorFancyToggleSwitch; //Necessary to get the ToggleSwitch button to show through the picture box' transparent background
        }

        private void CustomizedPlainAndSimpleToggleSwitch_BeforeRendering(object sender, ToggleSwitch.BeforeRenderingEventArgs e)
        {
            if (e.Renderer is ToggleSwitchPlainAndSimpleRenderer)
            {
                ToggleSwitchPlainAndSimpleRenderer renderer = e.Renderer as ToggleSwitchPlainAndSimpleRenderer;

                renderer.BorderColorChecked = Color.Green;
                renderer.BorderColorUnchecked = Color.Red;

                //Observe: in the BeforeRendering event, the Checked property will not yet have changed to the final state
                if (!CustomizedPlainAndSimpleToggleSwitch.Checked)
                {
                    renderer.ButtonColor = Color.DarkGray;
                    renderer.InnerBackgroundColor = Color.LightGray;
                }
                else
                {
                    renderer.ButtonColor = Color.DarkBlue;
                    renderer.InnerBackgroundColor = Color.LightBlue;
                }
            }
        }

        private void AllowUserChangeCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            AllowUserChangeToggleSwitch1.Checked = AllowUserChangeCheckBox.Checked;
            AllowUserChangeToggleSwitch2.Checked = AllowUserChangeCheckBox.Checked;
        }

        private void GrayWhenDisabledCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            GrayWhenDisabledToggleSwitch1.Enabled = GrayWhenDisabledCheckBox.Checked;
            GrayWhenDisabledToggleSwitch2.Enabled = GrayWhenDisabledCheckBox.Checked;
        }

        private void ThresholdPercentageTrackBar_Scroll(object sender, System.EventArgs e)
        {
            label15.Text = string.Format("Value = {0} (Default = 50)", ThresholdPercentageTrackBar.Value);
            ThresholdPercentageToggleSwitch.ThresholdPercentage = ThresholdPercentageTrackBar.Value;
        }

        private void ToggleOnButtonClickCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            ToggleOnClickToggleSwitch.ToggleOnButtonClick = ToggleOnButtonClickCheckBox.Checked;
        }

        private void ToggleOnSideClickCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            ToggleOnClickToggleSwitch.ToggleOnSideClick = ToggleOnSideClickCheckBox.Checked;
        }

        private void AdvancedBehaviorFancyToggleSwitch_CheckedChanged(object sender, System.EventArgs e)
        {
            if (AdvancedBehaviorFancyToggleSwitch.Checked)
            {
                AdvancedBehaviorFancyToggleSwitch.AllowUserChange = false;
                AdvancedBehaviorFancyToggleSwitch.OnText = "Restarting...";
                
                PositionAniGifPictureBox();
                AnimatedGifPictureBox.Visible = true;

                if (!SimulateRestartBackgroundWorker.IsBusy)
                    SimulateRestartBackgroundWorker.RunWorkerAsync();
            }
            else
            {
                AdvancedBehaviorFancyToggleSwitch.AllowUserChange = true;
                AdvancedBehaviorFancyToggleSwitch.OnText = "Restart";
            }
        }
        
        private void PositionAniGifPictureBox()
        {
            //Position anigif picturebox

            Rectangle buttonRectangle = AdvancedBehaviorFancyToggleSwitch.ButtonRectangle;

            AnimatedGifPictureBox.Height = buttonRectangle.Height - 2;
            AnimatedGifPictureBox.Width = AnimatedGifPictureBox.Height;
            AnimatedGifPictureBox.Left = buttonRectangle.X + ((buttonRectangle.Width - AnimatedGifPictureBox.Width) / 2);
            AnimatedGifPictureBox.Top = buttonRectangle.Y + ((buttonRectangle.Height - AnimatedGifPictureBox.Height) / 2);
        }

        private void SimulateRestartBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //Simulate restart delay
            Thread.Sleep(1500);
        }

        private void SimulateRestartBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            AnimatedGifPictureBox.Visible = false;
            AdvancedBehaviorFancyToggleSwitch.Checked = false;
        }

        private void MetroStyleToggleSwitch_CheckedChanged(object sender, System.EventArgs e)
        {
            Console.WriteLine(sender.GetType());
        }

        private void IOS5StyleToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            var item = (JCS.ToggleSwitch)sender;
            Console.WriteLine(item.Checked);
        }
    }
}
