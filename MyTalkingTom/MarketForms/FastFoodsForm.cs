using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTalkingTom.MarketForms
{
    public partial class FastFoodsForm : Form
    {
        private List<FoodInMarket> fastFoodList = new List<FoodInMarket>();

        public FastFoodsForm()
        {
            InitializeComponent();
            AddItemsToList();
            PutItemsOnShelf();
        }

        private void AddItemsToList()
        {
            fastFoodList.Add(new FoodInMarket(Properties.Resources.mainCourse_1, 10));
            fastFoodList.Add(new FoodInMarket(Properties.Resources.mainCourse_2, 20));
            fastFoodList.Add(new FoodInMarket(Properties.Resources.mainCourse_3, 30));
            fastFoodList.Add(new FoodInMarket(Properties.Resources.mainCourse_4, 40));
            fastFoodList.Add(new FoodInMarket(Properties.Resources.mainCourse_5, 50));
            fastFoodList.Add(new FoodInMarket(Properties.Resources.mainCourse_6, 60));
            fastFoodList.Add(new FoodInMarket(Properties.Resources.mainCourse_7, 70));
            fastFoodList.Add(new FoodInMarket(Properties.Resources.mainCourse_8, 80));
        }

        private void PutItemsOnShelf()
        {
            btn_FastFood1.BackgroundImage = fastFoodList[0].ItemImage;
            btn_FastFood2.BackgroundImage = fastFoodList[1].ItemImage;
            btn_FastFood3.BackgroundImage = fastFoodList[2].ItemImage;
            btn_FastFood4.BackgroundImage = fastFoodList[3].ItemImage;
            btn_FastFood5.BackgroundImage = fastFoodList[4].ItemImage;
            btn_FastFood6.BackgroundImage = fastFoodList[5].ItemImage;
            btn_FastFood7.BackgroundImage = fastFoodList[6].ItemImage;
            btn_FastFood8.BackgroundImage = fastFoodList[7].ItemImage;

            lbl_FastFood1Price.Text = fastFoodList[0].Price.ToString();
            lbl_FastFood2Price.Text = fastFoodList[1].Price.ToString();
            lbl_FastFood3Price.Text = fastFoodList[2].Price.ToString();
            lbl_FastFood4Price.Text = fastFoodList[3].Price.ToString();
            lbl_FastFood5Price.Text = fastFoodList[4].Price.ToString();
            lbl_FastFood6Price.Text = fastFoodList[5].Price.ToString();
            lbl_FastFood7Price.Text = fastFoodList[6].Price.ToString();
            lbl_FastFood8Price.Text = fastFoodList[7].Price.ToString();

            lb_FastFood_Coins.Text = MainProgram.myTom.Coins.ToString();
        }

        private void FastFoodsBtnClick(object sender, EventArgs e)
        {
            foreach (var item in fastFoodList)
            {
                if (item.WasBought())
                {
                    Kitchen.BoughtList.Add(item);
                }
            }
            MarketForm marketForm = new MarketForm();
            FormManager.ChangeForm(this, marketForm);
        }

        #region Fast Food Click
        private void FastFood1_Click(object sender, EventArgs e)
        {
            ReduceCoins(0);
        }

        private void FastFood2_Click(object sender, EventArgs e)
        {
            ReduceCoins(1);
        }

        private void FastFood3_Click(object sender, EventArgs e)
        {
            ReduceCoins(2);
        }

        private void FastFood4_Click(object sender, EventArgs e)
        {
            ReduceCoins(3);
        }

        private void FastFood5_Click(object sender, EventArgs e)
        {
            ReduceCoins(4);
        }

        private void FastFood6_Click(object sender, EventArgs e)
        {
            ReduceCoins(5);
        }

        private void FastFood7_Click(object sender, EventArgs e)
        {
            ReduceCoins(6);
        }

        private void FastFood8_Click(object sender, EventArgs e)
        {
            ReduceCoins(7);
        }
        #endregion

        private void ReduceCoins(int index)
        {
            if (fastFoodList[index].Price <= MainProgram.myTom.Coins)
            {
                fastFoodList[index].Bought();
                MainProgram.myTom.ReduceCoins(fastFoodList[index].Price);
                lb_FastFood_Coins.Text = MainProgram.myTom.Coins.ToString();
            }
            else
            {
                MessageBox.Show("Het Me Tien Roi");
            }
        }
    }
}
