namespace my_system
{
    partial class Form3
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
            this.signup = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.signup.Location = new System.Drawing.Point(199, 229);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(102, 36);
            this.signup.TabIndex = 0;
            this.signup.Text = "signup";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.username.Location = new System.Drawing.Point(194, 81);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(107, 25);
            this.username.TabIndex = 2;
            this.username.Text = "username";
            this.username.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.password.Location = new System.Drawing.Point(197, 167);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(104, 25);
            this.password.TabIndex = 3;
            this.password.Text = "password";
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(394, 84);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(164, 22);
            this.username_textBox.TabIndex = 4;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(394, 167);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(164, 22);
            this.password_textBox.TabIndex = 5;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Back.Location = new System.Drawing.Point(335, 229);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(109, 41);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::my_system.Properties.Resources.grocery_1232944_1280;
            this.ClientSize = new System.Drawing.Size(741, 424);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.signup);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button Back;
    }
}