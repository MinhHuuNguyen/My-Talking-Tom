using MyTalkingTom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTalkingTom.OtherForms
{
    public partial class WardroveForm : Form
    {
        private Wardrove wardrove = new Wardrove(true);

        public WardroveForm()
        {
            InitializeComponent();
        }

        private void fastFoodsShopName_Click(object sender, EventArgs e)
        {
            wardrove.WardroveClick(this);
        }
    }
}
