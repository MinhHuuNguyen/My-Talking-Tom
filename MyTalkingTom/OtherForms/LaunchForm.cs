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
    public partial class LaunchForm : Form
    {
        private const String tomInfo = "TomInfo.txt";
        private Timer myTimer = new Timer();
        private bool isLoaded = false;

        public LaunchForm()
        {
            InitializeComponent();
            Loading();
        }

        private void Loading()
        {
            myTimer.Tick += new EventHandler(LoadingTick);
            myTimer.Interval = 3000;
            myTimer.Start();
        }

        private void LoadingTick(object sender, EventArgs e)
        {
            if (isLoaded == false)
            {
                isLoaded = true;
                CheckExistingFile(tomInfo);
            }
        }

        private void CheckExistingFile(String filePath)
        {
            if (File.Exists(filePath))
            {
                FormManager.ChangeForm(this, new Livingroom());
            }
            else
            {
                FormManager.ChangeForm(this, new SignInForm());

            }
        }
    }
}
