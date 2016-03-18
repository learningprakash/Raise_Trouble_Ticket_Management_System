
///////////////////////////////////////////////////////////////////////////////////////
//
//    File Description            : Create Fault
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
using System.IO;

namespace RTT
{
    public partial class CreateFault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
                fillddl1();
            }
            if (Session["UserName"] != null)
            {
                lblUserIDValue.Text = Session["UserID"].ToString();
                lblPhoneNumberValue.Text = Request.QueryString["PhoneNumber"];
            }
            else
                {
                Response.Redirect("~/HomePage.aspx");
                }
            
        }


        protected void fillddl1()
        {
            FileStream objFileStream = null;
            StreamReader objStreamReader = null;
            try
            {
                cmbProblemType.Items.Clear();

                int intCount = 1;
                

                objFileStream = new FileStream(Server.MapPath("~/Text/Main.txt"), FileMode.Open, FileAccess.Read);
                objStreamReader = new StreamReader(objFileStream);
                String strRead = null;
                while (intCount == 1)
                {
                    strRead = objStreamReader.ReadLine();
                    if (strRead == null)
                    {
                        intCount = 0;
                        break;
                    }
                    ListItem objobjNewItem = new ListItem();
                    objobjNewItem.Text = strRead;
                    cmbProblemType.Items.Add(objobjNewItem);
                    cmbProblemType.DataBind();

                }
                objStreamReader.Close();
            }
            catch (Exception E)
            {
                Response.Write(E.ToString());
            }
            finally
            {
                objStreamReader.Close();
                objFileStream.Close();
            }
        }
        protected void cmbProblemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileStream objFileStream = null;
            StreamReader objStreamReader = null;
            try
            {
                int intCount = 1;
                string strRead = null;
                //cmbSubCategory.Enabled = true;

                if (cmbProblemType.SelectedItem.Text == "Line issue")
                {
                    cmbSubCategory.Items.Clear();
                    objFileStream = new FileStream(Server.MapPath("~/Text/Lineissue.txt"), FileMode.Open, FileAccess.Read);
                    objStreamReader = new StreamReader(objFileStream);

                    while (intCount == 1)
                    {

                        strRead = objStreamReader.ReadLine();
                        if (strRead == null)
                        {
                            intCount = 0;
                            break;
                        }
                        ListItem objNewItem = new ListItem();
                        objNewItem.Text = strRead;
                        cmbSubCategory.Items.Add(objNewItem);
                        cmbSubCategory.DataBind();

                    }

                }

                else if (cmbProblemType.SelectedItem.Text == "Service issue")
                {
                    cmbSubCategory.Items.Clear();
                    objFileStream = new FileStream(Server.MapPath("~/Text/Service issue.txt"), FileMode.Open, FileAccess.Read);
                    objStreamReader = new StreamReader(objFileStream);
                    while (intCount == 1)
                    {
                        strRead = objStreamReader.ReadLine();

                        if (strRead == null)
                        {
                            intCount = 0;
                            break;
                        }
                        ListItem objobjNewItem = new ListItem();
                        objobjNewItem.Text = strRead;
                        cmbSubCategory.Items.Add(objobjNewItem);
                        cmbSubCategory.DataBind();
                    }
                }

                else if (cmbProblemType.SelectedItem.Text == "Equipment issue")
                {
                    cmbSubCategory.Items.Clear();
                    objFileStream = new FileStream(Server.MapPath("~/Text/Equipment issue.txt"), FileMode.Open, FileAccess.Read);
                    objStreamReader = new StreamReader(objFileStream);

                    while (intCount == 1)
                    {
                        strRead = objStreamReader.ReadLine();

                        if (strRead == null)
                        {
                            intCount = 0;
                            break;
                        }
                        ListItem objNewItem = new ListItem();
                        objNewItem.Text = strRead;
                        cmbSubCategory.Items.Add(objNewItem);
                        cmbSubCategory.DataBind();
                    }

                   
                }

                else  
                {
                    cmbSubCategory.Items.Clear();
                    //intCount = 0;
                    //string[] problemtype = File.ReadAllLines("~/Text/ProblemType.txt");
                    //foreach (string s in problemtype)
                    //{
                    //    ListItem item = new ListItem(s, intCount.ToString());
                    //    cmbSubCategory.Items.Add(item);
                    //    intCount++;
                    //}


                    
                    objFileStream = new FileStream(Server.MapPath("~/Text/Billing issue.txt"), FileMode.Open, FileAccess.Read);
                    objStreamReader = new StreamReader(objFileStream);

                    while (intCount == 1)
                    {
                        strRead = objStreamReader.ReadLine();

                        if (strRead == null)
                        {
                            intCount = 0;
                            break;
                        }
                        ListItem objNewItem = new ListItem();
                        objNewItem.Text = strRead;
                        cmbSubCategory.Items.Add(objNewItem);
                        cmbSubCategory.DataBind();
                    }
                   
                }

            }
            catch (Exception E)
            {
                Response.Write(E.ToString());
            }
            finally 
            {
                objStreamReader.Close();
                objStreamReader.Close();
            }
           
               

        }

        protected void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbSubCategory.Enabled = true;
            cmbDepartment.Items.Clear();
            int intCount = 1;
            FileStream objFileStream = null;
            StreamReader objStreamReader = null;
            try
            {

                objFileStream = new FileStream(Server.MapPath("~/Text/DownList3.txt"), FileMode.Open, FileAccess.Read);
                objStreamReader = new StreamReader(objFileStream);
                String strRead = null;
                while (intCount == 1)
                {
                    strRead = objStreamReader.ReadLine();
                    if (strRead == null)
                    {
                        intCount = 0;
                        break;
                    }
                  
                    ListItem objNewItem = new ListItem();
                    objNewItem.Text = strRead;
                    cmbDepartment.Items.Add(objNewItem);
                    cmbDepartment.DataBind();

                }
                objStreamReader.Close();
                objFileStream.Close();
            }
            catch (Exception E)
            {
                Response.Write(E.ToString());
            }
            finally
            {
                objStreamReader.Close();
                objFileStream.Close();
            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            if (Session["update"].ToString() == ViewState["update"].ToString())
            {
                try
                {
                    IFault objFault = FaultFactory.CreateObject();
                    objFault.iDepartment = cmbDepartment.SelectedItem.Text;
                    objFault.iProblemType = cmbProblemType.SelectedItem.Text;
                    objFault.iRemarks = txtUserRemarks.Text;
                    objFault.iSubCategory = cmbSubCategory.SelectedItem.Text;
                    string strStatus1 = cmbStatus.SelectedItem.Text.ToString();

                    if (strStatus1 == "open")
                    {
                        objFault.iStatus = true;
                    }

                    objFault.iUserId = (int)(Session["UserID"]);
                    IFaultBLL objCreateFault = FaultBLLFactory.CreateObject();
                    int intFaultID = objCreateFault.CreateFault(objFault);
                    if (intFaultID != 0)
                    {
                        btnBack.Visible = true;
                        txtUserRemarks.Text = "";
                        divDetails.Visible = false;
                        lblFaultAlert.Text = "Fault has been Created successful";
                        lblFaultAlert.Visible = true;
                        string strMsg = " Fault ID: " + intFaultID;
                        string strScript = "<script type=\"text/javascript\">alert('" + strMsg + "');</script>";
                        Response.Write(strScript);
                        
                        //  Response.Redirect("~/CreateFault.aspx");

                        //string sScript = "<script language='javascript'>alert(\"" + strMsg + "\");  alert('Record has been Updated Successfully'); window.location.href = '~/CreateFault.aspx'; </script>"; 
                    }
                    else
                    {
                        
                        lblFaultAlert.Visible = true;
                    }
                   // txtUserRemarks.Text = "";
                }
                catch (Exception E)
                {
                    Response.Write(E.ToString());
                }
                Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
            }
            else
            {
                btnBack.Visible = true;
                divDetails.Visible = false;
                lblFaultAlert.Text = "Fault has been Created successful"; 
                lblFaultAlert.Visible = true;
            }
            //}
        }
       

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserFaultManagement.aspx");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["update"] = Session["update"];
            //TextBox3.Text = Session["update"].ToString();

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserFaultManagement.aspx");
        }
    }
}