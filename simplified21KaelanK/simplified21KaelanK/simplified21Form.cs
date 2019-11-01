/*
 * Created by: Kaelan K
 * Created on: 1-11-2019
 * Created for: ICS3U Programming
 * Assignment #5b - Blackjack
 * This program is a simplifed version of blackjack.
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

namespace simplified21KaelanK
{
    public partial class frmSimplified21 : Form
    {
        // declaring constants and variables
        int userTotal;
        int dealerTotal;
        const int MIN_NUM = 1;
        const int MAX_NUM = 11;
        int card1;
        int card2;
        int card3;
        int dealerCard1;
        int dealerCard2;
        int dealerCard3;
        
        // generate random number
        Random randomCardGenerator = new Random();   

        public frmSimplified21()
        {
            InitializeComponent();

            // hide labels at beginning
            this.lblCard1.Hide();
            this.lblCard2.Hide();
            this.lblCard3.Hide();
            this.lblDealerCard1.Hide();
            this.lblDealerCard2.Hide();
            this.lblDealerCard3.Hide();
            this.btnHit.Hide();
            this.btnStay.Hide();
            this.btnAce.Hide();
            this.btnOne.Hide();
            this.lblAce.Hide();
            this.lblOr.Hide();
            this.lblDealersCards.Hide();
            this.lblDealerTotal.Hide();
            this.lblUsersCards.Hide();
            this.lblUserTotal.Hide();
            this.lblWin.Hide();
            this.lblLose.Hide();
            this.lblTie.Hide();
            
            // if dealer gets blackjack
            if (dealerTotal == 21)
            {
                // show you lose label, disable buttons
                this.lblLose.Show();
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
            // if user gets blackjack
            if (userTotal == 21)
            {
                // show you win button and disable buttons
                this.lblWin.Show();
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            
            // Show the labels after button clicked
            this.lblCard1.Show();
            this.lblCard2.Show();
            this.lblDealerCard1.Show();
            this.lblDealerCard2.Show();
            this.lblDealerCard3.Show();
            this.btnHit.Show();
            this.btnStay.Show();
            this.lblDealersCards.Show();
            this.lblDealerTotal.Show();
            this.lblUsersCards.Show();
            this.lblUserTotal.Show();

            // Hide other labels and button
            this.lblBlackjack.Hide();
            this.btnStart.Hide();

            // assign random numbers to cards
            card1 = randomCardGenerator.Next(MIN_NUM, MAX_NUM + 1);
            card2 = randomCardGenerator.Next(MIN_NUM, MAX_NUM + 1);
            card3 = randomCardGenerator.Next(MIN_NUM, MAX_NUM + 1);

            // assign random numbers to dealer cards
            dealerCard1 = randomCardGenerator.Next(MIN_NUM, MAX_NUM + 1);
            dealerCard2 = randomCardGenerator.Next(MIN_NUM, MAX_NUM + 1);
            dealerCard3 = randomCardGenerator.Next(MIN_NUM, MAX_NUM + 1);

            // convert the numbers to string
            lblCard1.Text = Convert.ToString(card1);
            lblCard2.Text = Convert.ToString(card2);
            lblCard3.Text = Convert.ToString(card3);

            // if card1 is 1 then
            if (card1 == 1)
            {
                // show labels to give option on what card to choose
                this.lblAce.Show();
                this.lblOr.Show();
                this.btnAce.Show();
                this.btnOne.Show();
            } 
            // if card2 is 1 then
            else if (card2 == 1)
            {
                // show labels to give option on what card to choose
                this.lblAce.Show();
                this.lblOr.Show();
                this.btnAce.Show();
                this.btnOne.Show();
            }
            // if card1 is 11 then
            else if (card1 == 11)
            {
                // show labels to give option on what card to choose
                this.lblAce.Show();
                this.lblOr.Show();
                this.btnAce.Show();
                this.btnOne.Show();
            }
            // if card 2 is 11 then
            else if (card2 == 11)
            {
                // show labels to give option on what card to choose
                this.lblAce.Show();
                this.lblOr.Show();
                this.btnAce.Show();
                this.btnOne.Show();
            }

            // calculating totals
            userTotal = card1 + card2;
            dealerTotal = dealerCard1 + dealerCard2;

            // display total
            this.lblUserTotal.Text = Convert.ToString(userTotal);

        }

        private void BtnAce_Click(object sender, EventArgs e)
        {
            // if the card is 1 then
            if (card1 == 1)
            {
                // change card value to 11, update value, and hide labels
                card1 = 11;
                userTotal = card1 + card2;
                this.lblCard1.Text = "11";
                this.lblUserTotal.Text = Convert.ToString(userTotal);
                this.lblAce.Hide();
                this.lblOr.Hide();
                this.btnAce.Hide();
                this.btnOne.Hide();
                this.Refresh();
            }
            // if card 3 is 1 then
            else if (card2 == 1)
            {
                // change card value to 11, update value, and hide labels
                card2 = 11;
                userTotal = card1 + card2;
                this.lblCard2.Text = "11";
                this.lblUserTotal.Text = Convert.ToString(userTotal);
                this.lblAce.Hide();
                this.lblOr.Hide();
                this.btnAce.Hide();
                this.btnOne.Hide();
                this.Refresh();
            }
            // if card3 is 1 then
            else if (card3 == 1)
            {
                // change card value to 11, update value, and hide labels
                card3 = 11;
                userTotal = card1 + card2;
                this.lblCard3.Text = "11";
                this.lblUserTotal.Text = Convert.ToString(userTotal);
                this.lblAce.Hide();
                this.lblOr.Hide();
                this.btnAce.Hide();
                this.btnOne.Hide();
                this.Refresh();
            }
            // if card1 is 11 then
            else if (card1 == 11)
            {
                // change card value
                card1 = 11;
                userTotal = card1 + card2;
                this.lblCard1.Text = "11";
                this.lblUserTotal.Text = Convert.ToString(userTotal);
                this.lblAce.Hide();
                this.lblOr.Hide();
                this.btnAce.Hide();
                this.btnOne.Hide();
                this.Refresh();
            }
            // if card2 is 11 then
            else if (card2 == 11)
            {
                // change card value
                card2 = 11;
                userTotal = card1 + card2;
                this.lblCard2.Text = "11";
                this.lblUserTotal.Text = Convert.ToString(userTotal);
                this.lblAce.Hide();
                this.lblOr.Hide();
                this.btnAce.Hide();
                this.btnOne.Hide();
                this.Refresh();
            }
            // if card3 is 11 then
            else if (card3 == 11)
            {
                // change card value
                card3 = 11;
                userTotal = card1 + card2;
                this.lblCard3.Text = "11";
                this.lblUserTotal.Text = Convert.ToString(userTotal);
                this.lblAce.Hide();
                this.lblOr.Hide();
                this.btnAce.Hide();
                this.btnOne.Hide();
                this.Refresh();
            }

        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            // if card1 is 11 then
            if (card1 == 11)
            {
                // change card value
                card1 = 1;
                userTotal = card1 + card2;
                this.lblCard1.Text = "1";
                this.lblUserTotal.Text = Convert.ToString(userTotal);
                this.lblAce.Hide();
                this.lblOr.Hide();
                this.btnAce.Hide();
                this.btnOne.Hide();
                this.Refresh();
            }
            // if card1 is 11 then
            else if (card2 == 11)
            {
                // change card value
                card2 = 1;
                userTotal = card1 + card2;
                this.lblCard2.Text = "1";
                this.lblUserTotal.Text = Convert.ToString(userTotal);
                this.lblAce.Hide();
                this.lblOr.Hide();
                this.btnAce.Hide();
                this.btnOne.Hide();
                this.Refresh();
            }
            // if card1 is 11 then
            else if (card3 == 11)
            {
                // change card value
                card3 = 1;
                userTotal = card1 + card2;
                this.lblCard3.Text = "1";
                this.lblUserTotal.Text = Convert.ToString(userTotal);
                this.lblAce.Hide();
                this.lblOr.Hide();
                this.btnAce.Hide();
                this.btnOne.Hide();
                this.Refresh();
            }
            // if the card is 1 then
            if (card1 == 1)
            {
                // change card value to 11, update value, and hide labels
                card1 = 1;
                userTotal = card1 + card2;
                this.lblCard1.Text = "1";
                this.lblUserTotal.Text = Convert.ToString(userTotal);
                this.lblAce.Hide();
                this.lblOr.Hide();
                this.btnAce.Hide();
                this.btnOne.Hide();
                this.Refresh();
            }
            // if card 3 is 1 then
            else if (card2 == 1)
            {
                // change card value to 11, update value, and hide labels
                card2 = 1;
                userTotal = card1 + card2;
                this.lblCard2.Text = "1";
                this.lblUserTotal.Text = Convert.ToString(userTotal);
                this.lblAce.Hide();
                this.lblOr.Hide();
                this.btnAce.Hide();
                this.btnOne.Hide();
                this.Refresh();
            }
            // if card3 is 1 then
            else if (card3 == 1)
            {
                // change card value to 11, update value, and hide labels
                card3 = 1;
                userTotal = card1 + card2;
                this.lblCard3.Text = "1";
                this.lblUserTotal.Text = Convert.ToString(userTotal);
                this.lblAce.Hide();
                this.lblOr.Hide();
                this.btnAce.Hide();
                this.btnOne.Hide();
                this.Refresh();
            }
            // if users total is 21 then
            if (userTotal == 21)
            {
                // disable win label and disable buttons
                this.lblWin.Show();
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
          
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {
            // if card3 is 11 then
            if (card3 == 11)
            {
                // show choice labels
                this.lblAce.Show();
                this.lblOr.Show();
                this.btnAce.Show();
                this.btnOne.Show();
            }
            // if card 2 is 1 then
            else if (card3 == 1)
            {
                // show chioce labels
                this.lblAce.Show();
                this.lblOr.Show();
                this.btnAce.Show();
                this.btnOne.Show();
            }
            
            // show hit card, update total, display cards
            this.lblCard3.Show();
            dealerTotal = dealerTotal + dealerCard3;
            userTotal = userTotal + card3;
            lblDealerCard1.Text = Convert.ToString(dealerCard1);
            lblDealerCard2.Text = Convert.ToString(dealerCard2);
            lblDealerCard3.Text = Convert.ToString(dealerCard3);
            this.lblDealerTotal.Text = Convert.ToString(dealerTotal);
            this.lblUserTotal.Text = Convert.ToString(userTotal);
            this.Refresh();
            // if user total is dealertotal then 
            if (userTotal == dealerTotal)
            {
                // show tie label and disable buttons
                this.lblTie.Show();
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
            // if user total is 21 then
            else if (userTotal == 21)
            {
                // show lose label and disable buttons

                this.lblWin.Show();
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
            // if usertotal greater then 21
            else if (userTotal > 21)
            {
                // show lose label and disable buttons
                this.lblLose.Show();
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
            // if user total greater then dealer total then
            else if (userTotal > dealerTotal)
            {
                // user total less then 21 then
                if (userTotal < 21)
                {
                    // show win label and disable buttons
                    this.lblWin.Show();
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;
                }
            }
            // if dealer total is 21 then
            else if (dealerTotal == 21)
            {
                // show lose label and disable buttons
                this.lblLose.Show();
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
            // if dealer total greater then 21
            else if (dealerTotal > 21)
            {
                // show win label and disable buttons
                this.lblWin.Show();
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
            // if dealer total greater then user total then
            else if (dealerTotal > userTotal)
            {
                // is dealer total less then 21 then
                if (dealerTotal < 21)
                {
                    // show lose label and disable buttons
                    this.lblLose.Show();
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;
                }
            }
        }

        private void BtnStay_Click(object sender, EventArgs e)
        {
            // disable button and display cpu numbers
            this.btnHit.Enabled = false;
            dealerTotal = dealerTotal + dealerCard3;
            lblDealerCard1.Text = Convert.ToString(dealerCard1);
            lblDealerCard2.Text = Convert.ToString(dealerCard2);
            lblDealerCard3.Text = Convert.ToString(dealerCard3);
            this.lblDealerTotal.Text = Convert.ToString(dealerTotal);
            this.lblDealerCard3.Show();

            // if user value is cpu value then
            if (userTotal == dealerTotal)
            {
                // display tie label and hide labels
                this.lblTie.Show();
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
            // if user total greater then 21
            else if (userTotal > 21)
            {
                // show lose label and disable buttons
                this.lblLose.Show();
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
            // if user total greater then dealer total
            else if (userTotal > dealerTotal)
            {
                // is user total less then 21
                if (userTotal < 21)
                {
                    // shoe win label and disable buttons
                    this.lblWin.Show();
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;
                }
            }
            // if dealer total is 21
            else if (dealerTotal == 21)
            {
                // show lose label and disable buttons
                this.lblLose.Show();
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
            // if dealer total greater then 21 then
            else if (dealerTotal > 21)
            {
                // display win label and disable  buttons
                this.lblWin.Show();
                this.btnHit.Enabled = false;
                this.btnStay.Enabled = false;
            }
            // if dealer total is greater then user total then
            else if (dealerTotal > userTotal)
            {
                // if dealer total is less then 21 then
                if (dealerTotal < 21)
                {
                    // show lose label and disable buttons
                    this.lblLose.Show();
                    this.btnHit.Enabled = false;
                    this.btnStay.Enabled = false;
                }
            }
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }

        private void MniReset_Click(object sender, EventArgs e)
        {
            // hide the labels
            this.lblCard1.Hide();
            this.lblCard2.Hide();
            this.lblCard3.Hide();
            this.lblDealerCard1.Hide();
            this.lblDealerCard2.Hide();
            this.lblDealerCard3.Hide();
            this.btnHit.Hide();
            this.btnStay.Hide();
            this.btnAce.Hide();
            this.btnOne.Hide();
            this.lblAce.Hide();
            this.lblOr.Hide();
            this.lblDealersCards.Hide();
            this.lblDealerTotal.Hide();
            this.lblUsersCards.Hide();
            this.lblUserTotal.Hide();
            this.lblWin.Hide();
            this.lblLose.Hide();
            this.lblTie.Hide();

            // show start labels and buttons
            this.lblBlackjack.Show();
            this.btnStart.Show();

            // re enable buttons
            this.btnHit.Enabled = true;
            this.btnStay.Enabled = true;
        }
    }
}
