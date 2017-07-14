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
    class PrintClass
    {
        PrintDialog PrintDialogToShow = new PrintDialog();
        public PrintClass(string filenameToPrint)
        {
            PrintDialogToShow.ShowHelp = true;
            PrintDialogToShow.UseEXDialog = true;
            Document DocumentToPrint = new Document(filenameToPrint);
            PrintDialogToShow.Document = DocumentToPrint.document;
            DialogResult result = PrintDialogToShow.ShowDialog();
            if(result == DialogResult.OK)
            {
                PrintDialogToShow.Document.Print();
            }
        }
    }
}
