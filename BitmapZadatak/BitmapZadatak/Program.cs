using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace BitmapZadatak
{
    public class Program
    {
        static void Main(string[] args)
        {
            BitmapB bitmap = new BitmapB();

            bitmap.BitmapBW();
        }
    }

    public class BitmapB
    {
        public void BitmapBW()
        {
            Bitmap bitmap = (Bitmap)Image.FromFile(@"C:\Users\Reroot\Desktop\Zadatak\bitmap.bmp");

            if (bitmap == null)
            {
                Console.WriteLine("Image loaded.");
            }
            else
            {
                bitmap = new Bitmap(800, 600);
            }

            var bitmapBW = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format1bppIndexed);

            bitmapBW.Save(@"C:\Users\Reroot\Desktop\Zadatak\bitmap_bw.bmp");

            bitmap.Dispose();
        }
    }
}
