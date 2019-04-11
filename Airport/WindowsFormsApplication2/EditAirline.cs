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
    public partial class EditAirline : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KE32AB6\\MYSQL1;Initial Catalog=airport;Integrated Security=True");
        public static int id;
        public static TextBox txtbox;
        public static SqlDataReader Rd;
        public static SqlCommand cmd;
        public EditAirline(int id1)
        {
            InitializeComponent();

            
            id = id1;
            get_all_air_data();
            rate.Items.Add("bad");
            rate.Items.Add("good");
            rate.Items.Add("very good");
            rate.Text = "good";
        }

        public void get_all_air_data()
        {
            pnl_a_data.Controls.Clear();

            con.Open();
            bool find = false;
            cmd = new SqlCommand("exec all_air_data", con);
            Rd = cmd.ExecuteReader();
            int i = 0;
            while (Rd.Read())
            {
                find = true;

                Panel pnl = new Panel();
                pnl.Size = new Size(1100, 35);
                pnl.Location = new Point(0, i * 30);

                txtbox = new TextBox();
                txtbox.Location = new Point(0, 0);
                txtbox.Size = new Size(80, 25);
                txtbox.Text = Rd["airline_id"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(110, 0);
                txtbox.Size = new Size(80, 25);
                txtbox.Text = Rd["name"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(230, 0);
                txtbox.Size = new Size(80, 25);
                txtbox.Text = Rd["services"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(340, 0);
                txtbox.Size = new Size(80, 25);
                txtbox.Text = Rd["routes"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(460, 0);
                txtbox.Size = new Size(70, 25);
                txtbox.Text = Rd["rate"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(560, 0);
                txtbox.Size = new Size(70, 25);
                txtbox.Text = Rd["num_of_planes"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Size = new Size(80, 22);
                txtbox.Location = new Point(705, 0);
                txtbox.Text = Rd["n_o_f_p_d"].ToString();

                pnl.Controls.Add(txtbox);

                pnl_a_data.Controls.Add(pnl);

                i++;
            }
            Rd.Close();
            con.Close();

        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_f_search_num_Click(object sender, EventArgs e)
        {

        }

        private void pnl_search_air_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_a_all_data_Click(object sender, EventArgs e)
        {
            btn_a_all_data.BackColor = Color.FromArgb(255, 41, 44, 55); ;
            btn_a_edit.BackColor = Color.FromArgb(255, 71, 72, 75);

            pnl_a_upd.Hide();
            pnl_search_air.Show();
            get_all_air_data();
        }

        private void btn_a_search_name_Click(object sender, EventArgs e)
        {
            bool find = false;
            pnl_a_data.Controls.Clear();
            con.Open();
            if (txt_a_search.Text == "")
                MessageBox.Show("Please Enter a name ");
            else
            {


                cmd = new SqlCommand(" select * from  search_a('" + txt_a_search.Text + "')", con);
                Rd = cmd.ExecuteReader();

                int i = 0;
                while (Rd.Read())
                {
                    find = true;

                    Panel pnl = new Panel();
                    pnl.Size = new Size(1100, 35);
                    pnl.Location = new Point(0, i * 30);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(0, 0);
                    txtbox.Size = new Size(80, 25);
                    txtbox.Text = Rd["airline_id"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(110, 0);
                    txtbox.Size = new Size(80, 25);
                    txtbox.Text = Rd["name"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(230, 0);
                    txtbox.Size = new Size(80, 25);
                    txtbox.Text = Rd["services"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(340, 0);
                    txtbox.Size = new Size(80, 25);
                    txtbox.Text = Rd["routes"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(460, 0);
                    txtbox.Size = new Size(70, 25);
                    txtbox.Text = Rd["rate"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(560, 0);
                    txtbox.Size = new Size(70, 25);
                    txtbox.Text = Rd["num_of_planes"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    txtbox = new TextBox();
                    txtbox.Size = new Size(80, 22);
                    txtbox.Location = new Point(705, 0);
                    txtbox.Text = Rd["n_o_f_p_d"].ToString();

                    pnl.Controls.Add(txtbox);

                    pnl_a_data.Controls.Add(pnl);

                    i++;
                }
                if (!find)
                {
                    MessageBox.Show("that name doen`t exist");

                }

                Rd.Close();
                con.Close();
            }
         }

        private void button3_Click(object sender, EventArgs e)
        {
           
            con.Open();
            cmd = new SqlCommand("select * from airline where name = '" + txt_name.Text + "'", con);
            Rd = cmd.ExecuteReader();
            if (Rd.Read())
            {
                cmd = new SqlCommand("exec update_a '" + txt_name.Text + "','" + route.Text + "','" + rate.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("You just entered an invalid airline name");
            }
        }

        private void btn_a_edit_Click(object sender, EventArgs e)
        {
            btn_a_search_name.BackColor = Color.FromArgb(255, 41, 44, 55);
            btn_a_all_data.BackColor = Color.FromArgb(255, 71, 72, 75);
            btn_a_edit.BackColor = Color.FromArgb(255, 41, 44, 55);
            pnl_search_air.Hide();
            pnl_a_upd.Show();
        }

        private void editflight_Click(object sender, EventArgs e)
        {
            Admin_Page.Form4 f = new Admin_Page.Form4(id);
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication2.sent_alert f2 = new WindowsFormsApplication2.sent_alert(id);
            this.Hide();
            f2.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication2.start m = new WindowsFormsApplication2.start();
            this.Hide();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
