

///////////////////////////////////////////////////////////////////////////////////////
//
//    File Description            : Update Fault
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
using System.IO;

namespace RTT
{
    public partial class UpdateFault : System.Web.UI.Page
    {
        string strProblemType, strSubCategory, strDepartment;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (!IsPostBack)
                {
                    Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
                   
                }
                if (Session["UserName"] == null)
                {
                    Response.Redirect("~/HomePage.aspx");
                }
                IFaultBLL objIFaultBLL = FaultBLLFactory.CreateObject();

                int intFaultId = Convert.ToInt32(Request.QueryString["FaultID"]);
                IFault objIFault = objIFaultBLL.GetFaultDetails(intFaultId);
                cmbStatus.Text = "Open";
                if (!IsPostBack)
                {
                    strProblemType = objIFault.iProblemType;
                    cmbProblemType.Items.Add(strProblemType);
                    strSubCategory = objIFault.iSubCategory;
                    cmbSubCategory.Items.Add(strSubCategory);
                    strDepartment = objIFault.iDepartment;
                    cmbDepartment.Items.Add(strDepartment);
                    txtUserRemarks.Text = objIFault.iRemarks;
                    FillDropDownList1();
                }
                int intFaultId1 = 0;
                if (Request.QueryString.HasKeys())
                {
                    intFaultId1 = Convert.ToInt32(Request.QueryString["FaultID"].ToString());
                }
                lblFaultIdDisplay.Text = Request.QueryString["FaultID"].ToString();
            }
            catch (Exception E)
            {
                Response.Write("Some error occured, try again later");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Session["update"].ToString() == ViewState["update"].ToString())
            {

                IFault objIFault = FaultFactory.CreateObject();
                objIFault.iFaultId = Convert.ToInt32(Request.QueryString["FaultID"].ToString());
                objIFault.iRemarks = txtUserRemarks.Text;
                objIFault.iProblemType = cmbProblemType.SelectedItem.Text;
                try
                {
                    if (cmbStatus.SelectedItem.Text == "Open")
                    {
                        objIFault.iStatus = true;
                    }
                    else
                    {
                        objIFault.iStatus = false;
                    }
                    // objIFault.Status =Convert.ToBoolean(cmbStatus.SelectedItem.Value);
                    objIFault.iSubCategory = cmbSubCategory.SelectedItem.Text;
                    objIFault.iDepartment = cmbDepartment.SelectedItem.Text;

                    IFaultBLL objFaultBLL = FaultBLLFactory.CreateObject();
                    int intResult = objFaultBLL.UpdateFault(objIFault);
                    if (intResult > 0)
                    {

                        Display.Visible = false;
                        lblStuatesDisplay.Visible = true;
                        btnBack.Visible = true;
                        string strAlert = "Fault has been updatedSuccessfully";
                        string strScript = "<script type=\"text/javascript\">alert('" + strAlert + "');</script>";
                        Response.Write(strScript);
                        // Response.Redirect("ViewFaults.aspx");
                    }
                    else
                    {
                        lblStuatesDisplay.Text = "Not Updated";
                        lblStuatesDisplay.Visible = true;
                    }
                }
                catch (Exception E)
                {
                    Response.Write("Some error occured, try again later");
                }
                Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
            }
            else 
            {
                Display.Visible = false;
                lblStuatesDisplay.Visible = true;
                btnBack.Visible = true;
               
            }
        }

        protected void FillDropDownList1()
        {
            cmbProblemType.Items.Clear();
            int intCount = 1;
            FileStream objFileStream = null;
            StreamReader objStreamReader = null;
            objFileStream = new FileStream(Server.MapPath("~/Text/Main.txt"), FileMode.Open, FileAccess.Read);
            objStreamReader = new StreamReader(objFileStream);
            String strRead = null;
            try
            {
                while (intCount == 1)
                {
                    strRead = objStreamReader.ReadLine();
                    if (strRead == null)
                    {
                        intCount = 0;
                        break;
                    }
                    if (strRead == strProblemType)
                    {
                        continue;
                    }
                    ListItem objNewItem = new ListItem();
                    objNewItem.Text = strRead;
                    cmbProblemType.Items.Add(objNewItem);
                    cmbProblemType.DataBind();
                    cmbProblemType.SelectedItem.Text = strProblemType;

                }
            }
            catch (Exception e)
            {
                Response.Write("Some error occured, try again later");
            }
            finally
            {
                objFileStream.Close();
            }
        }
        protected void cmbProblemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int intCount = 1;
            FileStream objFileStream = null;
            StreamReader objStreamReader = null;
            String strRead = null;
            
                if(cmbProblemType.SelectedItem.Text == "Line issue")
                    try
                    {

                        {
                            cmbSubCategory.Items.Clear();

                            objFileStream = new FileStream(Server.MapPath("~/Text/NoiseLine.txt"), FileMode.Open, FileAccess.Read);
                            objStreamReader = new StreamReader(objFileStream);

                            while (intCount == 1)
                            {
                                strRead = objStreamReader.ReadLine();
                                if (strRead == null)
                                {
                                    intCount = 0;
                                    break;
                                }
                                if (strRead == strSubCategory)
                                {
                                    continue;
                                }
                                ListItem objNewItem = new ListItem();
                                objNewItem.Text = strRead;
                                cmbSubCategory.Items.Add(objNewItem);
                                cmbSubCategory.DataBind();
                                cmbSubCategory.SelectedItem.Text = strSubCategory;
                            }
                        }
                    }
                    catch (Exception E)
                    {
                    
                        Response.Write("Some error occured, try again later");
                    }
            finally
            {
            objFileStream.Close();
            }
       
       
         

            else if (cmbProblemType.SelectedItem.Text == "Service issue")
            {
                cmbSubCategory.Items.Clear();
                objFileStream = new FileStream(Server.MapPath("~/Text/Service issue.txt"), FileMode.Open, FileAccess.Read);
                objStreamReader = new StreamReader(objFileStream);
                try
                {
                    while (intCount == 1)
                    {
                        strRead = objStreamReader.ReadLine();

                        if (strRead == null)
                        {
                            intCount = 0;
                            break;
                        }
                        if (strRead == strSubCategory)
                        {
                            continue;
                        }
                        ListItem objNewitem = new ListItem();
                        objNewitem.Text = strRead;
                        cmbSubCategory.Items.Add(objNewitem);
                        cmbSubCategory.DataBind();
                        cmbSubCategory.SelectedItem.Text = strSubCategory;

                    }
                }
                catch (Exception E)
                {
                    Response.Write("Some error occured, try again later");
                }
            finally
                {
                   objFileStream.Close();
                }
        }
            else if (cmbProblemType.SelectedItem.Text == "Equipment issue")
            {
                cmbSubCategory.Items.Clear();
                objFileStream = new FileStream(Server.MapPath("~/Text/Equipment issue.txt"), FileMode.Open, FileAccess.Read);
                objStreamReader = new StreamReader(objFileStream);
                try
                {
                while (intCount == 1)
                {
                    strRead =objStreamReader.ReadLine();

                    if (strRead == null)
                    {
                        intCount = 0;
                        break;
                    }
                    if (strRead == strSubCategory)
                    {
                        continue;
                    }
                    ListItem objNewitem = new ListItem();
                   objNewitem.Text = strRead;
                    cmbSubCategory.Items.Add(objNewitem);
                    cmbSubCategory.DataBind();
                    cmbSubCategory.SelectedItem.Text = strSubCategory;

                }
                }
                    catch (Exception E)
                    {
                        Response.Write("Some error occured, try again later");
                    }
            finally
                    {
                    objFileStream.Close();
                    }
            }

            else if (cmbProblemType.SelectedItem.Text == "ProblemType")
            {
                try
                {
                    cmbSubCategory.Items.Clear();
                    objFileStream = new FileStream(Server.MapPath("~/Text/ProblemType.txt"), FileMode.Open, FileAccess.Read);
                    objStreamReader = new StreamReader(objFileStream);
                    
                    while (intCount == 1)
                    {
                        strRead = objStreamReader.ReadLine();

                        if (strRead == null)
                        {
                            intCount = 0;
                            break;
                        }
                        if (strRead == strSubCategory)
                        {
                            continue;
                        }
                        ListItem objNewitem = new ListItem();
                        objNewitem.Text = strRead;
                        cmbSubCategory.Items.Add(objNewitem);
                        cmbSubCategory.DataBind();
                        cmbSubCategory.SelectedItem.Text = strSubCategory;
                    }
                }
                
                    catch (Exception E)
                    {
                        Response.Write("Some error occured, try again later");
                    }               
                finally
                {
                    objFileStream.Close();
                }

            }

        }

        protected void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbSubCategory.Enabled = true;
            cmbDepartment.Items.Clear();
            int intCount = 1;
            FileStream objFileStream = null;
            StreamReader objStreamReader = null;

            objFileStream = new FileStream(Server.MapPath("~/Text/DownList3.txt"), FileMode.Open, FileAccess.Read);
            objStreamReader= new StreamReader(objFileStream);
            String strRead = null;
            try
            {
                while (intCount == 1)
                {
                    strRead = objStreamReader.ReadLine();
                    if (strRead == null)
                    {
                        intCount = 0;
                        break;
                    }
                    if (strRead == strDepartment)
                    {
                        continue;
                    }
                    ListItem objNewitem = new ListItem();
                    objNewitem.Text = strRead;
                    cmbDepartment.Items.Add(objNewitem);
                    cmbDepartment.DataBind();
                    cmbDepartment.SelectedItem.Text = strDepartment;
                }
            }
            catch (Exception E)
            {
                Response.Write("Some error occured, try again later");
            }
            finally
                {
            objFileStream.Close();
                }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["update"] = Session["update"];
            //TextBox3.Text = Session["update"].ToString();

        }

        // after pressing button will go to View Fault Page
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewFaults.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewFaults.aspx");
        }
    }
    
}