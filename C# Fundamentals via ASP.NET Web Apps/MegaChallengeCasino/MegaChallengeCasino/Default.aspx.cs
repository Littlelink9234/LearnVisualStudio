using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeCasino
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Display the Reel values
                string[] reels = new string[] { spinReel(), spinReel(), spinReel() };
                displayImages(reels);
                ViewState.Add("PlayersMoney", 100);
                displayPlayersMoney();                
            }            
        }       

        protected void LeverButton_Click(object sender, EventArgs e)
        {
            int bet = 0;
            if (!int.TryParse(BetTextBox.Text, out bet)) return;
            int winnings = pullLever(bet);
            displayWinnings(bet, winnings);
            adjustPlayersMoney(bet, winnings);
            displayPlayersMoney();
        }

        private void adjustPlayersMoney(int bet, int winnings)
        {
            int playersMoney = int.Parse(ViewState["PlayersMoney"].ToString());
            playersMoney -= bet;
            playersMoney += winnings;
            ViewState["PlayersMoney"] = playersMoney;
        }       

        private int pullLever(int bet)
        {
            string[] images = new string[] { spinReel(), spinReel(), spinReel() };
            displayImages(images);

            int multiplier = evaluateSpin(images);
            return bet * multiplier;
        }

        private string spinReel()
        {
            string[] images = new string[] { "Strawberry", "Bar", "Lemon", "Bell", "Clover", "Cherry", "Diamond", "Orange", "Seven", "HorseShoe", "Plum", "Watermelon" };
            return images[random.Next(11)];
            //displayImages(images);

        }

        private int evaluateSpin(string[] images)
        {            
            if (isBar(images)) return 0;
            if (isJackpot(images)) return 100;
            int multiplier = 0;
            if (isWinner(images, out multiplier)) return multiplier;
            return 0;
        }

        private bool isWinner(string[] images, out int multiplier)
        {
            multiplier = determineMultiplier(images);
            if (multiplier > 0)
                return true;
            else
                return false;
            
        }

        private int determineMultiplier(string[] images)
        {
            int cherryCount = determineCherryCount(images);
            
            if (cherryCount == 1) return 2;
            if (cherryCount == 2) return 3;
            if (cherryCount == 2) return 4;
            return 0;
        }

        private int determineCherryCount(string[] images)
        {
            int cherryCount = 0;
            if (images[0] == "Cherry") cherryCount++;
            if (images[1] == "Cherry") cherryCount++;
            if (images[2] == "Cherry") cherryCount++;

            return cherryCount;
        }

        private bool isJackpot(string[] images)
        {
            if (images[0] == "Seven" && images[1] == "Seven" && images[2] == "Seven")
                return true;
            else
                return false;
        }

        private bool isBar(string[] images)
        {
            if (images[0] == "Bar" || images[1] == "Bar" || images[2] == "Bar")
                return true;
            else
                return false;
        }

        private void displayImages(string[] reels)
        {
            LeftImage.ImageUrl = "~/images/" + reels[0] + ".png";
            MiddleImage.ImageUrl = "~/images/" + reels[1]+ ".png";
            RightImage.ImageUrl = "~/images/" + reels[2]+ ".png";
        }

        private void displayPlayersMoney()
        {
            moneyLabel.Text = String.Format("Player's Money: {0:C}", ViewState["PlayersMoney"]);
        }

        private void displayWinnings(int bet, int winnings)
        {
            if (winnings > 0)
            {
                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}", bet, winnings);
            }
            else
            {
                resultLabel.Text = string.Format("Sorry you lost {0:C}. Better luck next time!", bet);
            }
        }
    }
}