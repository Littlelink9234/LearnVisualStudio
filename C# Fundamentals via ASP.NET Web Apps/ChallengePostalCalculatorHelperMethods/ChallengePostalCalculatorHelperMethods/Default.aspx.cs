using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void handleChange(object sender, EventArgs e)
        {
            calculateShipping();
        }

        // Calculate Shipping
        private void calculateShipping()
        {
            int width = int.Parse(WidthTextBox.Text);
            //if (!int.TryParse(WidthTextBox.Text, out width)) return false;

            int height = int.Parse(HeightTextBox.Text);
            //if (!int.TryParse(HeightTextBox.Text, out height)) return;

            int length = 0;
            if (!int.TryParse(LengthTextBox.Text, out length)) length = 1;

            int volume = width * height * length;
            double shippingCost = 0;

            // Ground cost:     .15 multiplier
            // Air cost:        .25 multiplier
            // Next day cost:   .45 multiplier
            if (GroundRadioButton.Checked) shippingCost = volume * .15;
            else if (AirRadioButton.Checked) shippingCost = volume * .25;
            else if (NextDayRadioButton.Checked) shippingCost = volume * .45;

            resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship.", shippingCost);
        }               
    }
}