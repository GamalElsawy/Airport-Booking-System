namespace WindowsFormsApplication2
{
    partial class start
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
            this.btn_login_p = new System.Windows.Forms.Button();
            this.btn_login_emp = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_login_p
            // 
            this.btn_login_p.BackColor = System.Drawing.Color.Transparent;
            this.btn_login_p.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login_p.FlatAppearance.BorderSize = 2;
            this.btn_login_p.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_login_p.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_login_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_p.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(142)))), ((int)(((byte)(194)))));
            this.btn_login_p.Location = new System.Drawing.Point(129, 286);
            this.btn_login_p.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login_p.Name = "btn_login_p";
            this.btn_login_p.Size = new System.Drawing.Size(288, 60);
            this.btn_login_p.TabIndex = 31;
            this.btn_login_p.Text = "Passenger";
            this.btn_login_p.UseVisualStyleBackColor = false;
            this.btn_login_p.Click += new System.EventHandler(this.btn_login_p_Click);
            // 
            // btn_login_emp
            // 
            this.btn_login_emp.BackColor = System.Drawing.Color.Transparent;
            this.btn_login_emp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login_emp.FlatAppearance.BorderSize = 2;
            this.btn_login_emp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_login_emp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_login_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_emp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(142)))), ((int)(((byte)(194)))));
            this.btn_login_emp.Location = new System.Drawing.Point(475, 286);
            this.btn_login_emp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login_emp.Name = "btn_login_emp";
            this.btn_login_emp.Size = new System.Drawing.Size(288, 60);
            this.btn_login_emp.TabIndex = 32;
            this.btn_login_emp.Text = "Admin";
            this.btn_login_emp.UseVisualStyleBackColor = false;
            this.btn_login_emp.Click += new System.EventHandler(this.btn_login_emp_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.exit1;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(1275, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 40);
            this.btn_exit.TabIndex = 37;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.AirportShowherodesktopeventsspotlightjpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1315, 691);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login_emp);
            this.Controls.Add(this.btn_login_p);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_login_p;
        private System.Windows.Forms.Button btn_login_emp;
        private System.Windows.Forms.Button btn_exit;
    }
}