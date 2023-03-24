namespace AuthForm
{
    partial class FormWindowAuthorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.authorizationButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 63);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authorization 0.1v";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.loginField.Location = new System.Drawing.Point(100, 94);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(276, 38);
            this.loginField.TabIndex = 3;
            this.loginField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginFormatting_KeyPress);
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.passwordField.Location = new System.Drawing.Point(100, 195);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(276, 38);
            this.passwordField.TabIndex = 4;
            this.passwordField.UseSystemPasswordChar = true;
            this.passwordField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ЗasswordаFormatting_KeyPress);
            // 
            // authorizationButton
            // 
            this.authorizationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.authorizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.authorizationButton.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationButton.ForeColor = System.Drawing.Color.Transparent;
            this.authorizationButton.Location = new System.Drawing.Point(100, 311);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(194, 54);
            this.authorizationButton.TabIndex = 5;
            this.authorizationButton.Text = "Login";
            this.authorizationButton.UseVisualStyleBackColor = false;
            this.authorizationButton.Click += new System.EventHandler(this.UserAuthorizationbButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(137, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Регистрация";
            this.label2.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AuthForm.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(22, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AuthForm.Properties.Resources._lock;
            this.pictureBox1.Location = new System.Drawing.Point(22, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormWindowAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(404, 437);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authorizationButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormWindowAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auth 0.1v";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.Label label2;
    }
}

