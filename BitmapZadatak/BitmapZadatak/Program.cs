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

            int counter = 0;

            bitmap.BitmapBW(counter);
        }
    }

    public class BitmapB
    {
        public void BitmapBW(int counter)
        {
            Console.WriteLine("Enter the name of the bitmap you want to make black and white: ");
            string bitmapName = Console.ReadLine();

            string filePath = String.Format("C:/Users/Reroot/Desktop/Zadatak/{0}.bmp", bitmapName);
            filePath.Replace('/', '\\');

            Bitmap bitmap = new Bitmap(100, 100);

            if (File.Exists(filePath))
            {        
                Console.WriteLine("Image loaded.");
                bitmap = (Bitmap)Image.FromFile(filePath);
                counter++;
            }
            else
            {
                string size;

                do
                {
                    Console.WriteLine("Enter your preffered bitmap size(example: 400x600)");
                    size = Console.ReadLine();

                } while (!size.Contains('x'));               

                
                string[] sizeSplit = size.Split('x');

                bitmap = new Bitmap(Convert.ToInt32(sizeSplit[0]), Convert.ToInt32(sizeSplit[1]));

                counter++;
            }

            var bitmapBW = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format1bppIndexed);


            for(int i = 0; i < counter; i++)
            {
                string filePathSave = String.Format("C:/Users/Reroot/Desktop/Zadatak/bitmap{0}.bmp", i);

                bitmapBW.Save(filePathSave);
            }

            bitmap.Dispose();
        }
    }
}
