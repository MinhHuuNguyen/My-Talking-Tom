using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTalkingTom
{
    public class Tom
    {
        private Statistics _statistics = new Statistics();
        private String _tomName;
        private int _age;
        private int _coins;

        public Tom()
        {
            if (File.Exists(Properties.Resources.tomPlayPercent)
                && File.Exists(Properties.Resources.tomEatPercent)
                && File.Exists(Properties.Resources.tomPooPooPercent)
                && File.Exists(Properties.Resources.tomSleepPercent)
                && File.Exists(Properties.Resources.tomInfo)
                && File.Exists(Properties.Resources.tomCoins)
                && File.Exists("TomAge.txt"))
            {
                _statistics.NowPlayPercent = Convert.ToInt32(FileManager.OpenReadFile(
                    Properties.Resources.tomPlayPercent));
                _statistics.NowEatPercent = Convert.ToInt32(FileManager.OpenReadFile(
                    Properties.Resources.tomEatPercent));
                _statistics.NowPooPooPercent = Convert.ToInt32(FileManager.OpenReadFile(
                    Properties.Resources.tomPooPooPercent));
                _statistics.NowSleepPercent = Convert.ToInt32(FileManager.OpenReadFile(
                    Properties.Resources.tomSleepPercent));
                SetName(FileManager.OpenReadFile(Properties.Resources.tomInfo));
                _coins = Convert.ToInt32(FileManager.OpenReadFile(Properties.Resources.tomCoins));
                _age = Convert.ToInt32(FileManager.OpenReadFile("TomAge.txt"));
            }
            else
            {
                _statistics.NowPlayPercent = 100;
                _coins = 100;
                _age = 0;
            }
        }
        
        #region Getter - Setter
        public Statistics Statistics
        {
            get
            {
                return _statistics;
            }
        }

        public String TomName
        {
            get
            {
                return _tomName;
            }
            set
            {
                _tomName = value;
            }
        }

        public int Coins
        {
            get
            {
                return _coins;
            }
            set
            {
                _coins = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        #endregion

        #region Methods
        public void SetName(String name)
        {
            _tomName = name;
        }

        public void ReturnGame(int secondsPassed)
        {
            _statistics.NowPlayPercentDec(secondsPassed / 18);
            _statistics.NowEatPercentDec(secondsPassed / 54);
            _statistics.NowPooPooPercentDec(secondsPassed / 36);
            _statistics.NowSleepPercentDec(secondsPassed / 108);
        }

        public void Old()
        {
            _age++;
        }

        public void Sad()
        {
            _statistics.NowPlayPercentDec(1);
        }

        public void Hungry()
        {
            _statistics.NowEatPercentDec(1);
        }

        public void WantToPee()
        {
            _statistics.NowPooPooPercentDec(1);
        }

        public void Sleepy()
        {
            _statistics.NowSleepPercentDec(1);
        }

        public void ReduceCoins(int coins)
        {
            _coins -= coins;
        }

        public void Happying()
        {
            _statistics.NowPlayPercentInc(1);
        }

        public void Eating(int percentGain)
        {
            _statistics.NowEatPercentInc(percentGain);
        }

        public void PooPooing()
        {
            _statistics.NowPooPooPercentInc(100);
        }

        public void Sleeping(int secondsPassed)
        {
            _statistics.NowSleepPercentInc(secondsPassed / 10);
        }
        #endregion 
    }
}
