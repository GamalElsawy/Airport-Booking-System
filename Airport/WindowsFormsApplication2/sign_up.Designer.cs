namespace WindowsFormsApplication2
{
    partial class sign_up
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_up));
            this.button3 = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.txt_name = new ZBobb.AlphaBlendTextBox();
            this.txt_pass = new ZBobb.AlphaBlendTextBox();
            this.txt_con_pass = new ZBobb.AlphaBlendTextBox();
            this.txt_username = new ZBobb.AlphaBlendTextBox();
            this.txt_passport_num = new ZBobb.AlphaBlendTextBox();
            this.txt_gmail = new ZBobb.AlphaBlendTextBox();
            this.txt_gmail_pass = new ZBobb.AlphaBlendTextBox();
            this.txt_code = new ZBobb.AlphaBlendTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.exit1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(936, -3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 38;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.White;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_signup.Location = new System.Drawing.Point(448, 500);
            this.btn_signup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(134, 41);
            this.btn_signup.TabIndex = 23;
            this.btn_signup.Text = "Sign up";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_name
            // 
            this.txt_name.BackAlpha = 50;
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_name.Location = new System.Drawing.Point(235, 138);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.MaxLength = 30;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(251, 32);
            this.txt_name.TabIndex = 24;
            this.txt_name.Text = "Name";
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_name.Enter += new System.EventHandler(this.textboxname_Enter);
            this.txt_name.Leave += new System.EventHandler(this.textboxname_Leave);
            // 
            // txt_pass
            // 
            this.txt_pass.BackAlpha = 50;
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_pass.Location = new System.Drawing.Point(235, 237);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pass.MaxLength = 30;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(251, 32);
            this.txt_pass.TabIndex = 25;
            this.txt_pass.Text = "Password";
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pass.Enter += new System.EventHandler(this.textboxpassword1_Enter);
            this.txt_pass.Leave += new System.EventHandler(this.textboxpassword1_Leave);
            // 
            // txt_con_pass
            // 
            this.txt_con_pass.BackAlpha = 50;
            this.txt_con_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_con_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_con_pass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_con_pass.Location = new System.Drawing.Point(235, 286);
            this.txt_con_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_con_pass.MaxLength = 30;
            this.txt_con_pass.Name = "txt_con_pass";
            this.txt_con_pass.Size = new System.Drawing.Size(251, 32);
            this.txt_con_pass.TabIndex = 26;
            this.txt_con_pass.Text = "Confirm Password";
            this.txt_con_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_con_pass.Enter += new System.EventHandler(this.textboxconfirmpassword_Enter);
            this.txt_con_pass.Leave += new System.EventHandler(this.textboxconfirmpassword_Leave);
            // 
            // txt_username
            // 
            this.txt_username.BackAlpha = 50;
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_username.Location = new System.Drawing.Point(235, 184);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_username.MaxLength = 30;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(251, 32);
            this.txt_username.TabIndex = 27;
            this.txt_username.Text = "UserName";
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_username.Enter += new System.EventHandler(this.textboxusername1_Enter);
            this.txt_username.Leave += new System.EventHandler(this.textboxusername1_Leave);
            // 
            // txt_passport_num
            // 
            this.txt_passport_num.BackAlpha = 50;
            this.txt_passport_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_passport_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passport_num.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_passport_num.Location = new System.Drawing.Point(525, 138);
            this.txt_passport_num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_passport_num.MaxLength = 30;
            this.txt_passport_num.Name = "txt_passport_num";
            this.txt_passport_num.Size = new System.Drawing.Size(251, 32);
            this.txt_passport_num.TabIndex = 39;
            this.txt_passport_num.Text = "Passport number";
            this.txt_passport_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_passport_num.TextChanged += new System.EventHandler(this.txt_passport_num_TextChanged);
            this.txt_passport_num.Enter += new System.EventHandler(this.txt_passport_num_Enter);
            this.txt_passport_num.Leave += new System.EventHandler(this.txt_passport_num_Leave);
            // 
            // txt_gmail
            // 
            this.txt_gmail.BackAlpha = 50;
            this.txt_gmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_gmail.Location = new System.Drawing.Point(525, 184);
            this.txt_gmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gmail.MaxLength = 30;
            this.txt_gmail.Name = "txt_gmail";
            this.txt_gmail.Size = new System.Drawing.Size(251, 32);
            this.txt_gmail.TabIndex = 40;
            this.txt_gmail.Text = "gmail";
            this.txt_gmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_gmail.Enter += new System.EventHandler(this.txt_gmail_Enter);
            this.txt_gmail.Leave += new System.EventHandler(this.txt_gmail_Leave);
            // 
            // txt_gmail_pass
            // 
            this.txt_gmail_pass.BackAlpha = 50;
            this.txt_gmail_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_gmail_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gmail_pass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_gmail_pass.Location = new System.Drawing.Point(525, 237);
            this.txt_gmail_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gmail_pass.MaxLength = 30;
            this.txt_gmail_pass.Name = "txt_gmail_pass";
            this.txt_gmail_pass.Size = new System.Drawing.Size(251, 32);
            this.txt_gmail_pass.TabIndex = 41;
            this.txt_gmail_pass.Text = "gmail password";
            this.txt_gmail_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_gmail_pass.Enter += new System.EventHandler(this.txt_gmail_pass_Enter);
            this.txt_gmail_pass.Leave += new System.EventHandler(this.txt_gmail_pass_Leave);
            // 
            // txt_code
            // 
            this.txt_code.BackAlpha = 50;
            this.txt_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_code.Location = new System.Drawing.Point(379, 449);
            this.txt_code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_code.MaxLength = 30;
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(251, 32);
            this.txt_code.TabIndex = 47;
            this.txt_code.Text = "Enter Code";
            this.txt_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_code.Visible = false;
            this.txt_code.TextChanged += new System.EventHandler(this.txt_code_TextChanged);
            this.txt_code.Enter += new System.EventHandler(this.txt_code_Enter);
            this.txt_code.Leave += new System.EventHandler(this.txt_code_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(377, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 92);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(537, 290);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 28);
            this.checkBox1.TabIndex = 45;
            this.checkBox1.Text = "Not Robot";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "screen-shot-2013-10-28-at-10-39-13-am.png");
            this.imageList1.Images.SetKeyName(1, "screen-shot-2013-10-28-at-10-39-13-am1.png");
            this.imageList1.Images.SetKeyName(2, "screen-shot-2013-10-28-at-10-39-13-am2.png");
            this.imageList1.Images.SetKeyName(3, "screen-shot-2013-10-28-at-10-39-13-am3.png");
            this.imageList1.Images.SetKeyName(4, "screen-shot-2013-10-28-at-10-39-13-am5.png");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(618, 523);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(130, 18);
            this.linkLabel1.TabIndex = 48;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Have An Acoount?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.background21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 661);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txt_gmail_pass);
            this.Controls.Add(this.txt_gmail);
            this.Controls.Add(this.txt_passport_num);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_con_pass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_signup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "sign_up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.sign_up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_signup;
        private ZBobb.AlphaBlendTextBox txt_name;
        private ZBobb.AlphaBlendTextBox txt_pass;
        private ZBobb.AlphaBlendTextBox txt_con_pass;
        private ZBobb.AlphaBlendTextBox txt_username;
        private ZBobb.AlphaBlendTextBox txt_passport_num;
        private ZBobb.AlphaBlendTextBox txt_gmail;
        private ZBobb.AlphaBlendTextBox txt_gmail_pass;
        private ZBobb.AlphaBlendTextBox txt_code;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}