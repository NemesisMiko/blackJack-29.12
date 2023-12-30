using System;
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
        bool isFirstHandActive = false;
        int hold1 = 0;




        private void RestartGame()
        {
            // Clear card lists
            lst_dealer.Items.Clear();
            lst_player.Items.Clear();
            lst_split.Items.Clear();
            lst_split_display.Items.Clear();

            // Reset total points and bet amount
            playerTotalPoints2 = 0;
            dealerTotalPoints = 0;
            playerTotalPoints = 0;
            dealerTotalPoints = 0;
            betAmount = 0;
            chips = 0;
            betAmount = 0;
            hold1 = 0;
            isFirstHandActive= false;

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
            btn_hit.Enabled = true;
            btn_stand.Hide();
            btn_stand.Enabled = true;
            btn_split.Hide();
            btn_split.Enabled = true;
            lst_split.Hide();
            lst_split.Items.Clear();
            lbl_player_hand_2.Hide();         
            lbl_player_points_2.Hide();
            lst_split.Hide();
            lst_split.Items.Clear();
            lst_split_display.Hide();
            lst_split_display.Items.Clear();
            isFirstHandActive = false;


            lbl_player_hand_1.Location = new System.Drawing.Point(391, 153);
            lbl_player_points_1.Location = new System.Drawing.Point(693, 153);
            lst_display.Location = new System.Drawing.Point(681, 177);
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
            lst_player.Items.Clear();
            lst_display.Items.Clear();
            lst_dealer.Items.Clear();
            lst_dealer_display.Items.Clear();


            if (total <= 0)
            {
                MessageBox.Show("Game over! You're out of chips.");
                Close(); // Close the application
            }
        }



        //private void UpdatePointsForHand(ListBox hand, ListBox pointsDisplay, ref int totalPoints, Karta card)
        //{
        //    string cardValue = card.Ime.Split(' ')[0];
        //    Vrednosti value = (Vrednosti)Enum.Parse(typeof(Vrednosti), cardValue);

        //    // Update total points for the hand
        //    totalPoints += (value == Vrednosti.As && totalPoints + 11 > 21) ? 1 : (value == Vrednosti.Janez) ? 10 : (int)value;

        //    // Display the updated points
        //    pointsDisplay.Items.Clear();
        //    pointsDisplay.Items.Add($"Points: {totalPoints}");

        //    // Add the drawn card to the hand
        //    hand.Items.Add(card.Ime);
        //}
        private void button1_Click(object sender, EventArgs e)//hit
        {
            ListBox currentHand = (lst_player.Items.Count > 0 && lst_split.Items.Count == 1) ? lst_player : lst_split;
            int currentTotalPoints = CalculateHandPoints(currentHand);

            //List<Karta> card1 = igranje.DealHand();
            betAmount = chips;
            Karta card = igranje.DrawCard();
            if (lbl_player_hand_2.Visible == false)
            {
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
                        //playerTotalPoints += card.Value;
                        playerTotalPoints = CalculateHandPoints(lst_player);
                        ////lst_display.Items.Add($"Points: {playerTotalPoints}");
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

                    if (playerTotalPoints >= 21 || playerTotalPoints >= 21)
                    {

                        if (playerTotalPoints == 21)
                        {

                            // Player wins, add double the bet to total chips
                            total += 2 * betAmount;

                            // Update the total chips display
                            txt_curent.Text = total.ToString();
                            MessageBox.Show("Blackjack! You win!");
                            if (lst_split.Visible == false)
                                RestartGame();
                        }
                        else
                        {
                            MessageBox.Show("Bust! You lose!");
                            if (lst_split.Visible == false)
                                RestartGame();
                        }
                    }
                }
            }
            if (lbl_player_hand_2.Visible == true )
            {
                playerTotalPoints = CalculateHandPoints(lst_player);

                if (playerTotalPoints < 21 && isFirstHandActive==false)
                {

                    lst_player.Items.Add(card.Ime);
                    if (card.Vrednost == Vrednosti.As && playerTotalPoints + card.Value > 21)
                    {
                        // If adding 11 points for an Ace would result in a bust, use 1 point instead
                        playerTotalPoints += 1;
                    }
                    else
                    {
                        //playerTotalPoints += card.Value;
                        playerTotalPoints = CalculateHandPoints(lst_player);
                        ////lst_display.Items.Add($"Points: {playerTotalPoints}");
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

                    if (playerTotalPoints >= 21 || playerTotalPoints >= 21)
                    {

                        if (playerTotalPoints == 21)
                        {

                            // Player wins, add double the bet to total chips
                            total += 2 * betAmount;

                            // Update the total chips display
                            txt_curent.Text = total.ToString();
                            MessageBox.Show("Blackjack! You win!");
                            if (lst_split.Visible == false)
                                RestartGame();
                        }
                        else
                        {
                            MessageBox.Show("Bust! You lose!");
                            if (lst_split.Visible == false)
                                RestartGame();
                        }
                    }
                }
                else
                {
                    playerTotalPoints2 = CalculateHandPoints(lst_split);
                    if (playerTotalPoints2 < 21 || isFirstHandActive == true)
                    {
                        lst_split.Items.Add(card.Ime);
                        hold1 = 1;
                        if (card.Vrednost == Vrednosti.As && playerTotalPoints2 + card.Value > 21)
                        {
                            // If adding 11 points for an Ace would result in a bust, use 1 point instead
                            playerTotalPoints2 += 1;
                        }
                        else
                        {
                            //playerTotalPoints += card.Value;
                            playerTotalPoints2 = CalculateHandPoints(lst_split);
                            //lst_display.Items.Add($"Points: {playerTotalPoints}");
                        }

                        lst_split_display.Items.Add($"Points: {playerTotalPoints2}");


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

                        if (playerTotalPoints2 >= 21 || playerTotalPoints2 >= 21)
                        {
                            btn_hit.Enabled = false;
                            if (playerTotalPoints2 == 21)
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


                }
            }           
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
                    if (dealerTotalPoints == 21)
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
                if (total >= chips + 1)
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
            
            //__________________________________

            //while (dealerTotalPoints < playerTotalPoints  && dealerTotalPoints <= 17)
            //{
            //    Karta card = igranje.DrawCard();
            //    lst_dealer.Items.Add(card.Ime);

            //    if (card.Vrednost == Vrednosti.As && dealerTotalPoints + card.Value > 21)
            //    {
            //        // If adding 11 points for an Ace would result in a bust, use 1 point instead
            //        dealerTotalPoints += 1;
            //    }
            //    else
            //    {
            //        dealerTotalPoints += card.Value;
            //    }
            //    lst_dealer_display.Items.Add($"Points: {dealerTotalPoints}");
            //}

            if (lbl_player_hand_2.Visible == false)
            {
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
                btn_hit.Enabled = false;
                btn_split.Enabled = false;
                btn_stand.Enabled = false;

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
            if (lbl_player_hand_2.Visible == true )
            {
                
                playerTotalPoints = CalculateHandPoints(lst_player);
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

                if (playerTotalPoints < 21 || isFirstHandActive == false)
                {
                    isFirstHandActive = true;
                    

                    if (playerTotalPoints > 21 || (dealerTotalPoints <= 21 && dealerTotalPoints > playerTotalPoints && hold1 == 0))
                    {
                        MessageBox.Show("Bust! You lose!");
                        //_________________________________________________________________________________

                        //_________________________________________________________________________________
                    }
                    else if (dealerTotalPoints > 21 || playerTotalPoints == 21 || (playerTotalPoints <= 21 && playerTotalPoints > dealerTotalPoints  && hold1 == 0))
                    {
                        total +=  betAmount; // Player wins, add double the bet to total chips
                        txt_curent.Text = total.ToString();
                        MessageBox.Show("Congratulations! You win!");
                        //_____________________________________________________________________
                        //______________________________________________________________________
                    }
                    else
                    {
                        if (hold1 == 0)
                        {
                            MessageBox.Show("It's a tie!");
                        }
                        //______________________________________________________________________
                        //______________________________________________________________________
                    }

                    if (playerTotalPoints <= 21 && playerTotalPoints > dealerTotalPoints)
                    {
                        // Player wins, add double the bet to total chips
                        total +=  betAmount;
                        //RestartGame();
                        //_______________________________________________________________________________
                        //_______________________________________________________________________________
                    }
                    //else
                        //RestartGame();
                    //_____________________________________________________________________________________
                    //______________________________________________________________________________________
                    //_empty_
                }
                if(isFirstHandActive == true && hold1 == 1)
                {
                    while (dealerTotalPoints < playerTotalPoints2 && dealerTotalPoints <= 17)
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
                    //MessageBox.Show("drugi hold");
                    isFirstHandActive = false;
                    btn_hit.Enabled = true;
                    btn_split.Enabled = false;
                    btn_stand.Enabled = true;
                    playerTotalPoints2 = CalculateHandPoints(lst_split);
                    if (playerTotalPoints2 < 21)
                        if (playerTotalPoints2 > 21 || (dealerTotalPoints <= 21 && dealerTotalPoints > playerTotalPoints2))
                        {
                            MessageBox.Show("Bust! You lose!");
                            RestartGame();
                            //_________________________________________________________________________________

                            //_________________________________________________________________________________
                        }
                        else if (dealerTotalPoints > 21 || playerTotalPoints2 == 21 || (playerTotalPoints2 <= 21 && playerTotalPoints2 > dealerTotalPoints))
                        {
                            total +=  betAmount; // Player wins, add double the bet to total chips
                            txt_curent.Text = total.ToString();
                            MessageBox.Show("Congratulations! You win!");
                            RestartGame();
                            //_____________________________________________________________________
                            //______________________________________________________________________
                        }
                        else
                        {
                            MessageBox.Show("It's a tie!");
                            RestartGame();
                            //______________________________________________________________________
                            //______________________________________________________________________
                        }

                    if (playerTotalPoints2 <= 21 && playerTotalPoints2 > dealerTotalPoints)
                    {
                        // Player wins, add double the bet to total chips
                        total +=  betAmount;
                        RestartGame();
                        //_______________________________________________________________________________
                        //_______________________________________________________________________________
                    }
                    else
                        RestartGame();
                    //_____________________________________________________________________________________
                    //______________________________________________________________________________________
                    //_empty_

                }

            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            chips = 0;
            txt_chips.Text = null;
        }

        private void btn_split_Click(object sender, EventArgs e)
        {
            //listboxes

            if (total >= betAmount  )
            { 





                if (lst_player.Items.Count == 2 && lst_split.Items.Count == 0)
                {
                    // Get the values of the two cards
                    string card1Value1 = lst_player.Items[0].ToString().Split(' ')[0];
                    string card2Value1 = lst_player.Items[1].ToString().Split(' ')[0];

                    // Check if the two cards have the same value
                    if (card1Value1 == card2Value1)
                    {

                        lst_split.Show();
                        lst_split_display.Show();
                        lst_player.Location = new System.Drawing.Point(300, 177);
                        lst_split.Location = new System.Drawing.Point(450, 177);
                        lst_display.Location = new System.Drawing.Point(610, 177);
                        lst_split_display.Location = new System.Drawing.Point(740, 177);

                        //labels 
                        lbl_player_hand_2.Show();
                        lbl_player_points_2.Show();
                        lbl_player_hand_1.Location = new System.Drawing.Point(320, 153);
                        lbl_player_hand_2.Location = new System.Drawing.Point(462, 153);
                        lbl_player_points_1.Location = new System.Drawing.Point(625, 153);
                        lbl_player_points_2.Location = new System.Drawing.Point(748, 153);
                        // Get the values of the two cards
                        string card1Value = lst_player.Items[0].ToString().Split(' ')[0];
                        string card2Value = lst_player.Items[1].ToString().Split(' ')[0];

                        //playerTotalPoints = int.Parse(card1Value);
                        //playerTotalPoints2= int.Parse(card2Value);
                        lst_display.Items.Add($"Points: {playerTotalPoints}");
                        //lst_dealer_display.Items.Add($"Points: {playerTotalPoints2}");
                        // Check if the two cards have the same value
                        if (card1Value != null) //card1Value == card2Value/*
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
                    MessageBox.Show("You can only split when the two cards have the same value.");
                }
            }
                else
                {
                    MessageBox.Show("You can only split at the start of the game with two cards.");
                }
            }
            else
            {
                MessageBox.Show("Not enough chips for the split!");
            }

        }
        private void SplitCards()
        {
            

            total -= betAmount;

                txt_curent.Text = total.ToString();
                txt_chips.Text = "2 x"+(betAmount).ToString();
                lst_split.Items.Add(lst_player.Items[1]);
                lst_player.Items.RemoveAt(1);

                lst_display.Items.Clear();
                //lst_dealer_display.Items.Clear();



                int playerTotalPoints1 = CalculateHandPoints(lst_player);
                lst_display.Items.Add($"Points: {playerTotalPoints1}");

                int playerTotalPoints2 = CalculateHandPoints(lst_split);
                lst_split_display.Items.Add($"Points: {playerTotalPoints2}");







            
        }
        private int CalculateHandPoints(ListBox hand)
        {
            int totalPoints = 0;

            foreach (var item in hand.Items)
            {
                string cardValue = item.ToString().Split(' ')[0];
                Vrednosti value = (Vrednosti)Enum.Parse(typeof(Vrednosti), cardValue);

                // Update total points for each card in the hand
                totalPoints += (value == Vrednosti.As && totalPoints + 11 > 21) ? 1 : (value == Vrednosti.Janez) ? 10 : (value == Vrednosti.Dama) ? 10 : (value == Vrednosti.Kralj) ? 10 : (int)value;

            }


            return totalPoints;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
