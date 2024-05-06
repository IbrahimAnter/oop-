namespace my_system
{
    partial class Form2
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
            this.sign_up1 = new System.Windows.Forms.Button();
            this.add_client_1 = new System.Windows.Forms.Button();
            this.delete_client_1 = new System.Windows.Forms.Button();
            this.Update_Client_1 = new System.Windows.Forms.Button();
            this.Exit_1 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sign_up1
            // 
            this.sign_up1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.sign_up1.Location = new System.Drawing.Point(37, 40);
            this.sign_up1.Name = "sign_up1";
            this.sign_up1.Size = new System.Drawing.Size(137, 46);
            this.sign_up1.TabIndex = 0;
            this.sign_up1.Text = "Sign Up";
            this.sign_up1.UseVisualStyleBackColor = true;
            this.sign_up1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_client_1
            // 
            this.add_client_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.add_client_1.Location = new System.Drawing.Point(221, 40);
            this.add_client_1.Name = "add_client_1";
            this.add_client_1.Size = new System.Drawing.Size(151, 46);
            this.add_client_1.TabIndex = 1;
            this.add_client_1.Text = "Add Client";
            this.add_client_1.UseVisualStyleBackColor = true;
            this.add_client_1.Click += new System.EventHandler(this.add_client_1_Click);
            // 
            // delete_client_1
            // 
            this.delete_client_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.delete_client_1.Location = new System.Drawing.Point(427, 41);
            this.delete_client_1.Name = "delete_client_1";
            this.delete_client_1.Size = new System.Drawing.Size(189, 46);
            this.delete_client_1.TabIndex = 2;
            this.delete_client_1.Text = "Delete Client";
            this.delete_client_1.UseVisualStyleBackColor = true;
            this.delete_client_1.Click += new System.EventHandler(this.delete_client_1_Click);
            // 
            // Update_Client_1
            // 
            this.Update_Client_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Update_Client_1.Location = new System.Drawing.Point(676, 40);
            this.Update_Client_1.Name = "Update_Client_1";
            this.Update_Client_1.Size = new System.Drawing.Size(159, 45);
            this.Update_Client_1.TabIndex = 3;
            this.Update_Client_1.Text = "Update Client";
            this.Update_Client_1.UseVisualStyleBackColor = true;
            this.Update_Client_1.Click += new System.EventHandler(this.Update_Client_1_Click);
            // 
            // Exit_1
            // 
            this.Exit_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Exit_1.Location = new System.Drawing.Point(884, 40);
            this.Exit_1.Name = "Exit_1";
            this.Exit_1.Size = new System.Drawing.Size(122, 45);
            this.Exit_1.TabIndex = 4;
            this.Exit_1.Text = "Exit";
            this.Exit_1.UseVisualStyleBackColor = true;
            this.Exit_1.Click += new System.EventHandler(this.Exit_1_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Back.Location = new System.Drawing.Point(37, 150);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(122, 45);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::my_system.Properties.Resources.shopping_carts_1275480_1280;
            this.ClientSize = new System.Drawing.Size(1170, 599);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit_1);
            this.Controls.Add(this.Update_Client_1);
            this.Controls.Add(this.delete_client_1);
            this.Controls.Add(this.add_client_1);
            this.Controls.Add(this.sign_up1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sign_up1;
        private System.Windows.Forms.Button add_client_1;
        private System.Windows.Forms.Button delete_client_1;
        private System.Windows.Forms.Button Update_Client_1;
        private System.Windows.Forms.Button Exit_1;
        private System.Windows.Forms.Button Back;
    }
}