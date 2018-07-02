using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTalkingTom.Models
{
    class Bath
    {
        private bool _isBathing;

        public Bath(bool i)
        {
            _isBathing = i;
        }

        public bool IsBathing
        {
            get
            {
                return _isBathing;
            }
        }

        public void BathClick()
        {
            if (_isBathing)
            {
                _isBathing = false;
            }
            else
            {
                _isBathing = true;
                MainProgram.myTom.PooPooing();
            }
        }
    }
}
