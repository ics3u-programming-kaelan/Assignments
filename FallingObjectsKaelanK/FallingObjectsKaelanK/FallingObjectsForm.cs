/*
 * Created by: Kaelan K
 * Created on: 24-09-2019
 * Created for: ICS3U Programming
 * Assignment #2 - Falling Objects
 * This program calculates the height of an object when dropped off of a cliff
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingObjectsKaelanK
{
    public partial class frmFallingObjects : Form
    {
        public frmFallingObjects()
        {
            InitializeComponent();

            // hide the labels on load
            this.lblHeight.Hide();
            this.lblHeightAns.Hide();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
         
            // setting variables
            double time, answer;

            // converting to double
            time = double.Parse(txtTime.Text);

            // calculates height with users variable
            answer = 100 - 0.5 * 9.81 * Math.Pow(time, 2);

            // displaying answer
            this.lblHeightAns.Text = Convert.ToString(answer + " m");

            // if answer lower than zero
            if (answer < 0)
            {
                this.lblHeightAns.Text = "The ball has already hit the ground";
            }

            // show the two labels
            this.lblHeight.Show();
            this.lblHeightAns.Show();

        }

        // closes program
        private void MniExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // hides answer labels
        private void MniReset_Click(object sender, EventArgs e)
        {
            this.lblHeight.Hide();
            this.lblHeightAns.Hide();
        }
    }
}
