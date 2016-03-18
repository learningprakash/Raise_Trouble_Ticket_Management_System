using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RTT
{
    public partial class RTTMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_PreInit(object sender, EventArgs e) 
        { 
           
        } 
        protected void Page_init(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                if (!IsPostBack)
                {
                    if (Session["UserType"] != null)
                    {
                        if (Session["UserType"].ToString() == "Customer")
                        {
                            SiteMapDataSource1.SiteMapProvider = "User";
                            lblUserName.Text = Session["UserName"].ToString();

                        }
                        else if (Session["UserType"].ToString() == "Agent")
                        {
                            SiteMapDataSource1.SiteMapProvider = "Agent";
                            lblUserName.Text = "Agent";
                        }
                        else
                        {
                            linkLogout.Visible = false;
                            lblWelcome.Visible = false;
                            lblUserName.Visible = false;
                            SiteMapDataSource1.SiteMapProvider = "Default";
                        }
                    }
                    else
                    {
                        linkLogout.Visible = false;
                        lblWelcome.Visible = false;
                        lblUserName.Visible = false;
                        SiteMapDataSource1.SiteMapProvider = "Default";
                    }

                }
            }
            catch (Exception ex)
            {
            }
        }
        protected void linkLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("~/HomePage.aspx");
        }
    }
}

