﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Igranje igranje;
        public Form1()
        {
            InitializeComponent();
            txt_curent.Text = total + "";
            txt_chips.SelectionAlignment = HorizontalAlignment.Center;
            txt_curent.SelectionAlignment = HorizontalAlignment.Center;
            
            txt_curent.SelectionAlignment = HorizontalAlignment.Center;
            igranje = new Igranje();
        }
        int chips = 0;
        int betAmount = 0;
        int total = 500;
        int skupi = 0;
        int playerTotalPoints = 0;
        int playerTotalPoints2 = 0;
        int dealerTotalPoints = 0;




        private void RestartGame()
        {
            // Clear card lists
            lst_dealer.Items.Clear();
            lst_player.Items.Clear();
            lst_split.Items.Clear();
            lst_split_display.Items.Clear();

            // Reset total points and bet amount
            playerTotalPoints = 0;
            dealerTotalPoints = 0;
            betAmount = 0;
            chips= 0;
            betAmount= 0;

            // Enable buttons for a new game
            btn_1.Show();
            btn_5.Show();
            btn_10.Show();
            btn_25.Show();
            btn_50.Show();
            btn_100.Show();
            btn_allIn.Show();
            btn_deal.Show();
            btn_clear.Show();
            btn_hit.Hide();
            btn_hit.Enabled= true;
            btn_stand.Hide();
            btn_stand.Enabled= true;
            btn_split.Hide();
            btn_split.Enabled= true;
            lst_split.Hide();
            lbl_player_hand_2.Hide();
            lbl_player_points_2.Hide();
            lst_split.Hide();
            lst_split_display.Hide();
            

            lbl_player_hand_1.Location= new System.Drawing.Point(405, 153);
            lbl_player_points_1.Location= new System.Drawing.Point(710, 153);
            lst_display.Location= new System.Drawing.Point(681, 177);
            lst_player.Location = new System.Drawing.Point(376, 177);

            // Enable bet buttons
            btn_1.Enabled = true;
            btn_5.Enabled = true;
            btn_10.Enabled = true;
            btn_25.Enabled = true;
            btn_50.Enabled = true;
            btn_100.Enabled = true;

            // Clear the display
            txt_chips.Clear();
            lst_display.Items.Clear();
            lst_dealer_display.Items.Clear();
            

            if (total <= 0)
            {
                MessageBox.Show("Game over! You're out of chips.");
                Close(); // Close the application
            }
        }




        private void button1_Click(object sender, EventArgs e)//hit
        {

            //List<Karta> card1 = igranje.DealHand();
            betAmount = chips;
            Karta card = igranje.DrawCard();
            if (card.Value < 21)
            {
                lst_player.Items.Add(card.Ime);
                if (card.Vrednost == Vrednosti.As && playerTotalPoints + card.Value > 21)
                {
                    // If adding 11 points for an Ace would result in a bust, use 1 point instead
                    playerTotalPoints += 1;
                }
                else
                {
                    playerTotalPoints += card.Value;
                }

                lst_display.Items.Add($"Points: {playerTotalPoints}");


                //if (playerTotalPoints < 21)
                //{
                //    lst_player.Items.Add(igranje.DrawCard());
                //    playerTotalPoints += 
                //}
                //foreach (var card in card1)
                //{
                //    lst_player.Items.Add(card.Ime);
                //    playerTotalPoints += card.Value; // Update total points for each new card
                //}
                //txt_curent.Text = playerTotalPoints.ToString();

                if (playerTotalPoints >= 21)
                {
                    btn_hit.Enabled = false;
                    if (playerTotalPoints == 21)
                    {
                        
                        // Player wins, add double the bet to total chips
                        total += 2 * betAmount;

                        // Update the total chips display
                        txt_curent.Text = total.ToString();
                        MessageBox.Show("Blackjack! You win!");
                        RestartGame();
                    }
                    else
                    {
                        MessageBox.Show("Bust! You lose!");
                        RestartGame();
                    }
                }


            }

                //lst_player.Items.Add(han.Ime);

        }

        private void button13_Click(object sender, EventArgs e)//deal
        {
            betAmount = chips;
            if (txt_chips.Text != string.Empty)
            {
                total -= betAmount;
                txt_curent.Text = total.ToString();
                btn_1.Hide();
                btn_5.Hide();
                btn_10.Hide();
                btn_25.Hide();
                btn_50.Hide();
                btn_100.Hide();
                btn_allIn.Hide();
                btn_deal.Hide();
                btn_clear.Hide();
                btn_hit.Show();
                btn_split.Show();
                btn_stand.Show();

                


                lst_dealer.Items.Clear();
                lst_player.Items.Clear();
                //igranje.Mešaj();
                //igranje.Deli();
                //igranje = new Igranje();
                List<Karta> card1 = igranje.DealHand();
                

                foreach (var hand in card1)
                {
                    lst_dealer.Items.Add(hand.Ime);
                    dealerTotalPoints += hand.Value;
                }
                List<Karta> card2 = igranje.DealHand();
                
                foreach (var hand in card2)
                {
                   
                    lst_player.Items.Add(hand.Ime);
                    playerTotalPoints += hand.Value;
                    if (playerTotalPoints == 21)
                    {
                        total += 2 * betAmount;

                        // Update the total chips display
                        txt_curent.Text = total.ToString();
                        MessageBox.Show("Blackjack! You win!");
                        RestartGame();
                    }
                    if(dealerTotalPoints == 21)
                    {
                        MessageBox.Show("Dealer hit Blackjack! You lose!");
                        RestartGame();
                    }
                }
                
                lst_display.Items.Add($"Points: {playerTotalPoints}");
                lst_dealer_display.Items.Add($"Points: {dealerTotalPoints}");




            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {

            if (total >= 1)
            {
                if(total >= chips +1)
                { 
                chips += 1;
                txt_chips.Text = chips + "";
                }
            }

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (total >= 5)
            {
                if (total >= chips + 5)
                {
                    chips += 5;
                    txt_chips.Text = chips + "";
                }
            }
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            if (total >= 10)
            {
                if (total >= chips + 10)
                {
                    chips += 10;
                    txt_chips.Text = chips + "";
                }
            }
        }

        private void btn_25_Click(object sender, EventArgs e)
        {
            if (total >= 25)
            {
                if (total >= chips + 25)
                {
                    chips += 25;
                    txt_chips.Text = chips + "";
                }
            }
        }

        private void btn_50_Click(object sender, EventArgs e)
        {
            if (total >= 50)
            {
                if (total >= chips + 50)
                {
                    chips += 50;
                    txt_chips.Text = chips + "";
                }
            }
        }

        private void btn_100_Click(object sender, EventArgs e)
        {

            if (total >= 100)
            {
                if (total >= chips + 100)
                {
                    chips += 100;
                    txt_chips.Text = chips + "";
                }
            }
        }

        private void btn_allIn_Click(object sender, EventArgs e)
        {
            chips = total;
            txt_chips.Text = total + "";
            
        }

        private void txt_curent_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_stand_Click(object sender, EventArgs e)
        {
            betAmount = chips;
            btn_hit.Enabled = false;
            btn_split.Enabled = false;
            btn_stand.Enabled = false;
            //__________________________________
            
                while (dealerTotalPoints < playerTotalPoints && dealerTotalPoints <= 17)
                {
                    Karta card = igranje.DrawCard();
                    lst_dealer.Items.Add(card.Ime);
                    
                    if (card.Vrednost == Vrednosti.As && dealerTotalPoints + card.Value > 21)
                    {
                        // If adding 11 points for an Ace would result in a bust, use 1 point instead
                        dealerTotalPoints += 1;
                    }
                    else
                    {
                        dealerTotalPoints += card.Value;
                    }
                lst_dealer_display.Items.Add($"Points: {dealerTotalPoints}");
            }
            


            if (playerTotalPoints > 21 || (dealerTotalPoints <= 21 && dealerTotalPoints > playerTotalPoints))
            {
                MessageBox.Show("Bust! You lose!");
            }
            else if (dealerTotalPoints > 21 || playerTotalPoints == 21 || (playerTotalPoints <= 21 && playerTotalPoints > dealerTotalPoints))
            {
                total += 2 * betAmount; // Player wins, add double the bet to total chips
                txt_curent.Text = total.ToString();
                MessageBox.Show("Congratulations! You win!");
            }
            else
            {
                MessageBox.Show("It's a tie!");
            }
            //__________________________________




            //int randomCard = selectRandomCard();
            //Card card = deck[randomCard];
            //usedCards.Add(randomCard);

            //if (usedCards.Contains(randomCard)) randomCard = selectRandomCard();
            //else randomCard = 1 * randomCard;



            if (playerTotalPoints <= 21 && playerTotalPoints > dealerTotalPoints)
            {
                // Player wins, add double the bet to total chips
                total += 2 * betAmount;
                RestartGame();
            }
            else
                RestartGame();

            // Update the total chips display
            txt_curent.Text = total.ToString();
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            chips= 0;
            txt_chips.Text = null;
        }

        private void btn_split_Click(object sender, EventArgs e)
        {
            //listboxes

            lst_split.Show();
            lst_split_display.Show();
            lst_player.Location = new System.Drawing.Point(300, 177);
            lst_split.Location = new System.Drawing.Point(450, 177);
            lst_display.Location = new System.Drawing.Point(610, 177);
            lst_split_display.Location = new System.Drawing.Point(740, 177);

            //labels 
            lbl_player_hand_2.Show();
            lbl_player_points_2.Show();
            lbl_player_hand_1.Location = new System.Drawing.Point(330, 153);
            lbl_player_hand_2.Location = new System.Drawing.Point(475, 153);
            lbl_player_points_1.Location = new System.Drawing.Point(640, 153);
            lbl_player_points_2.Location = new System.Drawing.Point(765, 153);




            if (lst_player.Items.Count == 2 && lst_split.Items.Count == 0)
            {
                // Get the values of the two cards
                string card1Value = lst_player.Items[0].ToString().Split(' ')[0];
                string card2Value = lst_player.Items[1].ToString().Split(' ')[0];


                lst_display.Items.Add($"Points: {playerTotalPoints}");
                lst_dealer_display.Items.Add($"Points: {playerTotalPoints2}");
                // Check if the two cards have the same value
                if (card1Value!=null) //card1Value == card2Value/*
                {
                    // Perform Split
                    SplitCards();

                    // Update UI or perform any other actions

                    // Disable the Split button after a successful split
                    btn_split.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You can only split when the two cards have the same value.");
                }
            }
            else
            {
                MessageBox.Show("You can only split at the start of the game with two cards.");
            }

        }
        private void SplitCards()
        {
            if (total >= betAmount * 2)
            {
                // Create a new list to represent the split hand
                lst_split.Items.Add(lst_player.Items[1]);
                lst_player.Items.RemoveAt(1);

                lst_display.Items.Clear();
                lst_dealer_display.Items.Clear();

                Karta card = igranje.DrawCard();
                

                lst_display.Items.Add($"Points: {playerTotalPoints}");
                lst_dealer_display.Items.Add($"Points: {playerTotalPoints2}");

                


                

                //List<string> splitHand = new List<string>
                //    {
                //        lst_player.Items[1].ToString()
                //    };
                ////

                ////foreach (var hand in card2)
                ////{
                ////    lst_player.Items.Add(hand.Ime);
                ////    playerTotalPoints += hand.Value;
                ////}
                ////

                //    // Remove the second card from the original hand
                //lst_player.Items.RemoveAt(1);




                //// Display the split hand in the split list box
                //lst_split.Items.AddRange(splitHand.ToArray());




                //lst_display.Items.Clear();
                //lst_display.Items.Add($"Points: {playerTotalPoints}");
                //lst_split_display.Items.Add($"Points: {playerTotalPoints }");

                // Deduct chips for the split
                //total -= chips;
                //txt_curent.Text = total.ToString();

                //// Show the split hand
                //lst_split.Items.Add(lst_player.Items[1]);
                //lst_player.Items.RemoveAt(1);

                //// Calculate points for each hand
                //playerTotalPoints = lst_player.Items.Cast<Karta>().Sum(card => card.Value);
                //int splitHandPoints = lst_split.Items.Cast<Karta>().Sum(card => card.Value);

                //lst_display.Items.Clear();
                //lst_dealer_display.Items.Clear();

                //lst_display.Items.Add($"Points: {playerTotalPoints}");
                //lst_dealer_display.Items.Add($"Points: {splitHandPoints}");

                //// Disable split button after splitting
                //btn_split.Enabled = false;

                //// Enable buttons for the first hand
                //btn_hit.Enabled = true;
                //btn_stand.Enabled = true;
            }
            else
            {
                MessageBox.Show("Not enough chips for the split!");
            }
        
        //_____________________________________________________________

        //_______________________________________________________________
    }
    }
}