using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTalkingTom.Models
{
    public class Toilet
    {
        private bool _isToileting;

        public Toilet(bool i)
        {
            _isToileting = i;
        }

        public bool IsToileting
        {
            get
            {
                return _isToileting;
            }
        }

        public void ToiletClick()
        {
            if (_isToileting)
            {
                _isToileting = false;
            }
            else
            {
                _isToileting = true;
                MainProgram.myTom.PooPooing();
            }
        }
    }
}
