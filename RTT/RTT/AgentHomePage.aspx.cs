///////////////////////////////////////////////////////////////////////////////////////
//
//    File Description            : Update Fault
//-----------------------------------------------------------------------------  
//    Date Created                : 24/02/2012
//    Author                      : Prakash And T kumar
//-----------------------------------------------------------------------------
// 
//    Change History              :
//    Date Modified		          : 
//	  Changed By		          :
//	  Change Description          : 
//
///////////////////////////////////////////////////////////////////////////////////////
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
    public partial class AgentHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["UserType"] != null)
            {
                ///if usertype is not agent, it will go to the homepage 
                if (Session["UserType"].ToString() != "Agent")
                {
                    Response.Redirect("~/HomePage.aspx");
                }
            }
            else
                Response.Redirect("~/HomePage.aspx");
            txtUserID.Attributes.Add("this.focus()", "true");
        }
        ///<summary>
        ///It is the method which is used by agent on clicking search
        ///to see the user faults on entering userId
        ///</summary>
        protected void btnSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                int intUserId = Convert.ToInt32(txtUserID.Text);
                ICustomerBLL objICBll = CustomerBLLFactory.CreateObject();
                ICustomer objICust = objICBll.SearchProfile(intUserId);
                if (objICust.iEmailId != null && objICust.iEmailId != "")
                {
                    ///<summary>
                    ///these cookies will send phone no and user id to the next page
                    ///</summary>
                    HttpCookie objCookie1 = new HttpCookie("phoneNumber", objICust.iContactNo);
                    Response.Cookies.Add(objCookie1);
                    HttpCookie objCookie2 = new HttpCookie("userId", objICust.iUserId.ToString());
                    Response.Cookies.Add(objCookie2);

                    Response.Redirect("~/FaultManagement.aspx");
                }
                else
                {
                    ///generates Message Pop Up
                    this.ClientScript.RegisterStartupScript(this.GetType(), "OnClick", "<script type=\"text/javascript\">alert(\"No user with user Id :" + intUserId + " found\");</script>");
                }
            }
            catch (Exception Error)
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "Message", "<script type=\"text/javascript\">alert(\"Error :" + Error.ToString() + "\");</script>");
            }
        }
    }
}