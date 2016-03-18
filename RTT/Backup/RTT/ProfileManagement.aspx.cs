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
using RTT.BOFactory;
using RTT.BLLFactory;
using RTT.Types;
namespace RTT
{
    public partial class ProfileManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
                }

                // disables profile informations,edit button 


                txtAddress.Enabled = false;
                txtAltContactNo.Enabled = false;
                txtContactNo.Enabled = false;
                txtDOJ.Enabled = false;
                txtEmailID.Enabled = false;
                txtUserName.Enabled = false;               
                btnEdit.Visible = false;
                txtSearch.Enabled = true;
                divProfile.Visible = false;
                txtSearch.Attributes.Add("onfocus", "this.value=''");


                // returns homepage if someone directly comes to ths page

                if (Session["UserName"] == null)
                {
                    Response.Redirect("~/HomePage.aspx");
                }
            }

            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// updates the data in the database on clicking update button
        /// </summary>
        
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["update"].ToString() == ViewState["update"].ToString())
                {
                    //makes profile(division) visible
                    txtSearch.Enabled = true;
                    divProfile.Visible = true;
                    ICustomer objICustomer = CustomerFactory.CreateObject();
                    objICustomer.iUserId = Convert.ToInt32(Session["UserId"]);
                    objICustomer.iUserName = txtUserName.Text;
                    objICustomer.iAddress = txtAddress.Text;
                    objICustomer.iAltContactNo = txtAltContactNo.Text;
                    objICustomer.iContactNo = txtContactNo.Text;
                    objICustomer.iDateOfJoining = txtDOJ.Text;
                    objICustomer.iEmailId = txtEmailID.Text;
                    ICustomerBLL objUpdatecust = CustomerBLLFactory.CreateObject();

                    ///method calling for updating data in database
                    ///returns no of rows affected in database
                    int intResult = objUpdatecust.UpdateProfile(objICustomer);
                    if (intResult > 0)
                    {
                        string strMessage = "Profile Updated Successfully";
                        Response.Write("<script>alert('" + strMessage + "');</script>");

                    }
                    txtSearch.Visible = true;
                    btnSearch.Visible = true;
                    lblUserId.Visible = true;
                    btnUpdate.Visible = false;
                    btnEdit.Visible = true;
                    Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
                }
                /// this code will run on refresh
                else
                {
                    divProfile.Visible = true;
                    btnUpdate.Visible = false;
                    btnEdit.Visible = true;
                    txtSearch.Visible = true;
                    btnSearch.Visible = true;
                    lblUserId.Visible = true;

                }
            }
            catch (Exception ex)
            {

            }
            
        }

        /// <summary>
        /// after giving user id, this event is called on clicking search button
        /// </summary>
        
        protected void btnSearch_Click1(object sender, EventArgs e)
        {
            int intUserId = Convert.ToInt32(txtSearch.Text);

             /// Method calling for searching profile for user
            try
            {
            ICustomerBLL objICbll = CustomerBLLFactory.CreateObject();
            ICustomer objICust = objICbll.SearchProfile(intUserId);
            if (objICust != null)
            {
                divProfile.Visible = true;
                txtUserName.Text = objICust.iUserName;
                txtDOJ.Text = (objICust.iDateOfJoining).ToString();
                txtAddress.Text = objICust.iAddress;
                txtEmailID.Text = objICust.iEmailId;
                txtContactNo.Text = objICust.iContactNo;
                txtAltContactNo.Text = objICust.iAltContactNo;

                // Enables edit button and disables update button 
                //if userid in textbox is equal to login userid

                if (Convert.ToInt32(Session["UserID"]) == intUserId)
                {
                    btnEdit.Visible = true;
                    btnUpdate.Visible = false;
                  //  txtSearch.Enabled = false;
                }

                //disables edit button if userid in textbox
                //is not equal to login userid
                else
                {
                    btnEdit.Visible = false;
                }
             }

                    //it will disable the labelAlert and profile details also

                else
                {
                   
                    this.ClientScript.RegisterStartupScript(this.GetType(), "OnClick", "<script type=\"text/javascript\">alert(\"No user with user Id :" + txtSearch.Text + " found\");</script>");
                    divProfile.Visible = false;
                }
                Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
            }
            catch(Exception ex)
            {
            }
        }
       
        /// <summary>
        /// on click edit button, this function enables all profile details and
        /// then user can update the details
        /// </summary>

        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["update"] = Session["update"];
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            btnSearch.Visible = false;
            lblUserId.Visible = false;
            txtSearch.Enabled = false;
            divProfile.Visible = true;
            txtAddress.Enabled = true;
            txtAltContactNo.Enabled = true;
            txtContactNo.Enabled = true;
            txtEmailID.Enabled = true;
            txtUserName.Enabled = true;
            btnEdit.Visible = false;
            btnUpdate.Visible = true;
            rgvAltContactNo.Enabled = true;
            rgvContactNo.Enabled = true;
            //rgvDOJ.Enabled = true;
            revUserName.Enabled = true;
            revEmailID.Enabled = true;
            rfvUserName.Enabled = true;
            rfvAddress.Enabled = true;
            rfvDOJ.Enabled = true;
            rfvContactNo.Enabled = true;
            rfvEmailID.Enabled = true;
            rfvAltContactNo.Enabled = true;
            Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
        }

  

      
    }
}
