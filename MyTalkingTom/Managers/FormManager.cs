using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTalkingTom
{
    class FormManager
    {
        public static void ChangeForm(Form fromForm, Form toForm)
        {
            toForm.Show();
            toForm.Location = fromForm.Location;
            fromForm.Hide();
        }
    }
}
