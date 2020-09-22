﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_screens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string username; 

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create an instance of the MainScreen 

            MainScreen ms = new MainScreen();


            // Add the User Control to the Form 

            this.Controls.Add(ms);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }

    }
}
