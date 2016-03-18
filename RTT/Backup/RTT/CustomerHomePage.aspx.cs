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
    public partial class CustomerHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///returns homepage if someone directly comes to this page
            if (Session["UserName"] == null)
            {
                Response.Redirect("~/HomePage.aspx");
            }
            try
            {
                int intUserId = Convert.ToInt32(Session["UserId"].ToString());
                ICustomerBLL objICbll = CustomerBLLFactory.CreateObject();
                ///<summary>
                ///after pressing login in homepage, it sends user to his/her profile page
                ///</summary>
                ICustomer objICust = objICbll.SearchProfile(intUserId);
                // division name Profile1
                if (objICust.iEmailId != null && objICust.iEmailId != "")
                {
                    //display user details

                    txtUserName.Text = objICust.iUserName;
                    txtDOJ.Text = (objICust.iDateOfJoining).ToString();
                    txtAddress.Text = objICust.iAddress;
                    txtEmailID.Text = objICust.iEmailId;
                    txtContactNo.Text = objICust.iContactNo;
                    txtAltContactNo.Text = objICust.iAltContactNo;
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}