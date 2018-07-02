using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTalkingTom.Models
{
    public class Clothes
    {
        private int _price;
        private bool _isWorn;

        public int Price
        {
            get
            {
                return _price;
            }
        }

        public bool IsWorn
        {
            get
            {
                return _isWorn;
            }
        }
    }
}
