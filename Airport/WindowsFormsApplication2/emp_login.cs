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
    public partial class emp_login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KE32AB6\\MYSQL1;Initial Catalog=airport;Integrated Security=True");
        public static int id;
        public static bool find = false;

        public emp_login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_pass_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txt_pass_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text == "" || txt_username.Text == "")
            {
                MessageBox.Show("Please Enter UserName & Password");
                return;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand(" select * from emp_login('" + txt_username.Text + "')", con);
            SqlDataReader Rd = cmd.ExecuteReader();
            find = false;
            while (Rd.Read())
            {
                find = true;
                if ((Rd["password"].ToString()).Trim() == txt_pass.Text)
                {
                    id = Convert.ToInt32(Rd["emp_id"]);
                    Admin_Page.Form4 f = new Admin_Page.Form4((int)Rd["emp_id"]);
                    f.Show();
                    this.Hide();
                    break;

                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
            if (!find)
            {
                MessageBox.Show("this username isn`t exist");
            }
            Rd.Close();
            con.Close();
            
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "UserName")
            {
                txt_username.Text = "";
            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "UserName";
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Password")
            {
                txt_pass.Text = "";
                txt_pass.PasswordChar = '*';
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "Password";
                txt_pass.PasswordChar = '\0';
            }
        }
    }
}
