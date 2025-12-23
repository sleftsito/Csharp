using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaData;
using CapaLogica.Library;

namespace capaLogica.Library
{
    public class Librarys : Coneccion
    {
        public UploadImage uploadImage = new UploadImage();
        public TextBoxEvent txtBoxEvent = new TextBoxEvent();
    }
}
