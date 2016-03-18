


///////////////////////////////////////////////////////////////////////////////////////
//
//    File Description            : View Fault
//-----------------------------------------------------------------------------  
//    Date Created                : 24/02/2012
//    Author                      : Viral and Nidhi
//-----------------------------------------------------------------------------
// 
//    Change History              :
//    Date Modified		          : 
//	  Changed By		          :
//	  Change Description          : 
//
///////////////////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////////////////
//
//    File Description            : Close Fault
//-----------------------------------------------------------------------------  
//    Date Created                : 24/02/2012
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
using System.Data;

namespace RTT
{
    public partial class ViewFaults : System.Web.UI.Page
    {
        static int intFaultId;
        protected void Page_Load(object sender, EventArgs e)
        {
            // gvFaults.Visible = false;
            // txtUserID.Visible = false;
            if (Session["UserName"] == null)
            {
                Response.Redirect("~/HomePage.aspx");
            }
            
            if (!IsPostBack)
            {
                Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
               
            }
            PopulateGridView();
            divViewUpdate.Visible = false;
            

        }

        // You will See All Fault Created By User.
            protected void PopulateGridView()
            {
                int intTempUserID = (int)Session["UserID"];
                IFaultBLL ifbll = FaultBLLFactory.CreateObject();

                DataSet ds = ifbll.ViewFaults(intTempUserID, 1);
                if (ds != null)
                {

                    gvFaults.Visible = true;
                    gvFaults.DataSource = ds.Tables[0];
                    gvFaults.DataBind();
                    btnViewFaultBack.Visible = true;
                }
                else
                {
                    //lblAlertBox.Visible = true;
                    lblDisplay.Text = "No Fault Yet Created";
                    lblDisplay.Visible = true;
                    btnViewFaultBack.Visible = true;
                }

            }
        

        // You Can See Whole Details of Selected Particular Fault of GridView
        protected void gvFaults_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FaultDetailsGridView.Style.Add("Display", "none");
                GridViewRow grvRow = gvFaults.SelectedRow;
                intFaultId = Convert.ToInt32(grvRow.Cells[1].Text);
                IFaultBLL objIFblll = FaultBLLFactory.CreateObject();
                IFault objIFault = objIFblll.GetFaultDetails(intFaultId);
                Details.Visible = true;
                lblProblemTypeValue.Text = objIFault.iProblemType.ToString();
                lblSubCategoryValue.Text = objIFault.iSubCategory.ToString();
                lblDepartmentValue.Text = objIFault.iDepartment.ToString();
                lblRemarksValue.Text = objIFault.iRemarks.ToString();
                lblFaultIDValue.Text = intFaultId.ToString();
                lblStatusValue.Text = "Open";
                divViewUpdate.Visible = true;
                lblDisplayAlertMessage.Visible = false;
                btnViewFaultBack.Visible = false;
            }
            catch (Exception E)
            {
                Response.Redirect("Error.aspx");


            }

        }

        protected void lbtnUpdate_Click(object sender, EventArgs e)
        {
            gvFaults.Visible = false;
            Response.Redirect("~/UpdateFault.aspx?FaultID="+intFaultId);
        }

        protected void lbtnClose_Click(object sender, EventArgs e)
        {
             //if (Session["update"].ToString() == ViewState["update"].ToString())
            {
            try
            {
                FaultDetailsGridView.Style.Add("Display", "none");
                Details.Style.Add("Display", "none");
                gvFaults.Visible = false;
                GridViewRow row = gvFaults.SelectedRow;
                IFaultBLL objIFaultBLL = FaultBLLFactory.CreateObject();
                int intResult = objIFaultBLL.CloseFault(intFaultId);
                if (intResult != -1)
                {
                    btnViewFaultBack.Visible = false;
                    divViewUpdate.Visible = true;
                    //btnBack.Visible = true;
                    //lblDisplayAlertMessage.Visible = true;
                    }
                else
                {
                    lblDisplay.Text = "Your Fault is not close Please Try again";
                    lblDisplay.Visible = true;
                }
            }
            catch
            {
                Response.Redirect("Error.aspx");
            }
            Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
            }
           

        }
       
        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["update"] = Session["update"];
            //TextBox3.Text = Session["update"].ToString();

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ViewFaults.aspx");
        }

        protected void btnViewFaultBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserFaultManagement.aspx");
        }

       
       
    }
}