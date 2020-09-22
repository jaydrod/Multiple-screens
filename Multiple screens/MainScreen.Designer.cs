namespace Multiple_screens
{
    partial class MainScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.usernameinfo = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Passwordinfo = new System.Windows.Forms.TextBox();
            this.welcomback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(184, 230);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Login";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(31, 40);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(97, 24);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "Username";
            // 
            // usernameinfo
            // 
            this.usernameinfo.Location = new System.Drawing.Point(158, 43);
            this.usernameinfo.Name = "usernameinfo";
            this.usernameinfo.Size = new System.Drawing.Size(222, 20);
            this.usernameinfo.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(35, 85);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(106, 25);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // Passwordinfo
            // 
            this.Passwordinfo.Location = new System.Drawing.Point(158, 91);
            this.Passwordinfo.Name = "Passwordinfo";
            this.Passwordinfo.Size = new System.Drawing.Size(212, 20);
            this.Passwordinfo.TabIndex = 4;
            // 
            // welcomback
            // 
            this.welcomback.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomback.Location = new System.Drawing.Point(92, 271);
            this.welcomback.Name = "welcomback";
            this.welcomback.Size = new System.Drawing.Size(288, 56);
            this.welcomback.TabIndex = 5;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.Controls.Add(this.welcomback);
            this.Controls.Add(this.Passwordinfo);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.usernameinfo);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Start);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(467, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox usernameinfo;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox Passwordinfo;
        private System.Windows.Forms.Label welcomback;
    }
}
