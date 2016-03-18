///////////////////////////////////////////////////////////////////////////////////////
//
//    File Description            : Get Details For Creating Fault
//-----------------------------------------------------------------------------  
//    Date Created                : 22/02/2012
//    Author                      : Viral and Nidhi
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
using RTT.BLLFactory;
using RTT.BOFactory;
using RTT.Types;

namespace RTT
{
    public partial class UserFaultManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            details.Visible = false;
            lblDisplayErorrMessage.Visible = false;
            if (Session["UserName"] == null)
            {
                Response.Redirect("~/HomePage.aspx");
            }
        }
        // After Enetring Your Proper PhoneNumber You Will See Your Profile Details as well as Create Fault and View Fault Button Visible.
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["UserID"] != null)
                {
                int intUserId = Convert.ToInt32(Session["UserID"]);
                    string strContactNo = txtPhoneNumber.Text;
                    ICustomerBLL objICustomerBll = CustomerBLLFactory.CreateObject();
                    int intCount = objICustomerBll.CheckContactNo(strContactNo, intUserId);
                    if (intCount == 1)
                    {
                        details.Visible = true;
                        ICustomer objICustomer = objICustomerBll.SearchProfile(intUserId);
                        lblUserIDValue.Text = intUserId.ToString();
                        lblUserNameValue.Text = objICustomer.iUserName.ToString();
                        lblDOJValue.Text = objICustomer.iDateOfJoining.ToString();
                        lblAddressValue.Text = objICustomer.iAddress.ToString();
                        lblEmailIDValue.Text = objICustomer.iEmailId.ToString();
                    }
                    else if (intCount == 0)
                        this.ClientScript.RegisterStartupScript(this.GetType(), "OnClick", "<script  language='javascript'>alert(\"Invalid Contact Number. Please enter your registered contact number.\");</script>");
                    else if (intCount == -1)
                        this.ClientScript.RegisterStartupScript(this.GetType(), "OnClick", "<script  language='javascript'>alert(\"Error occured. Please try again.\");</script>");
                }
            }
            catch (Exception E)
            {
            }            
        }


        
        //After Pressing Creat Fault Button, Link Will go in Create Fault Page.
        protected void btnCreateFault_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CreateFault.aspx?PhoneNumber="+txtPhoneNumber.Text.ToString()+"");

        }

        //After Pressing Creat Fault Button, Link Will go in View Fault Page.
      

        protected void btnViewFault_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/ViewFaults.aspx");
        }
    }
}