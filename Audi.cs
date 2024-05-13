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
using System.Configuration;

namespace Car_Selling
{
    public partial class Audi : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["CAR"].ConnectionString;
        public Audi()
        {
            InitializeComponent();
        }

        private void Audi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 001);
            cmd.Parameters.AddWithValue("@product_name", "Audi A7");
            cmd.Parameters.AddWithValue("@price", 8000000);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown6.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Car has been added to your list ");


            }
            else
            {
                MessageBox.Show("Car has not been added");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 002);
            cmd.Parameters.AddWithValue("@product_name", "Audi 1852");
            cmd.Parameters.AddWithValue("@price", 12000000);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown5.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Car has been added to your list ");


            }
            else
            {
                MessageBox.Show("Car has not been added");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 003);
            cmd.Parameters.AddWithValue("@product_name", "Audi1741");
            cmd.Parameters.AddWithValue("@price", 40000000);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown1.Value);



            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Car has been added to your list ");


            }
            else
            {
                MessageBox.Show("Car has not been added");

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 004);
            cmd.Parameters.AddWithValue("@product_name", "Audi753");
            cmd.Parameters.AddWithValue("@price", 100000000);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown7.Value);



            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Car has been added to your list ");


            }
            else
            {
                MessageBox.Show("Car has not been added");

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 005);
            cmd.Parameters.AddWithValue("@product_name", "Audi159");
            cmd.Parameters.AddWithValue("@price", 60000000);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown8.Value);



            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Car has been added to your list ");


            }
            else
            {
                MessageBox.Show("Car has not been added");

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 006);
            cmd.Parameters.AddWithValue("@product_name", "Audi1475");
            cmd.Parameters.AddWithValue("@price", 41000000);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown9.Value);



            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Car has been added to your list ");


            }
            else
            {
                MessageBox.Show("Car has not been added");

            }

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
