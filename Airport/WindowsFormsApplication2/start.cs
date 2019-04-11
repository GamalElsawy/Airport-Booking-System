using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void btn_login_p_Click(object sender, EventArgs e)
        {
            this.Hide();
            p_login f = new p_login();
            f.Show();
        }

        private void btn_login_emp_Click(object sender, EventArgs e)
        {
            this.Hide();
            emp_login f2 = new emp_login();
            f2.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
