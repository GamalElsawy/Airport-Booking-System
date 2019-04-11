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

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KE32AB6\\MYSQL1;Initial Catalog=airport;Integrated Security=True");
        public static int id;
        public static EventArgs e;
        public static object sender;
        public static TextBox txtbox;
        public static SqlDataReader Rd;
        public static SqlCommand cmd;



        public Form3(int id1)
        {
            id = id1;

            InitializeComponent();

            richTextBox1.Location = new Point(222, 187);

            con.Open();
            cmd = new SqlCommand("select alert from passenger where passenger_id ='" + id + "'", con);
            Rd = cmd.ExecuteReader();
            if (!Rd.Read())
            {
                btn_alerts.Enabled = false;
            }
            Rd.Close();
            con.Close();

                pnl_search_f.Show();
            pnl_search_f.Size = new Size(1124,650);
            pnl_search_f.Location = new Point(207,87);
            pnl_search_air.Size = new Size(1124,650);
            pnl_search_air.Location = new Point(207, 87);
            pnl_resch.Size = new Size(1124,396);
            pnl_resch.Location = new Point(207,330);

            get_all_air_data();
            get_all_f_data();
            

            btn_all_f_data.BackColor = Color.FromArgb(255, 41, 44, 55);
            btn_search_f.BackColor = Color.FromArgb(255, 41, 44, 55);
            btn_f_search_dest.BackColor = Color.FromArgb(255, 71, 72, 75);
            btn_f_search_num.BackColor = Color.FromArgb(255, 71, 72, 75);
            btn_resch.BackColor = Color.FromArgb(255, 71, 72, 75);
            btn_search_air.BackColor = Color.FromArgb(255, 71, 72, 75);
        }

        private void btnclick(object sender, EventArgs e, string v)
        {
            con.Open();
            cmd = new SqlCommand("exec all_flight_data", con);
            Rd = cmd.ExecuteReader();
            bool found = false;
            while (Rd.Read())
            {
                if (Convert.ToInt32(v) == Convert.ToInt32(Rd["flight_id"]))
                {
                    found = true;
                    break;
                }
            }
            Rd.Close();

            if (found)
            {
                Rd.Close();
                cmd = new SqlCommand("select * from flight_passenger where passenger_id ='" + id + "' and flight_id ='" + Convert.ToInt32(v) + "'", con);
                Rd = cmd.ExecuteReader();

                if (!Rd.Read())
                {
                    Rd.Close();
                    cmd = new SqlCommand("EXECUTE reserve '" + Convert.ToInt32(v) + "','" + id + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done :)");
                }
                else
                {
                    MessageBox.Show("you have allready reserved in this flight");
                }
            }

            else
            {
                MessageBox.Show("that id does`nt exist");
            }


            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Function gate all data from airline 

        public  void get_all_air_data()
        {
            pnl_a_data.Controls.Clear();

            con.Open();

            cmd = new SqlCommand("exec all_air_data", con);
            Rd = cmd.ExecuteReader();
            int i = 0;
            while (Rd.Read())
            {

                Panel pnl = new Panel();
                pnl.Size = new Size(1100, 35);
                pnl.Location = new Point(0, i * 35);

                txtbox = new TextBox();
                txtbox.Location = new Point(5, 0);
                txtbox.Size = new Size(92, 25);
                txtbox.Text = Rd["airline_id"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(150, 0);
                txtbox.Size = new Size(120, 25);
                txtbox.Text = Rd["name"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(280, 0);
                txtbox.Size = new Size(120, 25);
                txtbox.Text = Rd["services"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(470, 0);
                txtbox.Size = new Size(90, 25);
                txtbox.Text = Rd["routes"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(625, 0);
                txtbox.Size = new Size(135, 25);
                txtbox.Text = Rd["rate"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(790, 0);
                txtbox.Size = new Size(130, 25);
                txtbox.Text = Rd["num_of_planes"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Size = new Size(105, 22);
                txtbox.Location = new Point(965, 0);
                txtbox.Text = Rd["n_o_f_p_d"].ToString();

                pnl.Controls.Add(txtbox);

                pnl_a_data.Controls.Add(pnl);

                i++;
            }
            Rd.Close();
            con.Close();

        }

        public void get_all_f_data() {
            con.Open();
            cmd = new SqlCommand("EXECUTE all_flight_data", con);

            Rd = cmd.ExecuteReader();

            int i = 0; //Label lbl0;

            while (Rd.Read())
            {

                Panel pnl = new Panel();
                pnl.Size = new Size(1100, 35);
                pnl.Location = new Point(0, i * 35);

                txtbox = new TextBox();
                txtbox.Location = new Point(10, 0);
                txtbox.Size = new Size(95, 25);
                txtbox.Text = Rd["flight_id"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(130, 0);
                txtbox.Size = new Size(120, 25);
                txtbox.Text = Rd["destination"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(280, 0);
                txtbox.Size = new Size(120, 25);
                txtbox.Text = Rd["date"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(480, 0);
                txtbox.Size = new Size(90, 25);
                txtbox.Text = Rd["duration"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(624, 0);
                txtbox.Size = new Size(135, 25);
                txtbox.Text = Rd["max_passenger"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(800, 0);
                txtbox.Size = new Size(130, 25);
                txtbox.Text = Rd["airline"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                Button btn = new Button();
                btn.Size = new Size(105, 22);
                btn.Location = new Point(960, 0);
                btn.Text = "reserve";
                btn.Name = Rd["flight_id"].ToString();

                btn.Click += delegate (object sender, EventArgs e)
                {
                    btnclick(sender, e, btn.Name);
                };


                pnl.Controls.Add(btn);

                pnl_f_data.Controls.Add(pnl);

                i++;
            }
            if (i == 0)
            {
                lbl_flight_num.Visible = true;
            }

            Rd.Close();
            con.Close();
        }

        /// ///////// airline
        private void button2_Click_1(object sender, EventArgs e)
        {
            pnl_a_data.Controls.Clear();

            pnl_search_f.Visible = false;
            pnl_search_air.Visible = true;
            pnl_resch.Visible = false;
            richTextBox1.Hide();
            
            pnl_yellow.Height = btn_search_air.Height;
            pnl_yellow.Top = btn_search_air.Top;

            btn_search_air.BackColor =  Color.FromArgb(255, 41, 44, 55);
            btn_search_f.BackColor = Color.FromArgb(255, 71, 72, 75);
            btn_resch.BackColor = Color.FromArgb(255, 71, 72, 75);
            btn_alerts.BackColor = Color.FromArgb(255, 71, 72, 75);

            get_all_air_data();
            
        }

        /// //////// flight
        private void button1_Click(object sender, EventArgs e)
        {
            pnl_f_data.Controls.Clear();
            get_all_f_data();

            pnl_search_f.Show();
            pnl_menu_btns.Show();
            pnl_resch.Hide();
            pnl_search_air.Hide();
            pnl_f_data.Show();
            richTextBox1.Hide();
            pnl_search_dest.Hide();
            pnl_search_id.Hide();

            btn_search_f.BackColor = Color.FromArgb(255, 41, 44, 55); // dark color
            btn_all_f_data.BackColor = Color.FromArgb(255, 41, 44, 55); // dark

            btn_search_air.BackColor = Color.FromArgb(255, 71, 72, 75);
            btn_f_search_num.BackColor = Color.FromArgb(255, 71, 72, 75); // light color
            btn_f_search_dest.BackColor = Color.FromArgb(255, 71, 72, 75); // light
            btn_resch.BackColor = Color.FromArgb(255, 71, 72, 75); // light
            btn_alerts.BackColor = Color.FromArgb(255, 71, 72, 75);

            pnl_yellow.Height = btn_search_f.Height;
            pnl_yellow.Top = btn_search_f.Top;
            
        }

        // ////////// reschedule
        private void button3_Click_1(object sender, EventArgs e)
        {
            pnl_resch_data.Controls.Clear();

            pnl_search_f.Visible = false;
            pnl_search_air.Visible = false;
            pnl_resch.Visible = true;
            richTextBox1.Hide();

            btn_search_air.BackColor = Color.FromArgb(255, 71, 72, 75);
            btn_search_f.BackColor = Color.FromArgb(255, 71, 72, 75);
            btn_resch.BackColor = Color.FromArgb(255, 41, 44, 55);
            btn_alerts.BackColor = Color.FromArgb(255, 71, 72, 75);

            pnl_yellow.Height = btn_resch.Height;
            pnl_yellow.Top = btn_resch.Top;
            pnl_search_id.Hide();

            con.Open();
            cmd = new SqlCommand("exec reschedule '" + id +"'", con);

            Rd = cmd.ExecuteReader();

            int i = 0; //Label lbl0;

            while (Rd.Read())
            {

                Panel pnl = new Panel();
                pnl.Size = new Size(1100, 35);
                pnl.Location = new Point(0, i * 30);

                txtbox = new TextBox();
                txtbox.Location = new Point(10, 0);
                txtbox.Size = new Size(95, 25);
                txtbox.Text = Rd["flight_id"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(130, 0);
                txtbox.Size = new Size(120, 25);
                txtbox.Text = Rd["destination"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(280, 0);
                txtbox.Size = new Size(120, 25);
                txtbox.Text = Rd["date"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(480, 0);
                txtbox.Size = new Size(90, 25);
                txtbox.Text = Rd["duration"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(624, 0);
                txtbox.Size = new Size(135, 25);
                txtbox.Text = Rd["max_passenger"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                txtbox = new TextBox();
                txtbox.Location = new Point(800, 0);
                txtbox.Size = new Size(130, 25);
                txtbox.Text = Rd["airline"].ToString();
                txtbox.ReadOnly = true;
                pnl.Controls.Add(txtbox);

                Button btn = new Button();
                btn.Size = new Size(105, 22);
                btn.Location = new Point(960, 0);
                btn.Text = "reserve";
                btn.Name = Rd["flight_id"].ToString();

                btn.Click += delegate (object sender0, EventArgs e0)
                {
                    btnclick(sender, e, btn.Name);
                };


                pnl.Controls.Add(btn);

                pnl_resch_data.Controls.Add(pnl);

                i++;
            }
            if (i == 0)
            {
                MessageBox.Show(" there is no available flights to reschedule");
            }

            Rd.Close();
            con.Close();


        }

        private void panelSF_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            btn_all_f_data.BackColor = Color.FromArgb(255, 41, 44, 55);

            btn_f_search_num.BackColor = Color.FromArgb(255, 71, 72, 75);
            btn_f_search_dest.BackColor = Color.FromArgb(255, 71, 72, 75);

            pnl_search_dest.Visible = false;
            pnl_search_id.Visible = false;

            get_all_f_data();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btn_f_search_dest.BackColor = Color.FromArgb(255, 41, 44, 55);

            btn_f_search_num.BackColor = Color.FromArgb(255, 71, 72, 75);
            btn_all_f_data.BackColor = Color.FromArgb(255, 71, 72, 75);

            pnl_search_dest.Visible = true;
            pnl_search_id.Visible = false;

        }

        private void searchbyname_Click(object sender, EventArgs e)
        {
            btn_f_search_num.BackColor = Color.FromArgb(255, 41, 44, 55);
            btn_f_search_dest.BackColor = Color.FromArgb(255, 71, 72, 75);
            btn_all_f_data.BackColor = Color.FromArgb(255, 71, 72, 75);
            pnl_search_id.Visible = true;
            pnl_search_dest.Visible = false;

        }



        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click_2(object sender, EventArgs e)
        {
            con.Open();
            if (txt_f_search_dest.Text == "")
                MessageBox.Show("Please Enter Flight Distanation ");
            else
            {
                pnl_f_data.Controls.Clear();
                cmd = new SqlCommand(" select * from  search_f_byD('" + txt_f_search_dest.Text + "')", con);
                Rd = cmd.ExecuteReader();

                int i = 0;
                while (Rd.Read())
                {

                    Panel pnl = new Panel();
                    pnl.Size = new Size(1100, 35);
                    pnl.Location = new Point(0, i * 30);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(10, 0);
                    txtbox.Size = new Size(95, 25);
                    txtbox.Text = Rd["flight_id"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(130, 0);
                    txtbox.Size = new Size(120, 25);
                    txtbox.Text = Rd["destination"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(280, 0);
                    txtbox.Size = new Size(120, 25);
                    txtbox.Text = Rd["date"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(480, 0);
                    txtbox.Size = new Size(90, 25);
                    txtbox.Text = Rd["duration"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(624, 0);
                    txtbox.Size = new Size(135, 25);
                    txtbox.Text = Rd["max_passenger"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(800, 0);
                    txtbox.Size = new Size(130, 25);
                    txtbox.Text = Rd["airline"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    Button btn = new Button();
                    btn.Size = new Size(105, 22);
                    btn.Location = new Point(960, 0);
                    btn.Text = "reserve";
                    btn.Name = Rd["flight_id"].ToString();

                    btn.Click += delegate (object sender1, EventArgs e1)
                    {
                        btnclick(sender, e, btn.Name);
                    };


                    pnl.Controls.Add(btn);

                    pnl_f_data.Controls.Add(pnl);

                    i++;
                }
            }
            Rd.Close();
            con.Close();

        }

        private void btn_search_id_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txt_f_search_id.Text == "")
                MessageBox.Show("Please Enter Flight ID  ");
            else
            {
                pnl_f_data.Controls.Clear();
                cmd = new SqlCommand(" select * from  search_f('" + Convert.ToInt32(txt_f_search_id.Text) + "')", con);
                Rd = cmd.ExecuteReader();

                int i = 0;
                while (Rd.Read())
                {

                    Panel pnl = new Panel();
                    pnl.Size = new Size(1100, 35);
                    pnl.Location = new Point(0, i * 30);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(10, 0);
                    txtbox.Size = new Size(95, 25);
                    txtbox.Text = Rd["flight_id"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(130, 0);
                    txtbox.Size = new Size(120, 25);
                    txtbox.Text = Rd["destination"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(280, 0);
                    txtbox.Size = new Size(120, 25);
                    txtbox.Text = Rd["date"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(480, 0);
                    txtbox.Size = new Size(90, 25);
                    txtbox.Text = Rd["duration"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(624, 0);
                    txtbox.Size = new Size(135, 25);
                    txtbox.Text = Rd["max_passenger"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    txtbox = new TextBox();
                    txtbox.Location = new Point(800, 0);
                    txtbox.Size = new Size(130, 25);
                    txtbox.Text = Rd["airline"].ToString();
                    txtbox.ReadOnly = true;
                    pnl.Controls.Add(txtbox);

                    Button btn = new Button();
                    btn.Size = new Size(105, 22);
                    btn.Location = new Point(960, 0);
                    btn.Text = "reserve";
                    btn.Name = Rd["flight_id"].ToString();

                    btn.Click += delegate (object sender1, EventArgs e1)
                    {
                        btnclick(sender, e, btn.Name);
                    };


                    pnl.Controls.Add(btn);

                    pnl_f_data.Controls.Add(pnl);

                    i++;
                }
            }
            Rd.Close();
            con.Close();
        }

        private void txt_f_search_id_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_f_search_id.Text, "[^0-9]"))
            {
                MessageBox.Show("please enter only numbers.");
                txt_f_search_id.Text = txt_f_search_id.Text.Remove(txt_f_search_id.Text.Length - 1);
            }
        }

        private void btn_a_search_Click(object sender, EventArgs e)
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
                        txtbox.Location = new Point(5, 0);
                        txtbox.Size = new Size(92, 25);
                        txtbox.Text = Rd["airline_id"].ToString();
                        txtbox.ReadOnly = true;
                        pnl.Controls.Add(txtbox);

                        txtbox = new TextBox();
                        txtbox.Location = new Point(150, 0);
                        txtbox.Size = new Size(120, 25);
                        txtbox.Text = Rd["name"].ToString();
                        txtbox.ReadOnly = true;
                        pnl.Controls.Add(txtbox);

                        txtbox = new TextBox();
                        txtbox.Location = new Point(280, 0);
                        txtbox.Size = new Size(120, 25);
                        txtbox.Text = Rd["services"].ToString();
                        txtbox.ReadOnly = true;
                        pnl.Controls.Add(txtbox);

                        txtbox = new TextBox();
                        txtbox.Location = new Point(470, 0);
                        txtbox.Size = new Size(90, 25);
                        txtbox.Text = Rd["routes"].ToString();
                        txtbox.ReadOnly = true;
                        pnl.Controls.Add(txtbox);

                        txtbox = new TextBox();
                        txtbox.Location = new Point(625, 0);
                        txtbox.Size = new Size(135, 25);
                        txtbox.Text = Rd["rate"].ToString();
                        txtbox.ReadOnly = true;
                        pnl.Controls.Add(txtbox);

                        txtbox = new TextBox();
                        txtbox.Location = new Point(790, 0);
                        txtbox.Size = new Size(130, 25);
                        txtbox.Text = Rd["num_of_planes"].ToString();
                        txtbox.ReadOnly = true;
                        pnl.Controls.Add(txtbox);

                        txtbox = new TextBox();
                        txtbox.Size = new Size(105, 22);
                        txtbox.Location = new Point(965, 0);
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

        private void btn_a_all_data_Click(object sender, EventArgs e)
        {
            btn_all_f_data.BackColor = Color.FromArgb(255, 41, 44, 55);
            btn_a_search.BackColor = Color.FromArgb(255, 71, 72, 75);
            
            txt_a_search.Hide();
            btn_a_search_name.Hide();

            get_all_air_data();
            btn_a_search_name.Hide();
            txt_a_search.Hide();
        }

        private void btn_a_search_Click_1(object sender, EventArgs e)
        {
            btn_a_search.BackColor = Color.FromArgb(255, 41, 44, 55);
            btn_a_all_data.BackColor = Color.FromArgb(255, 71, 72, 75);
            txt_a_search.Show();
            btn_a_search_name.Show();
        }

        private void btn_alerts_Click(object sender, EventArgs e)
        {
            pnl_resch.Hide();
            pnl_search_f.Hide();
            pnl_search_air.Hide();
            richTextBox1.Show();

            btn_alerts.BackColor = Color.FromArgb(255, 41, 44, 55);
            btn_resch.BackColor = Color.FromArgb(255, 71, 72, 75);
            btn_search_air.BackColor = Color.FromArgb(255, 71, 72, 75);
            btn_search_f.BackColor = Color.FromArgb(255, 71, 72, 75);

            pnl_yellow.Height = btn_alerts.Height;
            pnl_yellow.Top = btn_alerts.Top;

            con.Open();
            cmd = new SqlCommand("select alert from passenger where passenger_id ='" + id + "'", con);
            Rd = cmd.ExecuteReader();
            while (Rd.Read())
            {
                richTextBox1.Text = Rd["alert"].ToString().Trim();
            }
            Rd.Close();
            con.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication2.p_login b = new WindowsFormsApplication2.p_login();
            b.Show();
            this.Hide();
        }
    }
}
