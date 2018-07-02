using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTalkingTom
{
    public partial class SignInForm : Form
    {        
        public SignInForm()
        {
            InitializeComponent();
        }

        #region Button Click Event

        private void SI_CloseBtnClick (object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SI_SignInBtnClick (object sender, EventArgs e)
        {
            SigningIn();
        }

        private void SI_PressEnter (object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (int) Keys.Enter)
            {
                SigningIn();
            }
        }
        #endregion

        private void SigningIn()
        {
            if (CheckString(txb_TomName.Text))
            {
                FileManager.CreateFile(Properties.Resources.tomInfo);
                FileManager.OpenWriteFile(Properties.Resources.tomInfo, txb_TomName.Text, true);
                MainProgram.myTom.SetName(FileManager.OpenReadFile(Properties.Resources.tomInfo));
                CreateFirstTimeFile();
                FormManager.ChangeForm(this, new Livingroom());

            }
            else
            {
                MessageBox.Show(Properties.Resources.messBoxNoNameContent, 
                    Properties.Resources.messBoxNoNameCaption);
            }
        }
        
        private static void CreateFirstTimeFile()
        {
            FileManager.CreateFile(Properties.Resources.tomPlayPercent);
            FileManager.CreateFile(Properties.Resources.tomEatPercent);
            FileManager.CreateFile(Properties.Resources.tomPooPooPercent);
            FileManager.CreateFile(Properties.Resources.tomSleepPercent);
            FileManager.CreateFile(Properties.Resources.dateTime);
            FileManager.CreateFile(Properties.Resources.sleepTime);
            FileManager.CreateFile(Properties.Resources.tomCoins);
            FileManager.CreateFile("TomAge.txt");

        }

        private bool CheckString(String str)
        {
            foreach (char a in str)
            {
                if (a != '\n' && a != ' ' && a != '\t')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
