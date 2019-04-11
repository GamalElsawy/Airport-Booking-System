namespace WindowsFormsApplication2
{
    partial class sent_alert
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.rtxt_message = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelleft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_send_alert = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.editflight = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "To";
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(336, 131);
            this.txt_to.MaxLength = 30;
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(251, 22);
            this.txt_to.TabIndex = 41;
            this.txt_to.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rtxt_message
            // 
            this.rtxt_message.Location = new System.Drawing.Point(258, 214);
            this.rtxt_message.Name = "rtxt_message";
            this.rtxt_message.Size = new System.Drawing.Size(979, 259);
            this.rtxt_message.TabIndex = 40;
            this.rtxt_message.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1023, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 57);
            this.button1.TabIndex = 43;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.Yellow;
            this.panelleft.Location = new System.Drawing.Point(200, 355);
            this.panelleft.Margin = new System.Windows.Forms.Padding(4);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(4, 90);
            this.panelleft.TabIndex = 45;
            this.panelleft.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_send_alert);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.editflight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 644);
            this.panel1.TabIndex = 44;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
            this.btn_logout.Location = new System.Drawing.Point(0, 589);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(200, 55);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_send_alert
            // 
            this.btn_send_alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btn_send_alert.FlatAppearance.BorderSize = 0;
            this.btn_send_alert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send_alert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
            this.btn_send_alert.Location = new System.Drawing.Point(0, 355);
            this.btn_send_alert.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send_alert.Name = "btn_send_alert";
            this.btn_send_alert.Size = new System.Drawing.Size(198, 90);
            this.btn_send_alert.TabIndex = 6;
            this.btn_send_alert.Text = "Send Alert";
            this.btn_send_alert.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
            this.button3.Location = new System.Drawing.Point(0, 265);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 90);
            this.button3.TabIndex = 5;
            this.button3.Text = "Edit Airline";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // editflight
            // 
            this.editflight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.editflight.FlatAppearance.BorderSize = 0;
            this.editflight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editflight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editflight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
            this.editflight.Location = new System.Drawing.Point(0, 175);
            this.editflight.Margin = new System.Windows.Forms.Padding(4);
            this.editflight.Name = "editflight";
            this.editflight.Size = new System.Drawing.Size(198, 90);
            this.editflight.TabIndex = 4;
            this.editflight.Text = "Edit Flight";
            this.editflight.UseVisualStyleBackColor = false;
            this.editflight.Click += new System.EventHandler(this.editflight_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.images__1_4;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 176);
            this.panel2.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.exit1;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(1258, -2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 40);
            this.btn_exit.TabIndex = 39;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // sent_alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1297, 644);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.rtxt_message);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sent_alert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sent_alert";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.RichTextBox rtxt_message;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_send_alert;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button editflight;
        private System.Windows.Forms.Button btn_logout;
    }
}