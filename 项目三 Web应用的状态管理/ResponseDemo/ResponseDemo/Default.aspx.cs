using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResponseDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("这是向浏览器输出的字符串");
            Response.Write("<h2>软件技术</h2>");
            Response.Write("<script language=\"javascript\">alert('欢迎使用ASP.NET')</script>");
        }
    }
}