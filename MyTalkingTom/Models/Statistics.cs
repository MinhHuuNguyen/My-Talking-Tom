using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTalkingTom
{
    public class Statistics
    {
        private int _nowPlayPercent;
        private int _nowEatPercent;
        private int _nowPooPooPercent;
        private int _nowSleepPercent;

        public Statistics()
        {
            _nowPlayPercent = 100;
            _nowEatPercent = 100;
            _nowPooPooPercent = 100;
            _nowSleepPercent = 100;
        }

        public int NowPlayPercent
        {
            get
            {
                return _nowPlayPercent;
            }
            set
            {
                _nowPlayPercent = value;
            }
        }

        public int NowEatPercent
        {
            get
            {
                return _nowEatPercent;
            }
            set
            {
                _nowPlayPercent = value;
            }
        }

        public int NowPooPooPercent
        {
            get
            {
                return _nowPooPooPercent;
            }
            set
            {
                _nowPlayPercent = value;
            }
        }

        public int NowSleepPercent
        {
            get
            {
                return _nowSleepPercent;
            }
            set
            {
                _nowPlayPercent = value;
            }
        }

        public void NowPlayPercentInc(int d)
        {
            _nowPlayPercent += d;
            RealTom();
        }

        public void NowEatPercentInc(int d)
        {
            _nowEatPercent += d;
            RealTom();
        }

        public void NowPooPooPercentInc(int d)
        {
            _nowPooPooPercent += d;
            RealTom();
        }

        public void NowSleepPercentInc(int d)
        {
            _nowSleepPercent += d;
            RealTom();
        }

        public void NowPlayPercentDec(int d)
        {
            _nowPlayPercent -= d;
            RealTom();
        }

        public void NowEatPercentDec(int d)
        {
            _nowEatPercent -= d;
            RealTom();
        }

        public void NowPooPooPercentDec(int d)
        {
            _nowPooPooPercent -= d;
            RealTom();
        }

        public void NowSleepPercentDec(int d)
        {
            _nowSleepPercent -= d;
            RealTom();
        }

        public void RealTom()
        {
            if (_nowPlayPercent <= 0)
            {
                _nowPlayPercent = 0;
            }
            if (_nowEatPercent <= 0)
            {
                _nowEatPercent = 0;
            }
            if (_nowPooPooPercent <= 0)
            {
                _nowPooPooPercent = 0;
            }
            if (_nowSleepPercent <= 0)
            {
                _nowSleepPercent = 0;
            }

            if (_nowPlayPercent >= 100)
            {
                _nowPlayPercent = 100;
            }
            if (_nowEatPercent >= 100)
            {
                _nowEatPercent = 100;
            }
            if (_nowPooPooPercent >= 100)
            {
                _nowPooPooPercent = 100;
            }
            if (_nowSleepPercent >= 100)
            {
                _nowSleepPercent = 100;
            }
        }
    }
}
