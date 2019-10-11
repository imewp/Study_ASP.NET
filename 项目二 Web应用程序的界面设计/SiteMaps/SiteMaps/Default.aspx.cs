using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteMaps
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (TreeNode tn in TreeView1.Nodes)
                Response.Write(tn.Text + ":" + tn.Value);
            //TreeNode tn = new TreeNode();
            //tn.Text = "笔记本";
            //tn.Value = "笔记本";
            //TreeNode parentNode = TreeView1.FindNode("硬件产品");
            //parentNode.ChildNodes.Add(tn);
        }

    }
}