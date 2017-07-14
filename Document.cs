using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace drukuj_mi_to_
{
    class Document
    {
        private string fileWithPath;
        public PrintDocument document = new PrintDocument();
        public Document(string fileNameWithPath)
        {
            fileWithPath = fileNameWithPath;
            document.PrintPage += Document_PrintPage;

        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            // e.Graphics.DrawImage((Image)pl.FileImageToPrint,0,0);
            // e.Graphics.DrawImage()
            //  e.Graphics.DrawString("asddfssdfg", new Font("Arial",10), Brushes.Black, e.MarginBounds.Top, e.MarginBounds.Left);
            Bitmap imageToPrint = new Bitmap(fileWithPath);
            e.Graphics.DrawImage(imageToPrint, new Point(0, 0));
        }

        
    }
}
