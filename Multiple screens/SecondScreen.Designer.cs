namespace Multiple_screens
{
    partial class SecondScreen
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
            this.welcombacklable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcombacklable
            // 
            this.welcombacklable.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcombacklable.ForeColor = System.Drawing.Color.Silver;
            this.welcombacklable.Location = new System.Drawing.Point(221, 159);
            this.welcombacklable.Name = "welcombacklable";
            this.welcombacklable.Size = new System.Drawing.Size(429, 51);
            this.welcombacklable.TabIndex = 0;
            this.welcombacklable.Text = "Welcome back Jayden";
            // 
            // SecondScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcombacklable);
            this.Name = "SecondScreen";
            this.Text = "SecondScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcombacklable;
    }
}