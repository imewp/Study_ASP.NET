﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThemeDesignDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_PreInit(object sender,EventArgs e)
        {
            switch(Request.QueryString["theme"])
            {
                case "Blue": Page.Theme = "Blue"; break;
                case "Red": Page.Theme = "Red"; break;
            }
        }
    }
}