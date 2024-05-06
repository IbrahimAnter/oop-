namespace my_system
{
    partial class Form5
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
            this.Exit = new System.Windows.Forms.Button();
            this.updateclient = new System.Windows.Forms.Button();
            this.tbfirst_name = new System.Windows.Forms.TextBox();
            this.tblast_name = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbstreet = new System.Windows.Forms.TextBox();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.tbcustomer_id = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.Label();
            this.customer_id = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Exit.Location = new System.Drawing.Point(581, 242);
            this.Exit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(143, 48);
            this.Exit.TabIndex = 27;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // updateclient
            // 
            this.updateclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.updateclient.Location = new System.Drawing.Point(553, 172);
            this.updateclient.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.updateclient.Name = "updateclient";
            this.updateclient.Size = new System.Drawing.Size(194, 48);
            this.updateclient.TabIndex = 26;
            this.updateclient.Text = "Update Client";
            this.updateclient.UseVisualStyleBackColor = true;
            this.updateclient.Click += new System.EventHandler(this.addclient_Click);
            // 
            // tbfirst_name
            // 
            this.tbfirst_name.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold);
            this.tbfirst_name.Location = new System.Drawing.Point(262, 100);
            this.tbfirst_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbfirst_name.Name = "tbfirst_name";
            this.tbfirst_name.Size = new System.Drawing.Size(154, 25);
            this.tbfirst_name.TabIndex = 25;
            this.tbfirst_name.TextChanged += new System.EventHandler(this.tbfirst_name_TextChanged);
            // 
            // tblast_name
            // 
            this.tblast_name.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold);
            this.tblast_name.Location = new System.Drawing.Point(262, 188);
            this.tblast_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tblast_name.Name = "tblast_name";
            this.tblast_name.Size = new System.Drawing.Size(154, 25);
            this.tblast_name.TabIndex = 24;
            this.tblast_name.TextChanged += new System.EventHandler(this.tblast_name_TextChanged);
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold);
            this.tbemail.Location = new System.Drawing.Point(262, 335);
            this.tbemail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(154, 25);
            this.tbemail.TabIndex = 23;
            this.tbemail.TextChanged += new System.EventHandler(this.tbemail_TextChanged);
            // 
            // tbstreet
            // 
            this.tbstreet.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold);
            this.tbstreet.Location = new System.Drawing.Point(262, 406);
            this.tbstreet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbstreet.Name = "tbstreet";
            this.tbstreet.Size = new System.Drawing.Size(154, 25);
            this.tbstreet.TabIndex = 22;
            this.tbstreet.TextChanged += new System.EventHandler(this.tbstreet_TextChanged);
            // 
            // tbphone
            // 
            this.tbphone.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold);
            this.tbphone.Location = new System.Drawing.Point(262, 263);
            this.tbphone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(154, 25);
            this.tbphone.TabIndex = 21;
            this.tbphone.TextChanged += new System.EventHandler(this.tbphone_TextChanged);
            // 
            // tbcustomer_id
            // 
            this.tbcustomer_id.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcustomer_id.Location = new System.Drawing.Point(262, 20);
            this.tbcustomer_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbcustomer_id.Name = "tbcustomer_id";
            this.tbcustomer_id.Size = new System.Drawing.Size(154, 25);
            this.tbcustomer_id.TabIndex = 20;
            this.tbcustomer_id.TextChanged += new System.EventHandler(this.tbcustomer_id_TextChanged);
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street.Location = new System.Drawing.Point(105, 406);
            this.street.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(66, 25);
            this.street.TabIndex = 19;
            this.street.Text = "street";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(105, 335);
            this.email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(63, 25);
            this.email.TabIndex = 18;
            this.email.Text = "email";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(105, 265);
            this.phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(72, 25);
            this.phone.TabIndex = 17;
            this.phone.Text = "phone";
            this.phone.Click += new System.EventHandler(this.phone_Click);
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name.Location = new System.Drawing.Point(105, 190);
            this.last_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(111, 25);
            this.last_name.TabIndex = 16;
            this.last_name.Text = "last_name";
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name.Location = new System.Drawing.Point(105, 102);
            this.first_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(112, 25);
            this.first_name.TabIndex = 15;
            this.first_name.Text = "first_name";
            // 
            // customer_id
            // 
            this.customer_id.AutoSize = true;
            this.customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_id.Location = new System.Drawing.Point(105, 20);
            this.customer_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(129, 25);
            this.customer_id.TabIndex = 14;
            this.customer_id.Text = "customer_id";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Back.Location = new System.Drawing.Point(581, 312);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(143, 48);
            this.Back.TabIndex = 28;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::my_system.Properties.Resources.shopping_carts_1275480_1280;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.updateclient);
            this.Controls.Add(this.tbfirst_name);
            this.Controls.Add(this.tblast_name);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbstreet);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.tbcustomer_id);
            this.Controls.Add(this.street);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.customer_id);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button updateclient;
        private System.Windows.Forms.TextBox tbfirst_name;
        private System.Windows.Forms.TextBox tblast_name;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbstreet;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.TextBox tbcustomer_id;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.Label customer_id;
        private System.Windows.Forms.Button Back;
    }
}