using MyTalkingTom.MarketForms;
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
    public partial class Kitchen : Form
    {
        private int defaultDish = 0;        
        private bool isPlayed = true;
        private static SoundPlayer player = new SoundPlayer(Properties.Resources.Thornmail);
        private static Timer myTimer;

        private static List<FoodInMarket> boughtList = new List<FoodInMarket>();
        internal static List<FoodInMarket> BoughtList { get => boughtList; set => boughtList = value; }

        public Kitchen()
        {
            InitializeComponent();
            player.PlayLooping();
            TimerTick();
            SetPicture(defaultDish);
        }
        
        private void KC_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Properties.Resources.MyTom, 450, 80, 273, 451);
            g.DrawImage(Properties.Resources.Kitchen_DiningTable, 85, 400, 1000, 500);
        }
        
        private List<FoodInMarket> SetPicture(int a)
        {
            List<FoodInMarket> temBoughtList = new List<FoodInMarket>();
            if (boughtList.Count >= 3)
            {
                int first = a;
                int second = a + 1;
                int third = a + 2;
                if (first == -2)
                {
                    firstDish.BackgroundImage = boughtList[boughtList.Count - 2].ItemImage;
                    firstLabel.Text = boughtList[boughtList.Count - 2].NumberOfDishes.ToString();
                    temBoughtList.Add(boughtList[boughtList.Count - 2]);
                }
                else if (first == -1)
                {
                    firstDish.BackgroundImage = boughtList[boughtList.Count - 1].ItemImage;
                    firstLabel.Text = boughtList[boughtList.Count - 1].NumberOfDishes.ToString();
                    temBoughtList.Add(boughtList[boughtList.Count - 1]);
                }
                else
                {
                    firstDish.BackgroundImage = boughtList[first].ItemImage;
                    firstLabel.Text = boughtList[first].NumberOfDishes.ToString();
                    temBoughtList.Add(boughtList[first]);
                }

                if (second == -1)
                {
                    secondDish.BackgroundImage = boughtList[boughtList.Count - 1].ItemImage;
                    secondLabel.Text = boughtList[boughtList.Count - 1].NumberOfDishes.ToString();
                    temBoughtList.Add(boughtList[boughtList.Count - 1]);
                }
                else
                {
                    secondDish.BackgroundImage = boughtList[second].ItemImage;
                    secondLabel.Text = boughtList[second].NumberOfDishes.ToString();
                    temBoughtList.Add(boughtList[second]);
                }

                thirdDish.BackgroundImage = boughtList[third].ItemImage;
                thirdLabel.Text = boughtList[third].NumberOfDishes.ToString();
                temBoughtList.Add(boughtList[third]);
            }
            else if (boughtList.Count == 2)
            {
                firstDish.BackgroundImage = boughtList[0].ItemImage;
                firstLabel.Text = boughtList[0].NumberOfDishes.ToString();
                temBoughtList.Add(boughtList[0]);
                secondDish.BackgroundImage = boughtList[1].ItemImage;
                secondLabel.Text = boughtList[1].NumberOfDishes.ToString();
                temBoughtList.Add(boughtList[1]);
                thirdDish.BackgroundImage = null;
                thirdLabel.Text = null;
            }
            else if (boughtList.Count == 1)
            {
                firstDish.BackgroundImage = boughtList[0].ItemImage;
                firstLabel.Text = boughtList[0].NumberOfDishes.ToString();
                temBoughtList.Add(boughtList[0]);
                secondDish.BackgroundImage = null;
                secondLabel.Text = null;
                thirdDish.BackgroundImage = null;
                thirdLabel.Text = null;
            }
            else
            {
                firstDish.BackgroundImage = null;
                firstLabel.Text = null;
                secondDish.BackgroundImage = null;
                secondLabel.Text = null;
                thirdDish.BackgroundImage = null;
                thirdLabel.Text = null;
            }
            return temBoughtList;
        }

        #region Set Label Percent
        private void SetLabelPercent(object sender, EventArgs e)
        {
            lb_KC_Play.Text = MainProgram.myTom.Statistics.NowPlayPercent.ToString() + "%";
            lb_KC_Eat.Text = MainProgram.myTom.Statistics.NowEatPercent.ToString() + "%";
            lb_KC_PooPoo.Text = MainProgram.myTom.Statistics.NowPooPooPercent.ToString() + "%";
            lb_KC_Sleep.Text = MainProgram.myTom.Statistics.NowSleepPercent.ToString() + "%";
            lb_KC_Coins.Text = MainProgram.myTom.Coins.ToString();

            if (MainProgram.myTom.Statistics.NowPlayPercent <= 20)
            {
                btn_Eat_Home.BackgroundImage = Properties.Resources.btn_Livingroom_Sad;
            }
            else
            {
                btn_Eat_Home.BackgroundImage = Properties.Resources.btn_Livingroom_Happy;
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
        private void KC_InfoBtnClick (object sender, EventArgs e)
        {
            MessageBox.Show(MainProgram.myTom.TomName + MainProgram.myTom.Age, Properties.Resources.infoMessBoxCaption);
        }

        private void KC_SoundBtnClick(object sender, EventArgs e)
        {
            if (isPlayed)
            {
                isPlayed = false;
                player.Stop();
                btn_Eat_Sound.BackgroundImage = Properties.Resources.btn_SoundOff;
            }
            else
            {
                isPlayed = true;
                player.PlayLooping();
                btn_Eat_Sound.BackgroundImage = Properties.Resources.btn_SoundOn;
            }
        }

        private void KC_CloseBtnClick(object sender, EventArgs e)
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
        private void KC_MarketBtnClick(object sender, EventArgs e)
        {
            MarketForm.previousRoom = 2;
            MarketForm market = new MarketForm();
            FormManager.ChangeForm(this, market);
        }

        private void KC_LivingroomBtnClick(object sender, EventArgs e)
        {
            Livingroom livingroom = new Livingroom();
            FormManager.ChangeForm(this, livingroom);
        }

        private void KC_BathroomBtnClick(object sender, EventArgs e)
        {
            Bathroom bathroom = new Bathroom();
            FormManager.ChangeForm(this, bathroom);
        }

        private void KC_BedroomBtnClick(object sender, EventArgs e)
        {
            Bedroom bedroom = new Bedroom();
            FormManager.ChangeForm(this, bedroom);
        }
        #endregion

        #region Eat Button Click Event
        private void KC_PreviousBtnClick(object sender, EventArgs e)
        {
            if (defaultDish >= -1)
            {
                SetPicture(--defaultDish);
            }
            else
            {
                defaultDish = boughtList.Count - 2;
                SetPicture(--defaultDish);
            }
        }

        private void KC_NextBtnClick(object sender, EventArgs e)
        {
            if (defaultDish + 4 <= boughtList.Count)
            {
                SetPicture(++defaultDish);
            }
            else
            {
                defaultDish = -3;
                SetPicture(++defaultDish);
            }
        }

        private void KC_FirstDishBtnClick(object sender, EventArgs e)
        {
            if(boughtList.Count >= 1)
            {
                List<FoodInMarket> temBoughtList1 = new List<FoodInMarket>();
                temBoughtList1 = SetPicture(defaultDish);
                temBoughtList1[0].Eaten();
                MainProgram.myTom.Eating(temBoughtList1[0].PercentGain);
                MainProgram.myTom.Statistics.RealTom();
                if (!temBoughtList1[0].WasBought())
                {
                    boughtList.Remove(temBoughtList1[0]);
                }
                SetPicture(defaultDish);
            }
        }

        private void KC_SecondDishBtnClick(object sender, EventArgs e)
        {
            if (boughtList.Count >= 2)
            {
                List<FoodInMarket> temBoughtList1 = new List<FoodInMarket>();
                temBoughtList1 = SetPicture(defaultDish);
                temBoughtList1[1].Eaten();
                MainProgram.myTom.Eating(temBoughtList1[1].PercentGain);
                MainProgram.myTom.Statistics.RealTom();
                if (!temBoughtList1[1].WasBought())
                {
                    boughtList.Remove(temBoughtList1[1]);
                }
                SetPicture(defaultDish);
            }
        }

        private void KC_ThirdDishBtnClick(object sender, EventArgs e)
        {
            if (boughtList.Count >= 3)
            {
                List<FoodInMarket> temBoughtList1 = new List<FoodInMarket>();
                temBoughtList1 = SetPicture(defaultDish);
                temBoughtList1[2].Eaten();
                MainProgram.myTom.Eating(temBoughtList1[2].PercentGain);
                MainProgram.myTom.Statistics.RealTom();
                if (!temBoughtList1[2].WasBought())
                {
                    boughtList.Remove(temBoughtList1[2]);
                }
                SetPicture(defaultDish);
            }
        }
        #endregion
    }
}
