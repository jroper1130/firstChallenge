using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string animal = animalTextBox.Text;
            string result = "Hello " + name + " I also like " + animal + "s!";
            resultLabel.Text = result;
        }
    }
}