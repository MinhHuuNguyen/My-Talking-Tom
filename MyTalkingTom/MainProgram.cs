using MyTalkingTom.Manager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTalkingTom
{
    class MainProgram
    {
        public static Tom myTom = new Tom();
        public static SoundPlayer player = new SoundPlayer(Properties.Resources.Thornmail);
        public static bool isPlayed = true;

        private static Timer timerWriteDateTime;
        private static int countPlay = 0, countEat = 0, countPooPoo = 0, countSleep = 0, countAge = 0;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LaunchForm launchForm = new LaunchForm
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            launchForm.Show();
            player.PlayLooping();
            SetPercent();
            TimerTick();
            Application.Run();
        }

        #region Set Percent Launching
        private static void SetPercent()
        {
            int secondsPassed = TimeManager.GetTimeSpan(Properties.Resources.dateTime);
            myTom.ReturnGame(secondsPassed);
        }
        #endregion
        
        #region Changing
        private static void TimerTick()
        {
            timerWriteDateTime = new Timer();
            timerWriteDateTime.Tick += new EventHandler(TimerChanged);
            timerWriteDateTime.Interval = 1000;
            timerWriteDateTime.Start();
        }

        private static void TimerChanged(object sender, EventArgs e)
        {
            WriteDataToFile();
            countPlay++;
            countEat++;
            countPooPoo++;
            countSleep++;
            countAge++;
            if (countPlay == 18)
            {
                countPlay = 0;
                myTom.Sad();
            }
            if(countEat == 54)
            {
                countEat = 0;
                myTom.Hungry();
            }
            if(countPooPoo == 36)
            {
                countPooPoo = 0;
                myTom.WantToPee();
            }
            if(countSleep == 108)
            {
                countSleep = 0;
                myTom.Sleepy();
            }
            if(countAge == 3)
            {
                countAge = 0;
                myTom.Old();
            }
        }

        private static void WriteDataToFile()
        {
            if (File.Exists(Properties.Resources.dateTime))
            {
                DateTime today = DateTime.Now;
                FileManager.OpenWriteFile(Properties.Resources.dateTime, 
                    today.ToString("MMddyyHHmmss"), false);
            }
            if (File.Exists(Properties.Resources.tomPlayPercent))
            {
                FileManager.OpenWriteFile(Properties.Resources.tomPlayPercent, 
                    myTom.Statistics.NowPlayPercent.ToString(), false);
            }
            if (File.Exists(Properties.Resources.tomEatPercent))
            {
                FileManager.OpenWriteFile(Properties.Resources.tomEatPercent,
                    myTom.Statistics.NowEatPercent.ToString(), false);
            }
            if (File.Exists(Properties.Resources.tomPooPooPercent))
            {
                FileManager.OpenWriteFile(Properties.Resources.tomPooPooPercent, 
                    myTom.Statistics.NowPooPooPercent.ToString(), false);
            }
            if (File.Exists(Properties.Resources.tomSleepPercent))
            {
                FileManager.OpenWriteFile(Properties.Resources.tomSleepPercent, 
                    myTom.Statistics.NowSleepPercent.ToString(), false);
            }
            if (File.Exists(Properties.Resources.tomCoins))
            {
                FileManager.OpenWriteFile(Properties.Resources.tomCoins, myTom.Coins.ToString(), false);
            }
            if (File.Exists("TomAge.txt"))
            {
                FileManager.OpenWriteFile("TomAge.txt", myTom.Age.ToString(), false);
            }
        }
        #endregion
    }
}