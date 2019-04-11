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
using System.Net.Mail;
using System.Web;

namespace WindowsFormsApplication2
{

    public partial class p_login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KE32AB6\\MYSQL1;Initial Catalog=airport;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader Rd;
        public static int id;
        public static bool find = false;
        public p_login()
        {
            InitializeComponent();

            get_rememmber_me_data();
        }

        public void get_rememmber_me_data()
        {
            if (Properties.Settings.Default.rememmber_name != string.Empty)
            {
                txt_username.Text = Properties.Settings.Default.rememmber_name;
                txt_pass.Text = Properties.Settings.Default.rememmber_password;
                txt_pass.PasswordChar = '*';
            }
        }
        // //////////// log in
        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text == "" || txt_username.Text == "")
            {
                MessageBox.Show("Please Enter UserName & Password");
                return;
            }

            con.Open();
            cmd = new SqlCommand(" select * from p_login ('" + txt_username.Text + "')", con);

            Rd = cmd.ExecuteReader();
            find = false;
            while (Rd.Read())
            {
                find = true;
                if (Rd["password"].ToString().Trim() == txt_pass.Text)
                {
                    id = (int)Rd["passenger_id"];

                    ////// id is taken for reserving
                    ////// passenger form
                    if (checkBox1.Checked)
                    {
                        Properties.Settings.Default.rememmber_name = txt_username.Text;
                        Properties.Settings.Default.rememmber_password = txt_pass.Text;
                        Properties.Settings.Default.Save();
                    }
                    WindowsFormsApplication1.Form3 f = new WindowsFormsApplication1.Form3(id);
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
        
        private void textboxusername_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "UserName")
            {
                txt_username.Text = "";
            }
        }

        private void textboxusername_Leave_1(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "UserName";
            }
        }

        private void textboxpassword_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Password")
            {
                txt_pass.Text = "";
                txt_pass.PasswordChar = '*';
            }
        }

        private void textboxpassword_Leave_1(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.PasswordChar = '\0';
                txt_pass.Text = "Password";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up f = new sign_up();
            f.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(txt_username.Text == "")
            {
                MessageBox.Show("please type your username");
                return;
            }

            cmd = new SqlCommand(" select * from passenger where username ='" + txt_username.Text + "')", con);

            Rd = cmd.ExecuteReader();

            string gmail;
            string gmail_pass;
            string pass;

            if (Rd.Read())
            {
                gmail = Rd["gmail"].ToString().Trim();
                gmail_pass = Rd["gmail_pass"].ToString().Trim();
                pass = Rd["password"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("that username does`nt exist");
                return;
            }

            Rd.Close();
            con.Close();

            try{
                MailMessage mail = new MailMessage("", "", "", "Your password is: " + pass);
                SmtpClient client = new SmtpClient("stmp.gmail.com");
                client.Port = 587;
                client.Timeout = 100000;
                client.Credentials = new System.Net.NetworkCredential(gmail, pass);
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("done");
            }
            catch
            {
                MessageBox.Show("Failed, you entered a failed details");
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_DragLeave(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '*')
            {
                txt_pass.PasswordChar = '\0';
            }
            else
                txt_pass.PasswordChar = '*';
        }
    }
}
