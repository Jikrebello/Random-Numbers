using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Random random = new Random();

        /*1. Suppose two players are playing a game in which each one moves his/her chip a certain number of times, depending on
        where the dial stops on a spinner.The dial may stop at any number from 1 to 9 inclusive.
        Write a program that determines which player made the greatest number of moves after each one had 10 plays.
        a) Use a for/next loop to control the number of plays
        b) Generate a random number from 1 to 9 for the first player.This represents the number of moves he/she can
        make.Immediately following this statement, accumulate the player's moves.
        c) Do the same for the second player.
        d) After 10 plays, find the winner by comparing the accumulated moves of the two players.
        e) Print the winner as show in the sample run.
        PLAYER 1 IS THE WINNER
        WITH A TOTAL OF 52 MOVES*/
        private void button1_Click(object sender, EventArgs e)
        {
            int player1Score = 0;
            int player2Score = 0;

            // Total player 1's score
            for (int i = 0; i < 10; i++)
            {
                player1Score += random.Next(1, 10);
            }

            // Total player 2's score
            for (int i = 0; i < 10; i++)
            {
                player2Score += random.Next(1, 10);
            }

            if (player1Score > player2Score)
            {
                MessageBox.Show("Player 1 is the winner with a total of " + player1Score + " moves" + Environment.NewLine + "Player 2 got " + player2Score);
            }
            else if (player1Score < player2Score)
            {
                MessageBox.Show("Player 2 is the winner with a total of " + player2Score + " moves" + Environment.NewLine + "Player 1 got " + player1Score);
            }
            else
            {
                MessageBox.Show("Both players got the same amount of moves with player 1 getting " + player1Score + Environment.NewLine + "Player 2 getting " + player2Score);
            }
        }


        /*2. Write a program which determines how many times a toss of 100 coins contains 47 heads if the experiment is
        performed 50 times.Your output should have the following form.
        IN 50 EXPERIMENTS
        THERE WERE 7 OCCURRENCES
        OF 47 HEADS OUT OF 100 */
        private void button2_Click(object sender, EventArgs e)
        {
            int counterFor47 = 0;

            for (int i = 0; i < 50; i++)
            {
                int heads = 0;
                int tails = 0;

                for (int j = 0; j < 100; j++)
                {
                    if (random.Next(1, 3) == 1)
                    {
                        heads++;
                    }
                    else
                    {
                        tails++;
                    }
                }
                if (heads == 47)
                    counterFor47++;
            }

            MessageBox.Show("In 50 experiments there were " + counterFor47 + " occurrences of 47 heads out of 100");

        }


        /*3. A gambler has a choice of two games.The first costs $8.00 to play. Two dice are rolled and the player receive the sum
        of the numbers rolled in dollars.The second game costs $15.00 to play. Two dice are rolled and the player receives the
        product of the numbers rolled in dollars. Write a program which simulates each game being played 1000 times and
        calculates the average winnings per game. Also determine which game the gambler should choose.*/
        private void button3_Click(object sender, EventArgs e)
        {
            double firstGameTotal = 0;
            int firstGameBuyIn = 8;
            double secondGameTotal = 0;
            int secondGameBuyIn = 15;
            int roll;
            double firstGameAverage;
            double secondGameAverage;
            const int NUMBER_OF_GAMES = 1000;

            for (int i = 0; i < NUMBER_OF_GAMES; i++)
            {
                firstGameTotal -= firstGameBuyIn;
                roll = random.Next(1, 7) + random.Next(1, 7);
                firstGameTotal += roll;

                secondGameTotal -= secondGameBuyIn;
                roll = random.Next(1, 7) * random.Next(1, 7);
                secondGameTotal += roll;
            }

            firstGameAverage = firstGameTotal / NUMBER_OF_GAMES;
            secondGameAverage = secondGameTotal / NUMBER_OF_GAMES;

            MessageBox.Show("The average winnings for game 1 is " + firstGameAverage.ToString("c") + Environment.NewLine + "The average winnings for game 2 is " + secondGameAverage.ToString("c"));
        }


    }
}
