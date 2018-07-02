using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTalkingTom.MarketForms;

namespace MyTalkingTom
{
    public partial class MarketForm : Form
    {
        public static int previousRoom;
        private const String QuitMessBoxCaption = "Wanna leave Tom alone? :(";
        private const String QuitMessBoxContent = "Tom will be so sad :(";

        private Livingroom livingRoom;
        private Kitchen kitchen;
        private Bathroom bathRoom;
        private Bedroom bedRoom;

        public MarketForm()
        {
            InitializeComponent();
            lb_Market_Coins.Text = MainProgram.myTom.Coins.ToString();
        }

        #region Button Click Event

        private void Market_BackButtonClick(object sender, EventArgs e)
        {
            switch (previousRoom)
            {
                case 1:
                    {
                        livingRoom = new Livingroom();
                        livingRoom.Show();
                        livingRoom.Location = Location;
                        break;
                    }
                case 2:
                    {
                        kitchen = new Kitchen();
                        kitchen.Show();
                        kitchen.Location = Location;
                        break;
                    }
                case 3:
                    {
                        bathRoom = new Bathroom();
                        bathRoom.Show();
                        bathRoom.Location = Location;
                        break;
                    }
                case 4:
                    {
                        bedRoom = new Bedroom();
                        bedRoom.Show();
                        bedRoom.Location = Location;
                        break;
                    }
            }
            Hide();
        }

        private void Market_CloseButtonClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(QuitMessBoxContent, QuitMessBoxCaption, MessageBoxButtons.YesNo);
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

        private void MedicinesButtonClick(object sender, EventArgs e)
        {
            MedicinesForm medicinesForm = new MedicinesForm();
            FormManager.ChangeForm(this, medicinesForm);
        }

        private void FruitsButtonClick(object sender, EventArgs e)
        {
            FruitsForm fruitsForm = new FruitsForm();
            FormManager.ChangeForm(this, fruitsForm);
        }

        private void DrinksButtonClick(object sender, EventArgs e)
        {
            DrinksForm drinksForm = new DrinksForm();
            FormManager.ChangeForm(this, drinksForm);
        }

        private void FastFoodsButtonClick(object sender, EventArgs e)
        {
            FastFoodsForm fastFoodsForm = new FastFoodsForm();
            FormManager.ChangeForm(this, fastFoodsForm);
        }

        private void DessertsButtonClick(object sender, EventArgs e)
        {
            DessertsForm dessertsForm = new DessertsForm();
            FormManager.ChangeForm(this, dessertsForm);
        }
        #endregion

    }
}
