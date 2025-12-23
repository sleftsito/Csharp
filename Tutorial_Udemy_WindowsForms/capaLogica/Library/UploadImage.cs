using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica.Library
{
    public class UploadImage
    {
        private OpenFileDialog fd = new OpenFileDialog();
        public void CargarImagen(PictureBox picturebox)
        {
            picturebox.WaitOnLoad = true;
            fd.Filter = "Imagenes|*.jpg;*.gif;*.png;*.jpeg;*.png;*.bmp";
            fd.ShowDialog();
            if(fd.FileName != string.Empty)
            {
                picturebox.ImageLocation = fd.FileName;
            }
        }
        public byte[] ImageToByte(Image img)
        {
            var converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        public Image byteArrayToImage(byte[] arr)
        {
            return Image.FromStream(new MemoryStream(arr));
        }
    }
}
