namespace Admin_Page
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_send_alert = new System.Windows.Forms.Button();
            this.editairline = new System.Windows.Forms.Button();
            this.editflight = new System.Windows.Forms.Button();
            this.panelleft = new System.Windows.Forms.Panel();
            this.pnl_search_f = new System.Windows.Forms.Panel();
            this.btn_search_id = new System.Windows.Forms.Button();
            this.txt_f_search_id = new System.Windows.Forms.TextBox();
            this.lbl_airline = new System.Windows.Forms.Label();
            this.lbl_num_of_p = new System.Windows.Forms.Label();
            this.pnl_menu_btns = new System.Windows.Forms.Panel();
            this.btn_f_edit = new System.Windows.Forms.Button();
            this.btn_f_search_num = new System.Windows.Forms.Button();
            this.btn_all_f_data = new System.Windows.Forms.Button();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.pnl_f_data = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_dest = new System.Windows.Forms.Label();
            this.lbl_flight_num = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnl_search_f.SuspendLayout();
            this.pnl_menu_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_send_alert);
            this.panel1.Controls.Add(this.editairline);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.editflight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 738);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(0, 687);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(200, 48);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_send_alert
            // 
            this.btn_send_alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.btn_send_alert.FlatAppearance.BorderSize = 0;
            this.btn_send_alert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send_alert.Location = new System.Drawing.Point(0, 357);
            this.btn_send_alert.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send_alert.Name = "btn_send_alert";
            this.btn_send_alert.Size = new System.Drawing.Size(198, 90);
            this.btn_send_alert.TabIndex = 3;
            this.btn_send_alert.Text = "Send Alert";
            this.btn_send_alert.UseVisualStyleBackColor = false;
            this.btn_send_alert.Click += new System.EventHandler(this.button2_Click);
            // 
            // editairline
            // 
            this.editairline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.editairline.FlatAppearance.BorderSize = 0;
            this.editairline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editairline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editairline.Location = new System.Drawing.Point(0, 267);
            this.editairline.Margin = new System.Windows.Forms.Padding(4);
            this.editairline.Name = "editairline";
            this.editairline.Size = new System.Drawing.Size(198, 90);
            this.editairline.TabIndex = 2;
            this.editairline.Text = "Edit Airline";
            this.editairline.UseVisualStyleBackColor = false;
            this.editairline.Click += new System.EventHandler(this.editairline_Click);
            // 
            // editflight
            // 
            this.editflight.FlatAppearance.BorderSize = 0;
            this.editflight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editflight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editflight.Location = new System.Drawing.Point(0, 177);
            this.editflight.Margin = new System.Windows.Forms.Padding(4);
            this.editflight.Name = "editflight";
            this.editflight.Size = new System.Drawing.Size(198, 90);
            this.editflight.TabIndex = 0;
            this.editflight.Text = "Edit Flight";
            this.editflight.UseVisualStyleBackColor = true;
            this.editflight.Click += new System.EventHandler(this.editflight_Click);
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.Yellow;
            this.panelleft.Location = new System.Drawing.Point(200, 181);
            this.panelleft.Margin = new System.Windows.Forms.Padding(4);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(4, 90);
            this.panelleft.TabIndex = 1;
            this.panelleft.Visible = false;
            // 
            // pnl_search_f
            // 
            this.pnl_search_f.Controls.Add(this.btn_search_id);
            this.pnl_search_f.Controls.Add(this.txt_f_search_id);
            this.pnl_search_f.Controls.Add(this.lbl_airline);
            this.pnl_search_f.Controls.Add(this.lbl_num_of_p);
            this.pnl_search_f.Controls.Add(this.pnl_menu_btns);
            this.pnl_search_f.Controls.Add(this.lbl_duration);
            this.pnl_search_f.Controls.Add(this.pnl_f_data);
            this.pnl_search_f.Controls.Add(this.lbl_date);
            this.pnl_search_f.Controls.Add(this.lbl_dest);
            this.pnl_search_f.Controls.Add(this.lbl_flight_num);
            this.pnl_search_f.Location = new System.Drawing.Point(207, 87);
            this.pnl_search_f.Name = "pnl_search_f";
            this.pnl_search_f.Size = new System.Drawing.Size(1124, 651);
            this.pnl_search_f.TabIndex = 38;
            // 
            // btn_search_id
            // 
            this.btn_search_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_id.Location = new System.Drawing.Point(811, 119);
            this.btn_search_id.Name = "btn_search_id";
            this.btn_search_id.Size = new System.Drawing.Size(132, 34);
            this.btn_search_id.TabIndex = 7;
            this.btn_search_id.Text = "Search";
            this.btn_search_id.UseVisualStyleBackColor = true;
            this.btn_search_id.Visible = false;
            this.btn_search_id.Click += new System.EventHandler(this.btn_search_id_Click);
            // 
            // txt_f_search_id
            // 
            this.txt_f_search_id.Location = new System.Drawing.Point(590, 129);
            this.txt_f_search_id.MaxLength = 30;
            this.txt_f_search_id.Name = "txt_f_search_id";
            this.txt_f_search_id.Size = new System.Drawing.Size(184, 22);
            this.txt_f_search_id.TabIndex = 6;
            this.txt_f_search_id.Visible = false;
            this.txt_f_search_id.TextChanged += new System.EventHandler(this.txt_f_search_id_TextChanged);
            // 
            // lbl_airline
            // 
            this.lbl_airline.AutoSize = true;
            this.lbl_airline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_airline.Location = new System.Drawing.Point(1011, 199);
            this.lbl_airline.Name = "lbl_airline";
            this.lbl_airline.Size = new System.Drawing.Size(66, 25);
            this.lbl_airline.TabIndex = 5;
            this.lbl_airline.Text = "Airline";
            // 
            // lbl_num_of_p
            // 
            this.lbl_num_of_p.AutoSize = true;
            this.lbl_num_of_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_of_p.Location = new System.Drawing.Point(742, 199);
            this.lbl_num_of_p.Name = "lbl_num_of_p";
            this.lbl_num_of_p.Size = new System.Drawing.Size(201, 25);
            this.lbl_num_of_p.TabIndex = 4;
            this.lbl_num_of_p.Text = "Number of Passenger";
            // 
            // pnl_menu_btns
            // 
            this.pnl_menu_btns.Controls.Add(this.btn_f_edit);
            this.pnl_menu_btns.Controls.Add(this.btn_f_search_num);
            this.pnl_menu_btns.Controls.Add(this.btn_all_f_data);
            this.pnl_menu_btns.Location = new System.Drawing.Point(7, 7);
            this.pnl_menu_btns.Name = "pnl_menu_btns";
            this.pnl_menu_btns.Size = new System.Drawing.Size(1114, 84);
            this.pnl_menu_btns.TabIndex = 1;
            // 
            // btn_f_edit
            // 
            this.btn_f_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.btn_f_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_f_edit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_f_edit.Location = new System.Drawing.Point(740, 23);
            this.btn_f_edit.Name = "btn_f_edit";
            this.btn_f_edit.Size = new System.Drawing.Size(370, 60);
            this.btn_f_edit.TabIndex = 2;
            this.btn_f_edit.Text = "Edit Flight";
            this.btn_f_edit.UseVisualStyleBackColor = false;
            this.btn_f_edit.Click += new System.EventHandler(this.btn_f_edit_Click);
            // 
            // btn_f_search_num
            // 
            this.btn_f_search_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.btn_f_search_num.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_f_search_num.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_f_search_num.Location = new System.Drawing.Point(370, 23);
            this.btn_f_search_num.Name = "btn_f_search_num";
            this.btn_f_search_num.Size = new System.Drawing.Size(370, 60);
            this.btn_f_search_num.TabIndex = 1;
            this.btn_f_search_num.Text = "Search By Number";
            this.btn_f_search_num.UseVisualStyleBackColor = false;
            this.btn_f_search_num.Click += new System.EventHandler(this.btn_f_search_num_Click);
            // 
            // btn_all_f_data
            // 
            this.btn_all_f_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btn_all_f_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_all_f_data.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_all_f_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
            this.btn_all_f_data.Location = new System.Drawing.Point(0, 23);
            this.btn_all_f_data.Name = "btn_all_f_data";
            this.btn_all_f_data.Size = new System.Drawing.Size(370, 60);
            this.btn_all_f_data.TabIndex = 0;
            this.btn_all_f_data.Text = "All flight data";
            this.btn_all_f_data.UseVisualStyleBackColor = false;
            this.btn_all_f_data.Click += new System.EventHandler(this.btn_all_f_data_Click);
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration.Location = new System.Drawing.Point(549, 199);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(85, 25);
            this.lbl_duration.TabIndex = 3;
            this.lbl_duration.Text = "Duration";
            // 
            // pnl_f_data
            // 
            this.pnl_f_data.AutoScroll = true;
            this.pnl_f_data.Location = new System.Drawing.Point(7, 231);
            this.pnl_f_data.Name = "pnl_f_data";
            this.pnl_f_data.Size = new System.Drawing.Size(1110, 408);
            this.pnl_f_data.TabIndex = 4;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(372, 196);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(63, 29);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "Date";
            // 
            // lbl_dest
            // 
            this.lbl_dest.AutoSize = true;
            this.lbl_dest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dest.Location = new System.Drawing.Point(176, 199);
            this.lbl_dest.Name = "lbl_dest";
            this.lbl_dest.Size = new System.Drawing.Size(109, 25);
            this.lbl_dest.TabIndex = 1;
            this.lbl_dest.Text = "Destination";
            // 
            // lbl_flight_num
            // 
            this.lbl_flight_num.AutoSize = true;
            this.lbl_flight_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_flight_num.Location = new System.Drawing.Point(14, 199);
            this.lbl_flight_num.Name = "lbl_flight_num";
            this.lbl_flight_num.Size = new System.Drawing.Size(89, 25);
            this.lbl_flight_num.TabIndex = 0;
            this.lbl_flight_num.Text = "Flight No";
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.exit1;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(1293, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 40);
            this.btn_exit.TabIndex = 37;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.images__1_1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 176);
            this.panel2.TabIndex = 1;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1333, 738);
            this.Controls.Add(this.pnl_search_f);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_search_f.ResumeLayout(false);
            this.pnl_search_f.PerformLayout();
            this.pnl_menu_btns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_send_alert;
        private System.Windows.Forms.Button editairline;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button editflight;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel pnl_search_f;
        private System.Windows.Forms.Label lbl_airline;
        private System.Windows.Forms.Label lbl_num_of_p;
        private System.Windows.Forms.Panel pnl_menu_btns;
        private System.Windows.Forms.Button btn_f_search_num;
        private System.Windows.Forms.Button btn_all_f_data;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Panel pnl_f_data;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_dest;
        private System.Windows.Forms.Label lbl_flight_num;
        private System.Windows.Forms.Button btn_search_id;
        private System.Windows.Forms.TextBox txt_f_search_id;
        private System.Windows.Forms.Button btn_f_edit;
        private System.Windows.Forms.Button btn_logout;
    }
}

