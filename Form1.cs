using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace drukuj_mi_to_
{
    public partial class Form1 : Form
    {
        private string filename = "przykladowyplik.png";
        private string pathToFile = Environment.GetFolderPath( Environment.SpecialFolder.Desktop).ToString();
        private string fileWithPath;

        //sprawy zwiazane z kalendarzem

        private DateTime selectedDate;

        public Form1()
        {
            InitializeComponent();
           // monthCalendar1.mont
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            fileWithPath = Path.Combine(pathToFile, filename);
            Plik pl = new Plik(fileWithPath,1,2,6,5,8,21,22,23,29,30,31);
            PrintClass pc = new PrintClass(fileWithPath);

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            selectedDate = new DateTime();
            MessageBox.Show(monthCalendar1.SelectionStart.ToShortDateString());
        }
        private void disableDaysCheckboxes()
        {

        }
    }
}
