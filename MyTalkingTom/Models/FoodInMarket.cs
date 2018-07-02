using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTalkingTom
{
    public class FoodInMarket
    {
        private int _price;
        private Image _image;
        private int _percentGain;
        private int _numberOfDishes;

        public FoodInMarket(Image image, int price)
        {
            _image = image;
            _price = price;
            _percentGain = price;
            _numberOfDishes = 0;
        }

        public Image ItemImage
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
            }
        }

        public int Price
        {
            get
            {
                return _price;
            }
        }

        public int NumberOfDishes
        {
            get
            {
                return _numberOfDishes;
            }
        }

        public int PercentGain
        {
            get
            {
                return _percentGain;
            }
        }

        public bool WasBought()
        {
            if(_numberOfDishes > 0)
            {
                return true;
            }
            return false;
        }

        public void Bought()
        {
            _numberOfDishes++;
        }

        public void Eaten()
        {
            _numberOfDishes--;
        }
    }
}
