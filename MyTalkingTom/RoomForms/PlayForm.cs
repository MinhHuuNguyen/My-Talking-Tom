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
    public partial class Play : Form
    {
        private const String QuitMessBoxCaption = "Wanna leave Tom alone? :(";
        private const String QuitMessBoxContent = "Tom will be so sad :(";
        private static SoundPlayer player = new SoundPlayer(Properties.Resources.Thornmail);

        public Play()
        {
            InitializeComponent();
            player.PlayLooping();
        }

        #region Button Click Event
        private void Play_BackButtonClick(object sender, EventArgs e)
        {
            Livingroom livingroom = new Livingroom();
            FormManager.ChangeForm(this, livingroom);
        }

        private void ComingSoon()
        {
            MessageBox.Show("Coming Soon !!!");
        }

        private void Play_CloseBtnClick(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show(QuitMessBoxContent, QuitMessBoxCaption, MessageBoxButtons.YesNo);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ComingSoon();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ComingSoon();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ComingSoon();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ComingSoon();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ComingSoon();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ComingSoon();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ComingSoon();
        }
    }
}
