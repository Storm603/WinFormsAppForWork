using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void OpenLineAdditionWindow(object sender, EventArgs e)
        {
            LineAddition lineAddition = new LineAddition();
            lineAddition.Show();
        }

        private void ModiyEarlyDataInformation(object sender, EventArgs e)
        {
            ModifyYearLineData windowNew = new ModifyYearLineData();
            windowNew.Show();
        }
    }
}
