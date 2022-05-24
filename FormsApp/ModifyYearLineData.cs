using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class ModifyYearLineData : Form
    {
        public ModifyYearLineData()
        {
            InitializeComponent();
            label5.Hide();
        }

        private void YearInformationInserLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateInfoInDb(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pctinsert.Text) || string.IsNullOrWhiteSpace(lineinsert.Text) || string.IsNullOrWhiteSpace(zoneinsert.Text))
            {
                MessageBox.Show("Please Insert Information In All Text Boxes!");
                return;
            }

            int pct = 0;
            string line = string.Empty;
            string zone = string.Empty;

            try
            {
                pct = int.Parse(pctinsert.Text);
                line = lineinsert.Text;
                zone = zoneinsert.Text;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Incorrect data input!");
                return;
            }
            
            
            // CONNECT TO DB AND UPDATE

            //string dbAddress = 

            label5.Show();
        }

        private void ModifyYearLineData_Load(object sender, EventArgs e)
        {

        }
    }
}
