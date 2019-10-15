/*
 * Created by: Kaelan K
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Assignment #3b - Name of Program
 * This program...
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

namespace Assign4PizzaOrder
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();

            // Hide the labels on build
            lblSubtotalAns.Hide();
            lblTotalAns.Hide();
            lblTaxAns.Hide();
            lblPizzaTime.Hide();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            // showing the labels again
            lblSubtotalAns.Show();
            lblTaxAns.Show();
            lblTotalAns.Show();
            lblPizzaTime.Show();

            // setting all of the vars
            double pizzaSize, toppings, sides, amountPizzas, pizzaTime, pizzaCost, toppingsCost, sidesCost, pizzaMultiplier, subtotal, tax, total;

            pizzaCost = 0;

            sidesCost = 0;

            toppingsCost = 0;

            pizzaTime = 0;

            pizzaMultiplier = 1;

            subtotal = 0;

            tax = 0;

            total = 0;

            // parsing the text values to numerical values
            pizzaSize = double.Parse(nupPizzaSize.Text);

            toppings = double.Parse(nupToppings.Text);

            sides = double.Parse(nupSides.Text);

            amountPizzas = double.Parse(nupAmountOfPizzas.Text);

            // Setting Pizza cost and time depending on the value
            if (pizzaSize == 3)
            {
                pizzaTime = 40;
                pizzaCost = 12.99;
            }
            else if (pizzaSize == 2)
            {
                pizzaTime = 35;
                pizzaCost = 9.99;
            }
            else if (pizzaSize == 1)
            {
                pizzaTime = 30;
                pizzaCost = 8.59;
            }

            // Setting the sides cost
            if (sides == 0)
            {
                sidesCost = 0;
            }
            else if (sides == 1)
            {
                sidesCost = 4.99;
            }
            else if (sides == 2)
            {
                sidesCost = 7.99;
            }
            else if (sides == 3)
            {
                sidesCost = 3.99;
            }

            // Setting the toppings cost
            if (toppings == 1)
            {
                toppingsCost = 0.75;
            }
            else if (toppings == 2)
            {
                toppingsCost = 1.35;
            }
            else if (toppings == 3)
            {
                toppingsCost = 2.15;
            }
            else if (toppings == 4)
            {
                toppingsCost = 2.75;
            }
            else if (toppings == 5)
            {
                toppingsCost = 3;
            }

            // Setting the amount of pizzas
            if (amountPizzas == 1)
            {
                pizzaMultiplier = 1;
            }
            else if (amountPizzas == 2)
            {
                pizzaMultiplier = 2;
            }
            else if (amountPizzas == 3)
            {
                pizzaMultiplier = 3;
            }

            // Calculating subtotal
            subtotal = pizzaCost * pizzaMultiplier + sidesCost + toppingsCost * pizzaMultiplier;

            // Calculating tax
            tax = subtotal * 0.13;

            // Calculating total
            total = subtotal * 1.13;

            // Converting the numerical values back to text
            lblSubtotalAns.Text = String.Format("${0:0.00}", subtotal);

            lblTaxAns.Text = String.Format("${0:0.00}", tax);

            lblTotalAns.Text = String.Format("${0:0.00}", total);

            lblPizzaTime.Text = Convert.ToString("It will take " + pizzaTime + " minutes for your pizza to be ready");

        }
    }
}
