namespace AuthForm
{
    partial class FormWindowRegistration
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
            this.registrationButton = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailField = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.Enabled = false;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registrationButton.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.ForeColor = System.Drawing.Color.Transparent;
            this.registrationButton.Location = new System.Drawing.Point(100, 362);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(203, 54);
            this.registrationButton.TabIndex = 10;
            this.registrationButton.Text = "Registration";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.UserRegistrationbButton_Click);
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.passwordField.Location = new System.Drawing.Point(100, 177);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(258, 38);
            this.passwordField.TabIndex = 9;
            this.passwordField.UseSystemPasswordChar = true;
            this.passwordField.TextChanged += new System.EventHandler(this.RegistrationButton_TextChanged);
            this.passwordField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordFieldFormatting_KeyPress);
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.loginField.Location = new System.Drawing.Point(100, 94);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(276, 48);
            this.loginField.TabIndex = 8;
            this.loginField.TextChanged += new System.EventHandler(this.RegistrationButton_TextChanged);
            this.loginField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginFieldFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 63);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration 0.1v";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(137, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Авторизация";
            this.label2.Click += new System.EventHandler(this.AuthorizationButton_Click);
            // 
            // emailField
            // 
            this.emailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.emailField.Location = new System.Drawing.Point(100, 272);
            this.emailField.Multiline = true;
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(276, 72);
            this.emailField.TabIndex = 14;
            this.emailField.TextChanged += new System.EventHandler(this.RegistrationButton_TextChanged);
            this.emailField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailFieldFormatting_KeyPress);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AuthForm.Properties.Resources.show1;
            this.pictureBox6.Location = new System.Drawing.Point(362, 183);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AuthForm.Properties.Resources.hide;
            this.pictureBox5.Location = new System.Drawing.Point(362, 183);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HiddenPassword_MouseDown);
            this.pictureBox5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VisiblePassoword_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AuthForm.Properties.Resources.information;
            this.pictureBox4.Location = new System.Drawing.Point(307, 376);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseHover += new System.EventHandler(this.ConclusionHints_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AuthForm.Properties.Resources.mail;
            this.pictureBox3.Location = new System.Drawing.Point(17, 265);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AuthForm.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(22, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AuthForm.Properties.Resources._lock;
            this.pictureBox1.Location = new System.Drawing.Point(17, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormWindowRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(404, 481);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormWindowRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration 0.1v";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}