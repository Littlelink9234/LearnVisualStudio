using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallenegeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                string[] names = new string[0];
                int[] elections = new int[0];
                int[] subterfuge = new int[0];

                ViewState.Add("Names", names);
                ViewState.Add("Elections", elections);
                ViewState.Add("Subterfuge", subterfuge);
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // ViewState for Names of spies
            string[] names = (string[])ViewState["Names"];
            Array.Resize(ref names, names.Length + 1);

            int newestName = names.GetUpperBound(0);
            names[newestName] = txtName.Text;
            ViewState["Names"] = names;


            // ViewState for Elections rigged
            int[] elections = (int[])ViewState["Elections"];

            Array.Resize(ref elections, elections.Length + 1);

            int newestItem = elections.GetUpperBound(0);

            elections[newestItem] = int.Parse(txtRigged.Text);
            ViewState["Elections"] = elections;

            
            // ViewState for Average Subterfuge
            int[] subterfuge = (int[])ViewState["Subterfuge"];
            Array.Resize(ref subterfuge, subterfuge.Length + 1);

            int newestSubterfuge = subterfuge.GetUpperBound(0);

            subterfuge[newestSubterfuge] = int.Parse(txtSubterfuge.Text);
            ViewState["Subterfuge"] = subterfuge;

            
            // Result label for the project
            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br />Average Acts of Subterfuge per Asset: {1:N2}<br />(Last Asset you Added: {2})", elections.Sum(), subterfuge.Average(), names[newestName]);

            txtName.Text = "";
            txtRigged.Text = "";
            txtSubterfuge.Text = "";
        }
    }
}