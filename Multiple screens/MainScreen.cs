﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_screens
{
    public partial class MainScreen : UserControl
    {

        public MainScreen()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (usernameinfo.Text == Form1.usernametext && Passwordinfo.Text == Form1.passwordtext)
            {

                // f is the form that this control is on - ("this" is the current User Control) 

                Form f = this.FindForm();

                f.Controls.Remove(this);

                // Create an instance of the SecondScreen 

                WelcomScreen cs = new WelcomScreen();



                // Add the User Control to the Form 

                f.Controls.Add(cs);

                //cs.Location = new Point((this.Width - cs.Width) / 2, (this.Height - cs.Height) / 2);
            }
            else
            {
                incorrectLable.Text = "Incorrect please try again"; 
            }
        }
    }
}
