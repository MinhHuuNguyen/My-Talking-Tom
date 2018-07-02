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
    public partial class MedicinesForm : Form
    {
        public MedicinesForm()
        {
            InitializeComponent();
        }

        private void MedicinesBtnClick(object sender, EventArgs e)
        {
            MarketForm marketForm = new MarketForm();
            FormManager.ChangeForm(this, marketForm);
        }
    }
}
