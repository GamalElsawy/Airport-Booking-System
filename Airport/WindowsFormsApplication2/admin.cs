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

namespace Admin_Page
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KE32AB6\\MYSQL1;Initial Catalog=airport;Integrated Security=True");
       
        public static TextBox txtbox;
        public static SqlDataReader Rd;
        public static SqlCommand cmd;
        public static int id;
        public Form4(int id1)
        {
            id = id1;
            InitializeComponent();
            get_all_flight_Data();
        }
        public void get_all_flight_Data()
        {
            pnl_f_data.Controls.Clear();
            con.Open();
            cmd = new SqlCommand("EXECUTE all_flight_data", con);

            Rd = cmd.ExecuteReader();

            int i = 0; //Label lbl0;

            while (Rd.Read())
            {

                Panel pnl = new Panel();
                pnl.Size = new Size(1110, 35);
                pnl.Location = new Point(0, i * 35);

                txtbox = new TextBox();
                txtbox.Location = new Point(10, 0);
                txtbox.Size = new Size(70, 25);
                txtbox.Text = Rd["flight_id"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(125, 0);
                txtbox.Size = new Size(95, 25);
                txtbox.Text = Rd["destination"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(240, 0);
                txtbox.Size = new Size(150, 25);
                txtbox.Text = Rd["date"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(415, 0);
                txtbox.Size = new Size(60, 25);
                txtbox.Text = Rd["duration"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(560, 0);
                txtbox.Size = new Size(60, 25);
                txtbox.Text = Rd["max_passenger"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(725, 0);
                txtbox.Size = new Size(100, 25);
                txtbox.Text = Rd["airline"].ToString();
                txtbox.ReadOnly = true;

                pnl.Controls.Add(txtbox);

                pnl_f_data.Controls.Add(pnl);

                i++;
            }
            if (i == 0)
            {
                MessageBox.Show("hh");
            }

            Rd.Close();
            con.Close();

        }

        private void editflight_Click(object sender, EventArgs e)
        {
            panelleft.Height = editflight.Height;
            panelleft.Top = editflight.Top;

            get_all_flight_Data();
        }

        private void editairline_Click(object sender, EventArgs e)
        {
            panelleft.Height = editairline.Height;
            panelleft.Top = editairline.Top;
            WindowsFormsApplication2.EditAirline f = new WindowsFormsApplication2.EditAirline(id);
            f.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication2.sent_alert f2 = new WindowsFormsApplication2.sent_alert(id);
            this.Hide();
            f2.Show();
        }
        
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_f_search_id_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_f_search_id.Text, "[^0-9]"))
            {
                MessageBox.Show("please enter only numbers.");
                txt_f_search_id.Text = txt_f_search_id.Text.Remove(txt_f_search_id.Text.Length - 1);
            }
        }

        private void btn_search_id_Click(object sender, EventArgs e)
        {
            pnl_f_data.Controls.Clear();
            con.Open();
            cmd = new SqlCommand("select * from search_f ('"+txt_f_search_id.Text+ "')", con);

            Rd = cmd.ExecuteReader();

            int i = 0; //Label lbl0;

            while (Rd.Read())
            {

                Panel pnl = new Panel();
                pnl.Size = new Size(1110, 35);
                pnl.Location = new Point(0, i * 30);

                txtbox = new TextBox();
                txtbox.Location = new Point(10, 0);
                txtbox.Size = new Size(70, 25);
                txtbox.Text = Rd["flight_id"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(125, 0);
                txtbox.Size = new Size(95, 25);
                txtbox.Text = Rd["destination"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(240, 0);
                txtbox.Size = new Size(150, 25);
                txtbox.Text = Rd["date"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(415, 0);
                txtbox.Size = new Size(60, 25);
                txtbox.Text = Rd["duration"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(560, 0);
                txtbox.Size = new Size(60, 25);
                txtbox.Text = Rd["max_passenger"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(725, 0);
                txtbox.Size = new Size(100, 25);
                txtbox.Text = Rd["airline"].ToString();
                txtbox.ReadOnly = true;

                pnl.Controls.Add(txtbox);

                pnl_f_data.Controls.Add(pnl);

                i++;
            }
            if (i == 0)
            {
                MessageBox.Show("that id doesn`t exist");
            }

            Rd.Close();
            con.Close();
        }

        private void btn_f_search_num_Click(object sender, EventArgs e)
        {
            btn_all_f_data.BackColor = Color.FromArgb(255, 71, 72, 75);
            btn_f_search_num.BackColor = Color.FromArgb(255, 41, 44, 55);

            txt_f_search_id.Show();
            btn_search_id.Show();
        }

        private void btn_all_f_data_Click(object sender, EventArgs e)
        {
            get_all_flight_Data();
            btn_search_id.Hide();
            txt_f_search_id.Hide();
        }
        
        private void btn_f_edit_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication2.edit_flight2 f = new WindowsFormsApplication2.edit_flight2(id);
            this.Hide();
            f.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowsFormsApplication2.start g = new WindowsFormsApplication2.start();
            g.Show();
        }
    }
}
