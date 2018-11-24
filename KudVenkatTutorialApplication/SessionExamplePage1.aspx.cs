using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KudVenkatTutorialApplication
{
    public partial class SessionExamplePage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ClicksCount"] == null)
                {
                    Session["ClicksCount"] = 0;
                }
                TextBox1.Text = Session["ClicksCount"].ToString();
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

           int ClicksCount = Convert.ToInt32(Session["ClickCount"]) + 1;
            TextBox1.Text = ClicksCount.ToString();
            Session["ClickCount"] = ClicksCount;
        }


    }
}