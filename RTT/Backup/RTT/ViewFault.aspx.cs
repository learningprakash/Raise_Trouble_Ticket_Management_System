///////////////////////////////////////////////////////////////////////////////////////
//
//    File Description            : Update Fault
//-----------------------------------------------------------------------------  
//    Date Created                : 24/02/2012
//    Author                      : Prakash And Nidhi
//-----------------------------------------------------------------------------
// 
//    Change History              :
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
    public partial class ViewFault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        
        {
            if (Session["UserType"] != null)
            {
                if (Session["UserType"].ToString() != "Agent")
                {
                    ///if usertype is not agent, it will go to the homepage 
                    Response.Redirect("~/HomePage.aspx");
                }
            }

            HttpCookie cookie1 = Request.Cookies["phoneNumber"];
            if (cookie1 != null)
            {
                LblCustPhoneNo.Text = cookie1.Value.ToString();
            }
            HttpCookie cookie = Request.Cookies["userId"];
            if (cookie != null)
            {
                txtUserId.Enabled = false;
                txtUserId.Text = cookie.Value;
            }

            if (Request.QueryString["FaultId"] == null)
            {
                Response.Redirect("FaultManagement.aspx");
            }

            int faultId = Convert.ToInt32(Request.QueryString["FaultId"].ToString());
            txtFaultId.Text = faultId.ToString();
           
            ///fill up the fault data in the page viewfaults for the given faultid
            fillDetails(faultId);
        }

        /// <summary>
        /// fill up the Data in the update page with faults of the given userid 
        /// </summary>
        /// <param name="faultId"></param>
        /// 
        public void fillDetails(int faultId)
        {
            IFaultBLL objIfaultBLL=FaultBLLFactory.CreateObject();
            IFault objIFault = objIfaultBLL.GetFaultDetails(faultId);
            
            /// check if fault exist than enters in the if

            if (objIFault.iDepartment != "" || objIFault.iDepartment != null)
            {
                /// if fault status is open than agent can only update the fault 
                /// Agent can not delete the faults
               
                if (objIFault.iStatus == false)
                {
                   /// if status is closed than show the delete button to agent
                    btnUpdate.Visible = false;
                    lblmessage.Visible = true;
                }
                lblCustDepartment.Text = objIFault.iDepartment; ;
                lblCustRemarks.Text = objIFault.iRemarks; ;
                lblCustSubCategory.Text = objIFault.iSubCategory;
                lblCustProblemType.Text = objIFault.iProblemType; ;
            }

        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int faultId = Convert.ToInt32(txtFaultId.Text);
            /// redirect to the UpdatePage
            Response.Redirect("~/AgentUpdateFault.aspx?FaultId=" + faultId);

        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            /// redirect to the Preveous page
            Response.Redirect("~/ViewFault.aspx");
        }
    }
}