namespace my_system
{
    partial class Form1
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
            this.login = new System.Windows.Forms.Button();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(417, 256);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(105, 37);
            this.login.TabIndex = 0;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(371, 113);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(151, 22);
            this.username_textBox.TabIndex = 2;
            this.username_textBox.TextChanged += new System.EventHandler(this.login_textBox_TextChanged);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(371, 186);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(151, 22);
            this.password_textBox.TabIndex = 3;
            this.password_textBox.UseSystemPasswordChar = true;
            this.password_textBox.TextChanged += new System.EventHandler(this.signup_textBox_TextChanged);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(217, 109);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(107, 25);
            this.username.TabIndex = 4;
            this.username.Text = "username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(218, 192);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(104, 25);
            this.password.TabIndex = 5;
            this.password.Text = "password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::my_system.Properties.Resources.shopping_carts_1275480_1280;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
    }
}

