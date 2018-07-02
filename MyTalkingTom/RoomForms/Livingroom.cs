using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace MyTalkingTom
{
    public partial class Livingroom : Form
    {
        private static Timer myTimer;
        private static SoundPlayer player = new SoundPlayer(Properties.Resources.Thornmail);

        public Livingroom()
        {
            InitializeComponent();
            player.PlayLooping();
            TimerTick();
        }

        #region Set Label Percent
        private void SetLabelPercent(object sender, EventArgs e)
        {
            lb_LVR_Play.Text = MainProgram.myTom.Statistics.NowPlayPercent.ToString() + "%";
            lb_LVR_Eat.Text = MainProgram.myTom.Statistics.NowEatPercent.ToString() + "%";
            lb_LVR_PooPoo.Text = MainProgram.myTom.Statistics.NowPooPooPercent.ToString() + "%";
            lb_LVR_Sleep.Text = MainProgram.myTom.Statistics.NowSleepPercent.ToString() + "%";
            lb_LVR_Coins.Text = MainProgram.myTom.Coins.ToString();

            if (MainProgram.myTom.Statistics.NowPlayPercent <= 20)
            {
                btn_Home_Home.BackgroundImage = Properties.Resources.btn_Livingroom_Sad;
            }
            else
            {
                btn_Home_Home.BackgroundImage = Properties.Resources.btn_Livingroom_Happy;
            }
        }

        private void TimerTick()
        {
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(SetLabelPercent);
            myTimer.Interval = 10;
            myTimer.Start();
        }
        #endregion

        #region Control Button Click Event
        private void LVR_InfoBtnClick(object sender, EventArgs e)
        {
            MessageBox.Show(MainProgram.myTom.TomName + MainProgram.myTom.Age, Properties.Resources.infoMessBoxCaption);
        }

        private void LVR_SoundBtnClick(object sender, EventArgs e)
        {
            if (MainProgram.isPlayed)
            {
                MainProgram.isPlayed = false;
                MainProgram.player.Stop();
                btn_Home_Sound.BackgroundImage = Properties.Resources.btn_SoundOff;
            }
            else
            {
                MainProgram.isPlayed = true;
                MainProgram.player.PlayLooping();
                btn_Home_Sound.BackgroundImage = Properties.Resources.btn_SoundOn;
            }
        }

        private void LVR_CloseBtnClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Properties.Resources.quitMessBoxContent,
                Properties.Resources.quitMessBoxCaption, MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        Application.Exit();
                        break;
                    }
                case DialogResult.No:
                    {
                        break;
                    }
            }
        }
        #endregion

        #region Form Button Click Event
        private void LVR_PlayGamesBtnClick(object sender, EventArgs e)
        {
            Play playGame = new Play();
            FormManager.ChangeForm(this, playGame);
        }

        private void LVR_MarketBtnClick(object sender, EventArgs e)
        {
            MarketForm.previousRoom = 1;
            MarketForm market = new MarketForm();
            FormManager.ChangeForm(this, market);
        }

        private void LVR_KitchenBtnClick(object sender, EventArgs e)
        {
            Kitchen kitchen = new Kitchen();
            FormManager.ChangeForm(this, kitchen);
        }

        private void LVR_BathroomBtnClick(object sender, EventArgs e)
        {
            Bathroom bathRoom = new Bathroom();
            FormManager.ChangeForm(this, bathRoom);
        }

        private void LVR_BedroomBtnClick(object sender, EventArgs e)
        {
            Bedroom bedroom = new Bedroom();
            FormManager.ChangeForm(this, bedroom);
        }


        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainProgram.myTom.Happying();
        }
    }
}