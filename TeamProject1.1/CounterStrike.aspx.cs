using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeamProject1;
using System.Web.ModelBinding;
using TeamProject1._1.Models;

namespace TeamProject1._1
{
    public partial class CounterStrike : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                this.GetGame1();

            }

        }
        private void GetGame1()
        {
            using (GameModel db = new GameModel())
            {
                  var Game1 = (from cStrike in db.Games
                                        select cStrike);
                CSGame1.DataSource = Game1.ToList();
                CSGame1.DataBind();  
               
            }
        }
    }
}