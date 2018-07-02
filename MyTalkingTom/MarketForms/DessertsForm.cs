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
    public partial class DessertsForm : Form
    {
        private List<FoodInMarket> dessertList = new List<FoodInMarket>();

        public DessertsForm()
        {
            InitializeComponent();
            AddItemsToList();
            PutItemsOnShelf();
        }

        private void DessertBtnClick(object sender, EventArgs e)
        {
            foreach (var item in dessertList)
            {
                if (item.WasBought())
                {
                    Kitchen.BoughtList.Add(item);
                }
            }
            MarketForm marketForm = new MarketForm();
            FormManager.ChangeForm(this, marketForm);
        }

        private void AddItemsToList()
        {
            dessertList.Add(new FoodInMarket(Properties.Resources.dessert_1, 10));
            dessertList.Add(new FoodInMarket(Properties.Resources.dessert_2, 20));
            dessertList.Add(new FoodInMarket(Properties.Resources.dessert_3, 30));
            dessertList.Add(new FoodInMarket(Properties.Resources.dessert_4, 40));
            dessertList.Add(new FoodInMarket(Properties.Resources.dessert_5, 50));
            dessertList.Add(new FoodInMarket(Properties.Resources.dessert_6, 60));
        }

        private void PutItemsOnShelf()
        {
            btn_Dessert1.BackgroundImage = dessertList[0].ItemImage;
            btn_Dessert2.BackgroundImage = dessertList[1].ItemImage;
            btn_Dessert3.BackgroundImage = dessertList[2].ItemImage;
            btn_Dessert4.BackgroundImage = dessertList[3].ItemImage;
            btn_Dessert5.BackgroundImage = dessertList[4].ItemImage;
            btn_Dessert6.BackgroundImage = dessertList[5].ItemImage;

            lbl_Dessert1Price.Text = dessertList[0].Price.ToString();
            lbl_Dessert2Price.Text = dessertList[1].Price.ToString();
            lbl_Dessert3Price.Text = dessertList[2].Price.ToString();
            lbl_Dessert4Price.Text = dessertList[3].Price.ToString();
            lbl_Dessert5Price.Text = dessertList[4].Price.ToString();
            lbl_Dessert6Price.Text = dessertList[5].Price.ToString();

            lb_Dessert_Coins.Text = MainProgram.myTom.Coins.ToString();
        }
        
        #region Dessert Click
        private void Dessert1_Click(object sender, EventArgs e)
        {
            ReduceCoins(0);
        }

        private void Dessert2_Click(object sender, EventArgs e)
        {
            ReduceCoins(1);
        }

        private void Dessert3_Click(object sender, EventArgs e)
        {
            ReduceCoins(2);
        }

        private void Dessert4_Click(object sender, EventArgs e)
        {
            ReduceCoins(3);
        }

        private void Dessert5_Click(object sender, EventArgs e)
        {
            ReduceCoins(4);
        }

        private void Dessert6_Click(object sender, EventArgs e)
        {
            ReduceCoins(5);
        }
        #endregion

        private void ReduceCoins(int index)
        {
            if (dessertList[index].Price <= MainProgram.myTom.Coins)
            {
                dessertList[index].Bought();
                MainProgram.myTom.ReduceCoins(dessertList[index].Price);
                lb_Dessert_Coins.Text = MainProgram.myTom.Coins.ToString();
            }
            else
            {
                MessageBox.Show("Het Me Tien Roi");
            }
        }
    }
}
