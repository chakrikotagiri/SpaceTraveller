using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SpaceDAL;
namespace SpaceTraveller
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WelcomeUser();
        }

        private void WelcomeUser()
        {
            SpaceDAL.Class1 c = new Class1();
            Label1.Text = c.GreetUser();
        }
    }
}