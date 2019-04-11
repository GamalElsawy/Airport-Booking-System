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
    public partial class edit_flight2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KE32AB6\\MYSQL1;Initial Catalog=airport;Integrated Security=True");
        public static SqlCommand cmd;
        public static SqlDataReader Rd;
        public static int id;
        public static string air_id;

        public edit_flight2(int id1)
        {
            id = id1;
            InitializeComponent();

            dateTimePicker1.MinDate = DateTime.Now;

            dateTimePicker2.MinDate = DateTime.Now;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void edit_flight2_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_id_delete.Text == "")
            {
                MessageBox.Show("please enter an id");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("select * from flight where flight_id ='" + Convert.ToInt32(txt_id_delete.Text) + "'", con);
                Rd = cmd.ExecuteReader();
                bool find = false;
                while (Rd.Read())
                {
                    find = true;

                }
                Rd.Close();
                if (!find)
                {
                    MessageBox.Show("that flight id doesn`t exist");
                }
                else if (find)
                {
                    cmd = new SqlCommand("exec delete_f '" + Convert.ToInt32(txt_id_delete.Text) + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("done");
                }
                con.Close();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_air_edit.Text == "" || txt_dest_edit.Text == "" || txt_duration_edit.Text == "" ||
                txt_id_edit.Text == "" || txt_num_of_p_edit.Text == "")
            {
                MessageBox.Show("please enter full details");
            }
            else
            {
                
                con.Open();
                cmd = new SqlCommand("select airline_id from airline where name = '" + txt_air_edit.Text + "'", con);
                Rd = cmd.ExecuteReader();
                while (Rd.Read())
                {
                    air_id = Rd["airline_id"].ToString();
                }
                Rd.Close();
                con.Close();
                con.Open();
                cmd = new SqlCommand("exec update_f '" + Convert.ToDateTime(dateTimePicker1.Value) +
                    "' , '" + txt_dest_edit.Text.Trim() + "','" + Int32.Parse(txt_duration_edit.Text.Trim()) +
                    "','" + txt_air_edit.Text.Trim() + "','" + Convert.ToInt32(txt_num_of_p_edit.Text.Trim()) +
                    "','" + 0 + "','" + Int32.Parse(air_id.Trim()) + "', '" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Done");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_air_add.Text == "" || txt_dest_add.Text == "" ||
                txt_duration_add.Text == "" || txt_num_of_p_add.Text == "")
            {
                MessageBox.Show("please enter full details");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("select airline_id from airline where name = '" + txt_air_add.Text + "'", con);
                Rd = cmd.ExecuteReader();
                while (Rd.Read())
                {
                    air_id = Rd["airline_id"].ToString().Trim();
                }
                Rd.Close();
                con.Close();
                con.Open();
                cmd = new SqlCommand("exec insert_f '" + dateTimePicker1.Value +
                    "' , '" + txt_dest_add.Text + "','" + Convert.ToInt32(txt_duration_add.Text) +
                    "','" + txt_air_add.Text + "','" + Convert.ToInt32(txt_num_of_p_add.Text) +
                    "','" + 0 + "','" + Convert.ToInt32(air_id) + "', '" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Done");
            }
        }

        private void txt_id_delete_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_id_delete.Text, "[^0-9]"))
            {
                MessageBox.Show("please enter only numbers.");
                txt_id_delete.Text = txt_id_delete.Text.Remove(txt_id_delete.Text.Length - 1);
            }
        }

        private void txt_id_edit_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_id_edit.Text, "[^0-9]"))
            {
                MessageBox.Show("please enter only numbers.");
                txt_id_edit.Text = txt_id_edit.Text.Remove(txt_id_edit.Text.Length - 1);
            }
        }

        private void editflight_Click(object sender, EventArgs e)
        {
            Admin_Page.Form4 g = new Admin_Page.Form4(id);
            g.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication2.EditAirline f = new WindowsFormsApplication2.EditAirline(id);
            f.Show();
            this.Hide();
        }

        private void btn_send_alert_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication2.sent_alert f2 = new WindowsFormsApplication2.sent_alert(id);
            this.Hide();
            f2.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            start n = new start();
            n.Show();
            this.Hide();
        }
    }
}
