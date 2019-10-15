/*
 * Created by: Kaelan K
 * Created on: 15-10-2019
 * Created for: ICS3U Programming
 * Assignment #4b - Pizza Order
 * This program takes a users input for size, toppings, sides, and amount of pizzas
 * and calculates the subtotal, tax and total then tells you how long your pizza will be
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

            // setting the constants
            const double XtraLarge = 12.99;
            const double Large = 9.99;
            const double Medium = 8.59;
            const double NoSide = 0;
            const double Poutine = 4.99;
            const double Wings = 7.99;
            const double Fries = 3.99;
            const double OneTop = 0.75;
            const double TwoTop = 1.35;
            const double ThreeTop = 2.15;
            const double FourTop = 2.75;
            const double FiveTop = 3;
            const double OnePie = 1;
            const double TwoPie = 2;
            const double ThreePie = 3;

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
                pizzaCost = XtraLarge;
            }
            else if (pizzaSize == 2)
            {
                pizzaTime = 35;
                pizzaCost = Large;
            }
            else if (pizzaSize == 1)
            {
                pizzaTime = 30;
                pizzaCost = Medium;
            }

            // Setting the sides cost
            if (sides == 0)
            {
                sidesCost = NoSide;
            }
            else if (sides == 1)
            {
                sidesCost = Poutine;
            }
            else if (sides == 2)
            {
                sidesCost = Wings;
            }
            else if (sides == 3)
            {
                sidesCost = Fries;
            }

            // Setting the toppings cost
            if (toppings == 1)
            {
                toppingsCost = OneTop;
            }
            else if (toppings == 2)
            {
                toppingsCost = TwoTop;
            }
            else if (toppings == 3)
            {
                toppingsCost = ThreeTop;
            }
            else if (toppings == 4)
            {
                toppingsCost = FourTop;
            }
            else if (toppings == 5)
            {
                toppingsCost = FiveTop;
            }

            // Setting the amount of pizzas
            if (amountPizzas == 1)
            {
                pizzaMultiplier = OnePie;
            }
            else if (amountPizzas == 2)
            {
                pizzaMultiplier = TwoPie;
            }
            else if (amountPizzas == 3)
            {
                pizzaMultiplier = ThreePie;
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
