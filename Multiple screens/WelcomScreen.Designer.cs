namespace Multiple_screens
{
    partial class WelcomScreen
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
            this.welcomback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomback
            // 
            this.welcomback.AutoSize = true;
            this.welcomback.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomback.Location = new System.Drawing.Point(159, 126);
            this.welcomback.Name = "welcomback";
            this.welcomback.Size = new System.Drawing.Size(229, 25);
            this.welcomback.TabIndex = 0;
            this.welcomback.Text = "Welcome back Jayden";
            // 
            // WelcomScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.Controls.Add(this.welcomback);
            this.Name = "WelcomScreen";
            this.Size = new System.Drawing.Size(581, 377);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomback;
    }
}
