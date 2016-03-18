using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RTT.Types;
using RTT.BLLFactory;
namespace RTT
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                int intUserId = Convert.ToInt32(txtUserID.Text);
                string strPassword = txtPassword.Text;
                ICustomerBLL objICustbll = CustomerBLLFactory.CreateObject();
                ICustomer objICust = objICustbll.Login(intUserId, strPassword);
                if (objICust.iUserName != "")
                {
                    if (objICust.iUserType == "customer")
                    {
                        Session["UserType"] = "Customer";
                        Session["UserName"] = objICust.iUserName;
                        Session["UserId"] = intUserId;
                        Response.Redirect("~/CustomerHomePage.aspx");
                    }
                    else
                    {
                        Session["UserType"] = "Agent";
                        Response.Redirect("~/AgentHomePage.aspx");
                    }
                }
                else
                    lblMessage.Visible = true;
            }
            catch (Exception ex)
            {
                lblMessage.Visible = true;
            }
        }
    }
}