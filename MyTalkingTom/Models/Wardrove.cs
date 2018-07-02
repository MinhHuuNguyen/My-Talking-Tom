using MyTalkingTom.OtherForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTalkingTom.Models
{
    public class Wardrove
    {
        private bool _isOpened;

        public Wardrove(bool i)
        {
            _isOpened = i;
        }

        public bool IsOpened
        {
            get
            {
                return _isOpened;
            }
        }

        public void WardroveClick(Form fromForm)
        {
            if (_isOpened)
            {
                _isOpened = false;
                FormManager.ChangeForm(fromForm, new Bedroom());
            }
            else
            {
                _isOpened = true;
                FormManager.ChangeForm(fromForm, new WardroveForm());
            }
        }
    }
}
