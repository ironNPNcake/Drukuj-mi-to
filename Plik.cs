using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace drukuj_mi_to_
{
    class Plik
    {
        public string FileName { get; private set; }
        public const int PaperWidth = 2480;
        public const int PaperLength = 3508;
        public const int LeftRightMargin = 177;
        public Bitmap FileImageToPrint;
        
        public Plik(string filename, params int[] days)
        {
            this.FileName = filename;
            FileImageToPrint = new Bitmap(PaperWidth, PaperLength, PixelFormat.Format32bppArgb);
            FileImageToPrint.SetResolution(300, 300);

            for (int i = 0; i < days.Length; i++)       //zmienna i -> i=ty dzien z kolei
            {
                if (days[i] >= 1 && days[i] <= 31)
                {
                    for (int j = LeftRightMargin; j < PaperWidth - LeftRightMargin; j++)        // j - od prawej do lewej (x)
                    {
                        for (int k = 0; k < 3; k++)     //k - szerokosc lini (zostaje podwojona)
                        {
                            FileImageToPrint.SetPixel(j, Convert.ToInt32(732.2f + (days[i] - 1) * 59.05f) - k, Color.Red);
                            FileImageToPrint.SetPixel(j, Convert.ToInt32(732.2f + (days[i] - 1) * 59.05f) + k, Color.Red);
                        }
                    }
                }
            }
            System.Windows.Forms.MessageBox.Show(filename);
            FileImageToPrint.Save(filename, ImageFormat.Png);
            FileImageToPrint.Dispose();
        }
    }
}
