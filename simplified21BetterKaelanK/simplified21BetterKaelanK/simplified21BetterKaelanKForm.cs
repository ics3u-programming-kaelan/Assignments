/*
 * Created by: Kaelan K
 * Created on: 05-12-2019
 * Created for: ICS3U Programming
 * Assignment #6b - Simplified 21 (Better Version)
 * This program lets the user play a better version of simplified 21 using functions and procedures
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
using System.Media;
using System.Threading;
using System.Text.RegularExpressions;

namespace simplified21BetterKaelanK
{
    public partial class simplified21BetterKaelanKForm : Form
    {
        public simplified21BetterKaelanKForm()
        {
            InitializeComponent();
            start();
        }

        // decalre my 52 card deck and my values deck
        List<string> regDeck = new List<string>() { "AS", "2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "10S", "JS", "QS", "KS", "AC", "2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C", "10C", "JC", "QC", "KC", "AD", "2D", "3D", "4D", "5D", "6D", "7D", "8D", "9D", "10D", "JD", "QD", "KD", "AH", "2H", "3H", "4H", "5H", "6H", "7H", "8H", "9H", "10H", "JH", "QH", "KH" };
        List<string> newDeck = new List<string>();
        List<int> deckValues = new List<int>() { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
        List<int> regValues = new List<int>();

        // declare my global variables
        int bet;
        bool playerHasAnAce = false;
        bool dealerHasAnAce = false;

        Random randomNumberGenerator = new Random();
        int counter;
        int cardNumber;
        int playerTotal = 0;
        int dealerTotal = 0;
        double money = 100;
        int faceDownCard;
        Image secretCard;

        private void btnHit_Click(object sender, EventArgs e)
        {
            if (newDeck.Count() > 0)
            {
                hit();
            }

            else
            {
                // remake the deck and then recall the function
                MessageBox.Show("I need to shuffle the deck");
                newDeck = new List<string>() { "AS", "2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "10S", "JS", "QS", "KS", "AC", "2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C", "10C", "JC", "QC", "KC", "AD", "2D", "3D", "4D", "5D", "6D", "7D", "8D", "9D", "10D", "JD", "QD", "KD", "AH", "2H", "3H", "4H", "5H", "6H", "7H", "8H", "9H", "10H", "JH", "QH", "KH" };
                deckValues = new List<int>() { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
                MessageBox.Show("" + newDeck.Count());
                hit();
            }
        }

        private void start()
        {
            // make the buttons disabled except for the start button
            btnHit.Enabled = false;
            btnStay.Enabled = false;
            txtBet.Enabled = false;
            btnBet.Enabled = false;
            btnPlayAgain.Enabled = false;
            btnStart.Enabled = true;
            btnStart.Visible = true;

            // display the user's money 
            money = 100;
            lblMoney.Text = "You have " + money + "$";

            // set the player and dealer total to 0
            playerTotal = 0;
            dealerTotal = 0;

            // hide all the cards
            picCard1.Visible = false;
            picCard2.Visible = false;
            picCard3.Visible = false;
            picCard4.Visible = false;
            picCard5.Visible = false;
            picCard6.Visible = false;

            picDCard1.Visible = false;
            picDCard2.Visible = false;
            picDCard3.Visible = false;
            picDCard4.Visible = false;
            picDCard5.Visible = false;
            picDCard6.Visible = false;

            // play the cash sound
            SoundPlayer cash = new SoundPlayer(@"CAIXA.wav");
            cash.Play();

        }

        private void hit()
        {
            if (newDeck.Count > 1)
            {
                switch (counter)
                {
                    case 4:
                        // generate a random card
                        cardNumber = randomNumberGenerator.Next(0, newDeck.Count());
                        // display the card
                        this.picCard3.Image = Image.FromFile(@"Cards/" + newDeck[cardNumber] + ".jpg");
                        picCard3.Visible = true;
                        turnOverCard();
                        break;
                    case 5:
                        // generate a random card
                        cardNumber = randomNumberGenerator.Next(0, newDeck.Count());
                        // display the card
                        this.picCard4.Image = Image.FromFile(@"Cards/" + newDeck[cardNumber] + ".jpg");
                        picCard4.Visible = true;
                        turnOverCard();
                        break;
                    case 6:
                        // generate a random card
                        cardNumber = randomNumberGenerator.Next(0, newDeck.Count());
                        // display the card
                        this.picCard5.Image = Image.FromFile(@"Cards/" + newDeck[cardNumber] + ".jpg");
                        picCard5.Visible = true;
                        turnOverCard();
                        break;
                    case 7:
                        // generate a random card
                        cardNumber = randomNumberGenerator.Next(0, newDeck.Count());
                        // display the card
                        this.picCard6.Image = Image.FromFile(@"Cards/" + newDeck[cardNumber] + ".jpg");
                        picCard6.Visible = true;
                        turnOverCard();
                        break;
                }
            }
            else
            {
                shuffle();
                hit();
            }

            // display the amount of cards in the deck
            lblDeckTotal.Text = "The deck has " + newDeck.Count() + " cards left in it";
        }

        private void shuffle()
        {
            // remake the deck and then recall the function
            MessageBox.Show("I need to shuffle the deck");
            newDeck = new List<string>() { "AS", "2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "10S", "JS", "QS", "KS", "AC", "2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C", "10C", "JC", "QC", "KC", "AD", "2D", "3D", "4D", "5D", "6D", "7D", "8D", "9D", "10D", "JD", "QD", "KD", "AH", "2H", "3H", "4H", "5H", "6H", "7H", "8H", "9H", "10H", "JH", "QH", "KH" };
            deckValues = new List<int>() { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
        }

        private void turnOverCard()
        {
            // remove the card from the deck and display the players total
            newDeck.RemoveAt(cardNumber);
            playerTotal += deckValues[cardNumber];

            // set the cards left progress bar
            if (newDeck.Count > 50)
            {
                this.prbCardsLeft.Value = newDeck.Count * 2 - 4;
            }
            else
            {
                this.prbCardsLeft.Value = newDeck.Count * 2;
            }
            // check if they have an ace
            if (deckValues[cardNumber] == 11)
            {
                playerHasAnAce = true;
            }

            deckValues.RemoveAt(cardNumber);
            lblPlayerTotal.Text = Convert.ToString(playerTotal);
            counter++;

            // check if the user busted
            if (playerTotal > 21)
            {
                if (playerHasAnAce == true)
                {
                    // reduce the players total by 10 then display it
                    playerTotal -= 10;
                    lblPlayerTotal.Text = Convert.ToString(playerTotal);
                    playerHasAnAce = false;
                }

                if (playerTotal > 21)
                {
                    // tell the user they busted
                    MessageBox.Show("You busted!");

                    // enable the play again button
                    btnPlayAgain.Enabled = true;

                    // reduce the user's money
                    money = money - bet;
                    lblMoney.Text = "You have " + money + "$";

                    // disable everything 
                    btnHit.Enabled = false;
                    btnStay.Enabled = false;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // hide the start button and enable betting
            txtBet.Enabled = true;
            btnBet.Enabled = true;
            btnStart.Visible = false;
        }

        public void dealFirst4()
        {
            // make sure the deck has at least 4 cards in it
            if (newDeck.Count() >= 4)
            {
                for (counter = 0; counter < 4; counter++)
                {
                    // set the cards left progress bar
                    if (newDeck.Count > 50)
                    {
                        this.prbCardsLeft.Value = newDeck.Count * 2 - 4;
                    }
                    else
                    {
                        this.prbCardsLeft.Value = newDeck.Count * 2;
                    }

                    switch (counter)
                    {
                        case 0:
                            cardNumber = randomNumberGenerator.Next(0, newDeck.Count());
                            // display the card
                            this.picCard1.Image = Image.FromFile(@"Cards/" + newDeck[cardNumber] + ".jpg");
                            picCard1.Visible = true;

                            // remove the card from the deck
                            newDeck.RemoveAt(cardNumber);
                            playerTotal += deckValues[cardNumber];
                            deckValues.RemoveAt(cardNumber);
                            break;
                        case 1:
                            cardNumber = randomNumberGenerator.Next(0, newDeck.Count());
                            // display the card
                            this.picCard2.Image = Image.FromFile(@"Cards/" + newDeck[cardNumber] + ".jpg");
                            picCard2.Visible = true;

                            newDeck.RemoveAt(cardNumber);
                            playerTotal += deckValues[cardNumber];
                            deckValues.RemoveAt(cardNumber);
                            break;
                        case 2:
                            cardNumber = randomNumberGenerator.Next(0, newDeck.Count());
                            // display the card
                            this.picDCard1.Image = Image.FromFile(@"Cards/" + newDeck[cardNumber] + ".jpg");
                            picDCard1.Visible = true;
                            newDeck.RemoveAt(cardNumber);
                            dealerTotal += deckValues[cardNumber];
                            deckValues.RemoveAt(cardNumber);
                            break;
                        case 3:
                            // create the face down card
                            this.picDCard2.Image = Image.FromFile(@"Cards/Front.jpg");
                            cardNumber = randomNumberGenerator.Next(0, newDeck.Count());
                            secretCard = Image.FromFile(@"Cards /" + newDeck[cardNumber] + ".jpg");
                            faceDownCard = deckValues[cardNumber];
                            picDCard2.Visible = true;
                            newDeck.RemoveAt(cardNumber);
                            deckValues.RemoveAt(cardNumber);

                            // check if the user got blackjack
                            if (playerTotal == 21)
                            {
                                // tell the user they got blackjack
                                MessageBox.Show("Blackjack!");
                                money = money + Math.Truncate(bet * 1.5);
                                lblMoney.Text = "You have " + money + "$";

                                btnHit.Enabled = false;
                                btnStay.Enabled = false;
                                btnPlayAgain.Enabled = true;
                            }
                            break;
                    }
                }
                // display the amount of cards in the deck
                lblDeckTotal.Text = "The deck has " + newDeck.Count() + " cards left in it";
            }
            else
            {
                // call the function 
                shuffle();
                dealFirst4();
            }

            // show the totals
            lblPlayerTotal.Text = Convert.ToString(playerTotal);
            lblDealerTotal.Text = Convert.ToString(dealerTotal);

            // enable the  hit and stay button
            btnHit.Enabled = true;
            btnStay.Enabled = true;
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // close the game
            this.Close();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            // convert the bet to an interger
            bet = Convert.ToInt32(txtBet.Text);

            // check if they bet an amount = to or < then the amount of money they have
            if (bet <= money)
            {
                // disable the betting and enable the hit and stay buttons
                btnBet.Enabled = false;
                btnStay.Enabled = true;
                btnHit.Enabled = true;

                dealFirst4();
            }

            else
            {
                // tell the user that that's an invaild bet
                MessageBox.Show("That's an invaild bet");
            }
        }

        private void btnBet_MouseHover(object sender, EventArgs e)
        {
            // ask the user if they are sure about their bet when they hover over the bet
            btnBet.Text = "Are you sure";
        }

        private void btnBet_MouseLeave(object sender, EventArgs e)
        {
            btnBet.Text = "Confirm Bet";
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            if (newDeck.Count() > 1)
            {
                // pass the dealer total's value to a function to display it
                displaySecretCard(dealerTotal);

                lblDealerTotal.Text = Convert.ToString(dealerTotal);
                btnHit.Enabled = false;
                btnStay.Enabled = false;
                dealerPlay();
            }

            else
            {
                // pass the dealer total's value to a function to display it
                displaySecretCard(dealerTotal);

                btnHit.Enabled = false;
                btnStay.Enabled = false;
                shuffle();
                dealerPlay();
            }

            // call the function to compare the totals
            compare();

            // enable the play again button
            btnPlayAgain.Enabled = true;

        }

        private void displaySecretCard(int total)
        {
            // display the face down card
            this.picDCard2.Image = secretCard;
            dealerTotal += faceDownCard;
            counter = 0;
            lblDealerTotal.Text = Convert.ToString(total);

            // check if they have an ace
            if (faceDownCard == 11)
            {
                dealerHasAnAce = true;
            }

        }

        private void dealerPlay()
        {
            // check if the dealer has less then 17
            while (dealerTotal < 17)
            {
                // set the cards left progress bar
                if (newDeck.Count < 50)
                {
                    this.prbCardsLeft.Value = newDeck.Count * 2 - 4;
                }
                else
                {
                    this.prbCardsLeft.Value = newDeck.Count * 2;
                }
                // display the next card 
                switch (counter)
                {
                    case 0:
                        cardNumber = randomNumberGenerator.Next(0, newDeck.Count());
                        this.picDCard3.Image = Image.FromFile(@"Cards/" + newDeck[cardNumber] + ".jpg");
                        picDCard3.Visible = true;
                        turnOverDCard();
                        break;
                    case 1:
                        cardNumber = randomNumberGenerator.Next(0, newDeck.Count());
                        this.picDCard4.Image = Image.FromFile(@"Cards/" + newDeck[cardNumber] + ".jpg");
                        turnOverDCard();
                        picDCard4.Visible = true;
                        break;
                    case 2:
                        cardNumber = randomNumberGenerator.Next(0, newDeck.Count());
                        this.picDCard5.Image = Image.FromFile(@"Cards/" + newDeck[cardNumber] + ".jpg");
                        picDCard5.Visible = true;
                        turnOverDCard();
                        break;
                    case 3:
                        cardNumber = randomNumberGenerator.Next(0, newDeck.Count());
                        this.picDCard6.Image = Image.FromFile(@"Cards/" + newDeck[cardNumber] + ".jpg");
                        picDCard6.Visible = true;
                        turnOverDCard();
                        break;
                }
            }
        }

        private void compare()
        {
            if (playerTotal < 22)
            {
                if (dealerTotal < 22)
                {
                    if (playerTotal > dealerTotal)
                    {
                        // tell the user the results
                        MessageBox.Show("You won!");
                        money = money + bet;
                        lblMoney.Text = "You have " + money + "$";
                        // disable everything 
                        btnHit.Enabled = false;
                        btnStay.Enabled = false;
                    }

                    else if (playerTotal < dealerTotal)
                    {
                        // tell the user the results
                        MessageBox.Show("You lost!");
                        money = money - bet;
                        lblMoney.Text = "You have " + money + "$";
                        // disable everything 
                        btnHit.Enabled = false;
                        btnStay.Enabled = false;
                    }

                    else if (playerTotal == dealerTotal)
                    {
                        // tell the user the results
                        MessageBox.Show("You tied!");
                        // disable everything 
                        btnHit.Enabled = false;
                        btnStay.Enabled = false;
                    }
                }
            }
        }

        private void turnOverDCard()
        {
            // remove the card from the deck, add its value to the total, and display it
            newDeck.RemoveAt(cardNumber);
            dealerTotal += deckValues[cardNumber];

            if (deckValues[cardNumber] == 11)
            {
                dealerHasAnAce = true;
            }

            deckValues.RemoveAt(cardNumber);
            lblDealerTotal.Text = Convert.ToString(dealerTotal);
            counter++;
            if (dealerTotal > 21)
            {

                if (dealerHasAnAce == true)
                {
                    dealerTotal -= 10;
                    dealerHasAnAce = false;
                }

                if (dealerTotal > 21)
                {
                    // tell the user the results
                    MessageBox.Show("The dealer busted!");
                    money = money + bet;
                    lblMoney.Text = "You have " + money + "$";
                }
            }
        }

        private void mniNewGame_Click(object sender, EventArgs e)
        {
            start();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            // enable the betting
            txtBet.Enabled = true;
            btnBet.Enabled = true;

            // disable the play again button
            btnPlayAgain.Enabled = false;

            // hide the pictures
            picCard1.Visible = false;
            picCard2.Visible = false;
            picCard3.Visible = false;
            picCard4.Visible = false;
            picCard5.Visible = false;
            picCard6.Visible = false;

            picDCard1.Visible = false;
            picDCard2.Visible = false;
            picDCard3.Visible = false;
            picDCard4.Visible = false;
            picDCard5.Visible = false;
            picDCard6.Visible = false;

            // reset the totals
            playerTotal = 0;
            dealerTotal = 0;
        }

        private void txtBet_TextChanged(object sender, EventArgs e)
        {
            // check if they entered an invaild character and if they did tell them that its ivaild and then delete it
            string text;
            text = txtBet.Text;
            txtBet.Text = Regex.Match(txtBet.Text, @"\d+").Value;
            if (text != txtBet.Text)
            {
                MessageBox.Show("That's not a vaild number");
            }
            txtBet.Select(txtBet.Text.Length, 0);
        }
    }
}