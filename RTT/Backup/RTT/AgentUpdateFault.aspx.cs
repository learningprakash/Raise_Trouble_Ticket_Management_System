///////////////////////////////////////////////////////////////////////////////////////
//
//    File Description            : Update Fault
//-----------------------------------------------------------------------------  
//    Date Created                : 24/02/2012
//    Author                      : Nidhi And T kumar
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
    public partial class AgentUpdateFault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (Session["UserType"] != null)
                {
                   if (Session["UserType"].ToString() != "Agent")
                   ///if usertype is not agent, it will go to the homepage 
                    {
                        Response.Redirect("~/HomePage.aspx");
                    }
   
                }
                if (!IsPostBack)
                {
                    ///iff page is loading first time, Fetch data from cookies of preveous page 
                    
                    int faultId = 0;
                    HttpCookie cookie = Request.Cookies["userId"];
                    if (cookie != null)
                    {
                        txtUserID.Enabled = false;
                        txtUserID.Text = cookie.Value;
                    }
                    HttpCookie cookie1 = Request.Cookies["faultId"];
                    if (cookie1 != null)
                    {
                        txtfaultId.Enabled = false;
                        txtfaultId.Text = cookie1.Value;
                        faultId = Convert.ToInt32(txtfaultId.Text);
                    }
                    HttpCookie cookie2 = Request.Cookies["phoneNumber"];
                    if (cookie2 != null)
                    {
                        LblCustPhoneNo.Text = cookie2.Value.ToString();
                    }

                    if (Request.QueryString["FaultId"] != null && cookie1 == null)
                    {
                        faultId = Convert.ToInt32(Request.QueryString["FaultId"].ToString());
                        txtfaultId.Text = Convert.ToString(faultId);
                        txtfaultId.Enabled = false;
                    }

                    ///fill up the fault details data in the update page with the given faul 
                    fillDetails(faultId);
                }
            }
            catch (Exception Error)
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "Message", "<script type=\"text/javascript\">alert(\"Error :" + Error.ToString() + "\");</script>");
            }
        }

        
        /// Update the remarks field in the fault table in row with given faultid 
        
        protected void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {

                IFaultBLL objIfaultBLL = FaultBLLFactory.CreateObject();
                IFault objIFault = FaultFactory.CreateObject();
                objIFault.iRemarks = txtUserRemarks.Text.ToString();
                objIFault.iFaultId = Convert.ToInt32(txtfaultId.Text);
                int result = objIfaultBLL.UpdateFault(objIFault);
                if (result > 0)
                {

                    /// if row updated than displays message 
 
                    string msg = "Data Updated";
                    string script = "<script type=\"text/javascript\">alert('" + msg + "');</script>";
                    Response.Write(script);
                    fillDetails(objIFault.iFaultId);
                }
                else
                {
                    /// if data is not updated than displays message
                    
                    string msg = "not updated try later...";
                    string script = "<script type=\"text/javascript\">alert('" + msg + "');</script>";
                    Response.Write(script);
                }
            }
            catch (Exception Error)
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "Message", "<script type=\"text/javascript\">alert(\"Error :" + Error.ToString() + "\");</script>");
            }
        }


        /// <summary>
        /// fill up the Data in the update page with faults of the given userid 
        /// </summary>
        /// <param name="faultId"></param>
        
        public void fillDetails(int faultId)
        {
            try
            {
                IFaultBLL objIfaultBLL = FaultBLLFactory.CreateObject();
                IFault objIFault = objIfaultBLL.GetFaultDetails(faultId);
                if (objIFault.iDepartment != "" || objIFault.iDepartment != null)
                {
                    txtDepartment.Text = objIFault.iDepartment; ;
                    txtUserRemarks.Text = objIFault.iRemarks; ;
                    txtSubCategory.Text = objIFault.iSubCategory;
                    txtProblemType.Text = objIFault.iProblemType; ;
                }
            }
            catch (Exception Error)
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "Message", "<script type=\"text/javascript\">alert(\"Error :" + Error.ToString() + "\");</script>");
            }

        }

        protected void btnnewusersfaults_Click(object sender, EventArgs e)
        {
            /// if agent wants to search new users profile than redirect to searchuser-page: AgentHomePage 
            try
            {
                Response.Redirect("~/AgentHomePage.aspx");
            }
            catch (Exception Error)
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "Message", "<script type=\"text/javascript\">alert(\"Error :" + Error.ToString() + "\");</script>");
            }
        }

        protected void btnmoreincidents_Click(object sender, EventArgs e)
        {
            /// if agent wants to search more incidents of the same user than redirect to FaultManagement Page 
            try
            {
                Response.Redirect("~/FaultManagement.aspx");
            }
            catch(Exception Error)
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "Message", "<script type=\"text/javascript\">alert(\"Error :" + Error.ToString() + "\");</script>");
            }
        }
    }
}