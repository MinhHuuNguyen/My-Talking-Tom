using MyTalkingTom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTalkingTom
{
    public partial class Bathroom : Form
    {        
        private bool isPlayed = true;
        private SoundPlayer player = new SoundPlayer(Properties.Resources.Thornmail);
        private Toilet toilet = new Toilet(false);
        private Bath bath = new Bath(false);
        private Timer myTimer;
        private Timer myTimer1;

        public Bathroom()
        {
            InitializeComponent();
            player.PlayLooping();
            TimerTick();
        }

        #region Set Label Percent
        private void SetLabelPercent(object sender, EventArgs e)
        {
            lb_BAR_Play.Text = MainProgram.myTom.Statistics.NowPlayPercent.ToString() + "%";
            lb_BAR_Eat.Text = MainProgram.myTom.Statistics.NowEatPercent.ToString() + "%";
            lb_BAR_PooPoo.Text = MainProgram.myTom.Statistics.NowPooPooPercent.ToString() + "%";
            lb_BAR_Sleep.Text = MainProgram.myTom.Statistics.NowSleepPercent.ToString() + "%";
            lb_BAR_Coins.Text = MainProgram.myTom.Coins.ToString();

            if (MainProgram.myTom.Statistics.NowPlayPercent <= 20)
            {
                btn_PooPoo_Home.BackgroundImage = Properties.Resources.btn_Livingroom_Sad;
            }
            else
            {
                btn_PooPoo_Home.BackgroundImage = Properties.Resources.btn_Livingroom_Happy;
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
        private void BAR_InfoBtnClick(object sender, EventArgs e)
        {
            MessageBox.Show(MainProgram.myTom.TomName + MainProgram.myTom.Age, Properties.Resources.infoMessBoxCaption);
        }

        private void BAR_SoundBtnClick(object sender, EventArgs e)
        {
            if (isPlayed)
            {
                isPlayed = false;
                player.Stop();
                btn_PooPoo_Sound.BackgroundImage = Properties.Resources.btn_SoundOff;
            }
            else
            {
                isPlayed = true;
                player.PlayLooping();
                btn_PooPoo_Sound.BackgroundImage = Properties.Resources.btn_SoundOn;
            }
        }

        private void BAR_CloseBtnClick(object sender, EventArgs e)
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
        private void BAR_MarketBtnClick(object sender, EventArgs e)
        {
            MarketForm.previousRoom = 3;
            MarketForm market = new MarketForm();
            FormManager.ChangeForm(this, market);
        }

        private void BAR_LivingroomBtnClick(object sender, EventArgs e)
        {
            Livingroom livingroom = new Livingroom();
            FormManager.ChangeForm(this, livingroom);
        }

        private void BAR_KitchenBtnClick(object sender, EventArgs e)
        {
            Kitchen kitchen = new Kitchen();
            FormManager.ChangeForm(this, kitchen);
        }

        private void BAR_BedroomBtnClick(object sender, EventArgs e)
        {
            Bedroom bedroom = new Bedroom();
            FormManager.ChangeForm(this, bedroom);
        }
        #endregion

        private void ptb_Bath_Click(object sender, EventArgs e)
        {
            //bath.BathClick();
            //ptb_Change1.BringToFront();
            //TimerTick1(ptb_Change1);
        }

        private void ptb_Toilet_Click(object sender, EventArgs e)
        {
            //toilet.ToiletClick();
            //ptb_Change2.BringToFront();
            //TimerTick1(ptb_Change2);
        }

        private void TimerTick1(PictureBox pic)
        {
            myTimer1 = new Timer();
            myTimer1.Tick += new EventHandler(SendToBack);
            myTimer1.Interval = 3000;
            myTimer1.Start();
        }

        private void SendToBack(object sender, EventArgs e)
        {
            toilet.ToiletClick();
            ptb_Change1.SendToBack();
            ptb_Change2.SendToBack();
            myTimer1.Stop();
        }
    }
}
