using MyTalkingTom.Manager;
using MyTalkingTom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTalkingTom
{
    public partial class Bedroom : Form
    {
        private bool isPlayed = true;
        private static SoundPlayer player = new SoundPlayer(Properties.Resources.Thornmail);
        private Light light = new Light(true);
        private Wardrove wardrove = new Wardrove(false);
        private Timer myTimer;

        public Bedroom()
        {
            InitializeComponent();
            player.PlayLooping();
            TimerTick();
        }

        #region Form Button Click Event
        private void BER_MarketBtnClick(object sender, EventArgs e)
        {
            if (!light.IsLighted)
            {
                BER_LightIsTurnedOn();
            }
            MarketForm.previousRoom = 4;
            FormManager.ChangeForm(this, new MarketForm());
        }

        private void BER_LivingroomBtnClick(object sender, EventArgs e)
        {
            if (!light.IsLighted)
            {
                BER_LightIsTurnedOn();
            }
            FormManager.ChangeForm(this, new Livingroom());
        }

        private void BER_KitchenBtnClick(object sender, EventArgs e)
        {
            if (!light.IsLighted)
            {
                BER_LightIsTurnedOn();
            }
            FormManager.ChangeForm(this, new Kitchen());
        }

        private void BER_BathroomBtnClick(object sender, EventArgs e)
        {
            if (!light.IsLighted)
            {
                BER_LightIsTurnedOn();
            }
            FormManager.ChangeForm(this, new Bathroom());
        }
        #endregion

        #region Set Label Percent
        private void SetLabelPercent(object sender, EventArgs e)
        {
            lb_BER_Play.Text = MainProgram.myTom.Statistics.NowPlayPercent.ToString() + "%";
            lb_BER_Eat.Text = MainProgram.myTom.Statistics.NowEatPercent.ToString() + "%";
            lb_BER_PooPoo.Text = MainProgram.myTom.Statistics.NowPooPooPercent.ToString() + "%";
            lb_BER_Sleep.Text = MainProgram.myTom.Statistics.NowSleepPercent.ToString() + "%";
            lb_BER_Coins.Text = MainProgram.myTom.Coins.ToString();

            if (MainProgram.myTom.Statistics.NowPlayPercent <= 20)
            {
                btn_Sleep_Home.BackgroundImage = Properties.Resources.btn_Livingroom_Sad;
            }
            else
            {
                btn_Sleep_Home.BackgroundImage = Properties.Resources.btn_Livingroom_Happy;
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

        #region Control Button Click
        private void BER_InfoBtnClick(object sender, EventArgs e)
        {
            MessageBox.Show(MainProgram.myTom.TomName + MainProgram.myTom.Age, Properties.Resources.infoMessBoxCaption);
        }

        private void BER_SoundBtnClick(object sender, EventArgs e)
        {
            if (isPlayed)
            {
                isPlayed = false;
                player.Stop();
                btn_Sleep_Sound.BackgroundImage = Properties.Resources.btn_SoundOff;
            }
            else
            {
                isPlayed = true;
                player.PlayLooping();
                btn_Sleep_Sound.BackgroundImage = Properties.Resources.btn_SoundOn;
            }
        }

        private void BER_CloseBtnClick(object sender, EventArgs e)
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

        #region Light On - Off
        private void BER_LightBtnClick(object sender, EventArgs e)
        {
            if (light.IsLighted)
            {
                ptb_Wardrove.Hide();
                if (File.Exists(Properties.Resources.sleepTime))
                {
                    DateTime today = DateTime.Now;
                    FileManager.OpenWriteFile(Properties.Resources.sleepTime,
                        today.ToString("MMddyyHHmmss"), false);
                }
                BackgroundImage = Properties.Resources.Bedroom_LightOff;
                light.LightClick();
            }
            else
            {
                ptb_Wardrove.Show();
                BER_LightIsTurnedOn();
                BackgroundImage = Properties.Resources.Bedroom_LightOn;
                light.LightClick();
            }
        }

        private void BER_LightIsTurnedOn()
        {
            int secondsPassed = TimeManager.GetTimeSpan(Properties.Resources.sleepTime);
            MainProgram.myTom.Sleeping(secondsPassed);
            MainProgram.myTom.Statistics.RealTom();
        }
        #endregion

        private void ptb_Wardrove_Click(object sender, EventArgs e)
        {
            wardrove.WardroveClick(this);
        }
    }
}
