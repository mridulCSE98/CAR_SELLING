using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Selling
{
    public partial class Track : Form
    {
        public Track()
        {
            InitializeComponent();
        }

        private void Track_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.Icon = Properties.Resources.error;
                errorProvider1.SetError(this.textBox1, "Provide your code");
                MessageBox.Show("PROVIDE YOUR CODE", "ERROR", MessageBoxButtons.OK);


            }

            else
            {
                errorProvider1.Icon = Properties.Resources.check;
                MessageBox.Show("YOU HAVE JUST PLACED YOUR ORDER. THE PARCEL WILL BE DISPATCHED TOMORROW!!", "ORDER STATUS", MessageBoxButtons.OK);
                this.Hide();
                new Home().Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.Icon = Properties.Resources.error;
                errorProvider1.SetError(this.textBox1, "Provide your code");
                MessageBox.Show("PROVIDE YOUR CODE", "ERROR", MessageBoxButtons.OK);
            }

            else
            {
                errorProvider1.Icon = Properties.Resources.check;
                MessageBox.Show("YOU HAVE JUST PLACED YOUR ORDER. THE PARCEL WILL BE DISPATCHED TOMORROW!!", "ORDER STATUS", MessageBoxButtons.OK);
                this.Hide();
                new Home().Show();
            }
        }
    }
}
