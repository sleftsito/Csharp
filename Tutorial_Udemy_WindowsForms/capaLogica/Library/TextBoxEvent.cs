using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace capaLogica.Library
{
    public class TextBoxEvent
    {
        public void txtKeyPress(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (e.KeyChar == Convert.ToChar(Convert.ToChar(Keys.Enter))) {  e.Handled = true; }
            else if (char.IsControl(e.KeyChar)) {e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled= false; }
            else { e.Handled = true; }
        }
        public void numberKeyPress(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        public bool comprobarFormatoEmail(string Email)
        {
            return new EmailAddressAttribute().IsValid(Email);
        }
    }
}
