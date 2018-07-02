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
    public partial class FruitsForm : Form
    {
        private List<FoodInMarket> fruitsList = new List<FoodInMarket>();

        public FruitsForm()
        {
            InitializeComponent();
            AddItemsToList();
            PutItemsOnShelf();
        }

        private void AddItemsToList()
        {
            fruitsList.Add(new FoodInMarket(Properties.Resources.fruit_1, 10));
            fruitsList.Add(new FoodInMarket(Properties.Resources.fruit_2, 20));
            fruitsList.Add(new FoodInMarket(Properties.Resources.fruit_3, 30));
            fruitsList.Add(new FoodInMarket(Properties.Resources.fruit_4, 40));
            fruitsList.Add(new FoodInMarket(Properties.Resources.fruit_5, 50));
        }

        private void PutItemsOnShelf()
        {
            btn_Fruit1.BackgroundImage = fruitsList[0].ItemImage;
            btn_Fruit2.BackgroundImage = fruitsList[1].ItemImage;
            btn_Fruit3.BackgroundImage = fruitsList[2].ItemImage;
            btn_Fruit4.BackgroundImage = fruitsList[3].ItemImage;
            btn_Fruit5.BackgroundImage = fruitsList[4].ItemImage;

            lbl_Fruit1Price.Text = fruitsList[0].Price.ToString();
            lbl_Fruit2Price.Text = fruitsList[1].Price.ToString();
            lbl_Fruit3Price.Text = fruitsList[2].Price.ToString();
            lbl_Fruit4Price.Text = fruitsList[3].Price.ToString();
            lbl_Fruit5Price.Text = fruitsList[4].Price.ToString();

            lb_Fruit_Coins.Text = MainProgram.myTom.Coins.ToString();
        }

        private void FruitsBtnClick(object sender, EventArgs e)
        {
            foreach (var item in fruitsList)
            {
                if (item.WasBought())
                {
                    Kitchen.BoughtList.Add(item);
                }
            }
            MarketForm marketForm = new MarketForm();
            FormManager.ChangeForm(this, marketForm);
        }

        #region Fruit Click
        private void Fruit1_Click(object sender, EventArgs e)
        {
            ReduceCoins(0);
        }

        private void Fruit2_Click(object sender, EventArgs e)
        {
            ReduceCoins(1);
        }

        private void Fruit3_Click(object sender, EventArgs e)
        {
            ReduceCoins(2);
        }

        private void Fruit4_Click(object sender, EventArgs e)
        {
            ReduceCoins(3);
        }

        private void Fruit5_Click(object sender, EventArgs e)
        {
            ReduceCoins(4);
        }
        #endregion

        private void ReduceCoins(int index)
        {
            if (fruitsList[index].Price <= MainProgram.myTom.Coins)
            {
                fruitsList[index].Bought();
                MainProgram.myTom.ReduceCoins(fruitsList[index].Price);
                lb_Fruit_Coins.Text = MainProgram.myTom.Coins.ToString();
            }
            else
            {
                MessageBox.Show("Het Me Tien Roi");
            }
        }
    }
}
