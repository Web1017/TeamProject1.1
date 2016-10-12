using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeamProject1._1
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(Page.Title + " loaded...");
            SetActivePage();

        }

        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Home":
                    Home.Attributes.Add("class", "active");
                    break;
                case "Products":
                    Products.Attributes.Add("class", "active");
                    break;
                case "GameTracker":
                    GameTracker.Attributes.Add("class", "active");
                    break;
                case "About":
                    About.Attributes.Add("class", "active");
                    break;
                case "Contact":
                    Contact.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}