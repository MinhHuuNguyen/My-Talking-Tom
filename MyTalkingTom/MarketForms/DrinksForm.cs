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
    public partial class DrinksForm : Form
    {
        private List<FoodInMarket> drinksList = new List<FoodInMarket>();

        public DrinksForm()
        {
            InitializeComponent();
            AddItemsToList();
            PutItemsOnShelf();
        }

        private void DrinksBtnClick(object sender, EventArgs e)
        {
            foreach (var item in drinksList)
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
            drinksList.Add(new FoodInMarket(Properties.Resources.drink_1, 10));
            drinksList.Add(new FoodInMarket(Properties.Resources.drink_2, 20));
            drinksList.Add(new FoodInMarket(Properties.Resources.drink_3, 30));
            drinksList.Add(new FoodInMarket(Properties.Resources.drink_4, 40));
        }

        private void PutItemsOnShelf()
        {
            btn_Drink1.BackgroundImage = drinksList[0].ItemImage;
            btn_Drink2.BackgroundImage = drinksList[1].ItemImage;
            btn_Drink3.BackgroundImage = drinksList[2].ItemImage;
            btn_Drink4.BackgroundImage = drinksList[3].ItemImage;

            lbl_Drink1Price.Text = drinksList[0].Price.ToString();
            lbl_Drink2Price.Text = drinksList[1].Price.ToString();
            lbl_Drink3Price.Text = drinksList[2].Price.ToString();
            lbl_Drink4Price.Text = drinksList[3].Price.ToString();

            lb_Drink_Coins.Text = MainProgram.myTom.Coins.ToString();
        }

        #region Drink Click
        private void Drink1_Click(object sender, EventArgs e)
        {
            ReduceCoins(0);
        }

        private void Drink2_Click(object sender, EventArgs e)
        {
            ReduceCoins(1);
        }

        private void Drink3_Click(object sender, EventArgs e)
        {
            ReduceCoins(2);
        }

        private void Drink4_Click(object sender, EventArgs e)
        {
            ReduceCoins(3);
        }
        #endregion

        private void ReduceCoins(int index)
        {
            if (drinksList[index].Price <= MainProgram.myTom.Coins)
            {
                drinksList[index].Bought();
                MainProgram.myTom.ReduceCoins(drinksList[index].Price);
                lb_Drink_Coins.Text = MainProgram.myTom.Coins.ToString();
            }
            else
            {
                MessageBox.Show("Het Me Tien Roi");
            }
        }
    }
}
