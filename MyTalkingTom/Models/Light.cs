using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTalkingTom.Models
{
    public class Light
    {
        private bool _isLighted;

        public Light(bool i)
        {
            _isLighted = i;
        }

        public bool IsLighted
        {
            get
            {
                return _isLighted;
            }
        }

        public void LightClick()
        {
            if (_isLighted)
            {
                _isLighted = false;
            }
            else
            {
                _isLighted = true;
            }
        }
    }
}
