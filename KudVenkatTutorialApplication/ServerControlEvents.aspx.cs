using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KudVenkatTutorialApplication
{
    public partial class ServerControlEvents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page Load Events Called");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("PostBack Event" + "<br/>");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Textbox Changed Event" + "<br/>");
        }
    }
}