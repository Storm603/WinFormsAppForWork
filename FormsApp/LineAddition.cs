using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class LineAddition : Form
    {
        public LineAddition()
        {
            InitializeComponent();
            label12.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string PCTs = PCT.Text;
                string Line = this.Line.Text;
                string Zone = this.Zone.Text;
                int workPlace = int.Parse(this.WorkPlace.Text);
                int realWorkPlace = int.Parse(this.RealWorkPlace.Text);
                double areaBefore2019 = double.Parse(AreaBeforeM2.Text);
                double areaAfter2019 = double.Parse(Area2019.Text);
                double areaAfter2020 = double.Parse(Area2020.Text);
                double areaAfter2021 = double.Parse(Area2021.Text);
                double areaAfter2022 = double.Parse(Area2022.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Incorrect data format, please insert the correct data!");
                return;
            }

            string databaseAddress = "server=LAPTOP-B774MQCB;database=WinFormsForWAB;UID=Kristiyan;password=SoftUn!2021";
            SqlConnection connection = new SqlConnection(databaseAddress);

            connection.Open();

            MessageBox.Show("connection success!");

            connection.Close();

            //INSERT NEW RECORD IN DB

            label12.Show();
            label12.Text = "Data submitted Successfully!";
        }
    }
}
