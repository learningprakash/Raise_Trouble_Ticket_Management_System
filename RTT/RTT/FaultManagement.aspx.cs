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
using RTT.BLLFactory;
using RTT.Types;
using System.Data;

namespace RTT
{
    public partial class FaultManagement : System.Web.UI.Page
    {
        static int intStatus = 2;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["UserType"] == null)
            {
                Response.Redirect("~/HomePage.aspx");
            }
           
            if (Session["UserType"].ToString() != "Agent")
            ///if usertype is not agent, it will go to the homepage 
            {
                Response.Redirect("~/HomePage.aspx");
            }
            try
            {
                if (!IsPostBack)
                {
                    ///iff page is loading first time, Fetch data from cookies of preveous page 
                    HttpCookie objCookie2 = Request.Cookies["userId"];
                    if (objCookie2 != null)
                    {
                        txtUserID.Enabled = false;
                        txtUserID.Text = objCookie2.Value.ToString();
                    }
                    HttpCookie objCookie1 = Request.Cookies["phoneNumber"];
                    if (objCookie1 != null)
                    {
                        LblCustPhoneNo.Text = objCookie1.Value.ToString();
                    }
                    int intUserID = Convert.ToInt32(txtUserID.Text);
                    int intStatus = 2;

                    ///fill up the gridview with both open and closed faults of the given userid 
                    FillDetail(intUserID, intStatus);
                }
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// fill up the gridview with faults of the given userid and selected status 
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="status"></param>
        public void FillDetail(int userID, int status)
        {
            try
            {

                IFaultBLL objIFbll = FaultBLLFactory.CreateObject();
               
                DataSet ds = objIFbll.ViewFaults(userID, status);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    gvFaults.Visible = true;
                    gvFaults.DataSource = ds.Tables[0];
                    gvFaults.DataBind();

                    ///for each row in gridview put the Action Link according to status of the fault 
                    ///if fault is Open than Agent can Update it
                    ///if fault is closed than Agent can delete it
                    foreach (GridViewRow row in gvFaults.Rows)
                    {
                        string strData = row.Cells[8].Text;

                        if (row.Cells[8].Text == "Open")
                        {
                            LinkButton button = (LinkButton)row.FindControl("lnkButton");
                            button.Text = "Update";
                            int intFaultId = Convert.ToInt32(row.Cells[2].Text);
                            button.PostBackUrl = "~/AgentUpdateFault.aspx?FaultId=" + intFaultId;
                        }
                        else if ((row.Cells[8].Text == "Closed"))
                        {
                            LinkButton button = (LinkButton)row.FindControl("lnkButton");
                            button.Text = "Delete";
                            button.OnClientClick = "return confirm('Are you sure you want to delete this fault?')";
                            button.CommandName = "Delete";
                        }
                    }

                }

                if (ds.Tables[0].Columns["ProblemType"].ToString() == null || ds.Tables[0].Columns["ProblemType"].ToString() == "")
                {
                    /// if no faults are created by that user display a message
                    string strMsg = "No faults are created by this user";
                    string strScript = "<script type=\"text/javascript\">alert('" + strMsg + "');</script>";
                    Response.Write(strScript);
                }
            }
            catch(Exception e)
            {
                Response.Write("Some error occured try again later");
            }
        }
        protected void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int intUserID = Convert.ToInt32(txtUserID.Text);
                if (cmbStatus.SelectedItem.Text == "Both")
                {
                    ///fill up the gridview with both open and closed faults of the given userid 
                    FillDetail(intUserID, 2);
                }
                else if (cmbStatus.SelectedItem.Text == "Closed")
                {
                    ///fill up the gridview with faults of the given userid where status is closed 
                   
                    FillDetail(intUserID, 0);
                }
                
                    ///fill up the gridview with faults of the given userid where status is closed 
                else FillDetail(intUserID, 1);
            }
            catch (Exception E)
            {
                Response.Write("Some error occured, try again later");
            }
        }

        protected void gvFaults_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvFaults.Rows[e.RowIndex];

            ///takes the faultid of selected row to be deleted in the gridview 
            
            int intFaultId = Convert.ToInt32(row.Cells[2].Text.ToString());
            try
            {
                IFaultBLL objIFBll = FaultBLLFactory.CreateObject();

                ///delete the selected fault directly from gridview using faultid as primary key
                
                int intResult = objIFBll.DeleteFault(intFaultId); ;
                if (intResult > 0)
                {
                    ///if data deleted successfully display the message
                    this.ClientScript.RegisterStartupScript(this.GetType(), "OnClick", "<script type=\"text/javascript\">alert(\"Fault Deleted...!!!\");</script>");
                    Response.Redirect("~/FaultManagement.aspx");

                }
                else
                {
                    ///if data is not deleted due to some reasons display the message 
                    string strMsg = "Data Can not be deleted";
                    string strScript = "<script type=\"text/javascript\">alert('" + strMsg + "');</script>";
                    Response.Write(strScript);
                }
            }
            catch(Exception E)
            {
                Response.Write("Some error occured, try again later");
            }


        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AgentHomePage.aspx");
        }

        protected void gvFaults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}