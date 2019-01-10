using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=WIN-98WM30AGO45;Initial Catalog=Gamedb;User ID=test;Password=tester";

            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Insert into Player (Name) values('')";

            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=WIN-98WM30AGO45;Initial Catalog=Gamedb;User ID=test;Password=tester";

            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();

            SqlCommand command;
            SqlDataAdapter a = new SqlDataAdapter();
            string sql = "";

            sql = "Update Player set Name='" + "" + "'where Name='";

            command = new SqlCommand(sql, cnn);

            a.UpdateCommand = new SqlCommand(sql, cnn);
            a.UpdateCommand.ExecuteNonQuery();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=WIN-98WM30AGO45;Initial Catalog=Gamedb;User ID=test;Password=tester";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();

            SqlCommand command;
            SqlDataAdapter a = new SqlDataAdapter();
            string sql = "";

            sql = "Delete Player where Name=''";

            command = new SqlCommand(sql, cnn);

            a.UpdateCommand = new SqlCommand(sql, cnn);
            a.UpdateCommand.ExecuteNonQuery();


        }

        private void button4_Click(object sender, EventArgs e)
        {
         

        }
        private void gameHistory(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=WIN-98WM30AGO45;Initial Catalog=Gamedb;User ID=test;Password=tester";

            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();

            SqlCommand command;
            SqlDataAdapter a = new SqlDataAdapter();
            string sql = "";

            sql = "Update GameHistory set wins='', losses='', point='' " + "" + "'where Name=' ' ";

            command = new SqlCommand(sql, cnn);

            a.UpdateCommand = new SqlCommand(sql, cnn);
            a.UpdateCommand.ExecuteNonQuery();



        }


        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void connectToSaveData(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=WIN-98WM30AGO45;Initial Catalog=Gamedb;User ID=test;Password=tester";

            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
