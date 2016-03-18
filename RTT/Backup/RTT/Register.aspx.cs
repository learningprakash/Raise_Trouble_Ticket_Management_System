///////////////////////////////////////////////////////////////////////////////////////
//
//    File Description            : Register customer
//-----------------------------------------------------------------------------  
//    Date Created                : 22/02/2012
//    Author                      : Rohit band Pramod
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
using RTT.BOFactory;

namespace RTT
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rgvDOJ.MaximumValue = DateTime.Now.ToShortDateString();
        }

        /// <summary>
        /// on clicking the register button on regestration page, this method 
        /// sends user's data to function create profile to store it in database
        /// </summary>
        
        protected void btnRegister_Click1(object sender, EventArgs e)
        {
            ICustomer objICust= CustomerFactory.CreateObject();
            string strUserName = txtUserName.Text;
            objICust.iUserName = strUserName.Trim();
            objICust.iDateOfJoining = txtDOJ.Text;
            objICust.iEmailId = txtEmailID.Text;
            objICust.iAddress = txtAddress.Text;
            objICust.iPassword = txtPassword.Text;
            objICust.iContactNo = txtContactNo.Text;
            objICust.iAltContactNo = txtAltContactNo.Text;

            ///



            ICustomerBLL objICustbll = CustomerBLLFactory.CreateObject();
            objICust.iUserId = objICustbll.CreateProfile(objICust);
            if (objICust.iUserId != 0)
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "OnClick", "<script type=\"text/javascript\">alert(\"Registration successful!\\n Please note your User ID. \\nUser ID: " + objICust.iUserId.ToString() + "\");</script>");
            }
            else
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "OnClick", "<script type=\"text/javascript\">alert(\"Email id or phone number already exists...\\n please enter valid data \");</script>");
            }
        }
    }
}