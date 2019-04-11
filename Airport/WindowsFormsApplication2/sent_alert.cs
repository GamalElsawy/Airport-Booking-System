using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class sent_alert : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KE32AB6\\MYSQL1;Initial Catalog=airport;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader Rd;
        public static int id;
        public sent_alert(int id1)
        {
            InitializeComponent();
            id = id1;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from passenger where flight_id = '"+ txt_to.Text +"'",con);
            Rd = cmd.ExecuteReader();

            if (Rd.Read())
            {
                Rd.Close();
                con.Open();
                cmd = new SqlCommand("exec alert '" + rtxt_message.Text + "','" + Convert.ToInt32(txt_to.Text) + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Done :)");
                rtxt_message.Text = "";
            }
            else
            {
                Rd.Close();
                MessageBox.Show("this id doesn`t exist");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_to.Text, "[^0-9]"))
            {
                MessageBox.Show("please enter only numbers.");
                txt_to.Text = txt_to.Text.Remove(txt_to.Text.Length - 1);
            }
        }

        private void editflight_Click(object sender, EventArgs e)
        {
            Admin_Page.Form4 f = new Admin_Page.Form4(id);
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication2.EditAirline f = new WindowsFormsApplication2.EditAirline(id);
            f.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication2.start n = new WindowsFormsApplication2.start();
            n.Show();
            this.Hide();
        }
    }
}
