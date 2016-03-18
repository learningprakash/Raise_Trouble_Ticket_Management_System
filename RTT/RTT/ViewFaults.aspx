<%@ Page Title="" Language="C#" MasterPageFile="~/RTTMasterPage.Master" Theme="Skin1" AutoEventWireup="true" CodeBehind="ViewFaults.aspx.cs" Inherits="RTT.ViewFaults" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   

         <div id="FaultDetailsGridView" runat = "server">
         <table>
         <tr>
         <td>
             <asp:GridView ID="gvFaults" runat="server" 
                 onselectedindexchanged="gvFaults_SelectedIndexChanged" 
                 AutoGenerateColumns="False" CellPadding="4" 
                 BackColor="White" BorderColor="#3366CC" 
                 BorderStyle="None" BorderWidth="1px" PageSize="1">
                 <Columns>
                     <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="View" 
                         ShowHeader="True" Text="View" />
                     <asp:BoundField DataField="FaultId" HeaderText="Fault Id" />
                     <asp:BoundField DataField="UserId" HeaderText="User Id" />
                     <asp:BoundField DataField="FaultStatus" HeaderText="Status" />
                     <asp:BoundField DataField="Problem_Type" HeaderText="Problem Type" />
                 </Columns>
                 <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                 <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                 <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                 <RowStyle BackColor="White" ForeColor="#003399" />
                 <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                 <SortedAscendingCellStyle BackColor="#EDF6F6" />
                 <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                 <SortedDescendingCellStyle BackColor="#D6DFDF" />
                 <SortedDescendingHeaderStyle BackColor="#002876" />
             </asp:GridView> </td>
              </table>

              <table id="AlertBox" runat = "server"><tr>
             <td>
                 <asp:Label ID="lblDisplay" runat="server" Text="No Match Found" Visible="False" 
                     SkinID="skin1"></asp:Label> </td>
         </tr>     
         </table>
         
   
    </div>

<div runat = "server" id="Details" visible ="false"> 
    
        <table class="style1" cellpadding="5" cellspacing="0" border="0" 
            style="border: thin solid #000000">
            <tr>
                <td align="left">
                    <asp:Label ID="lblProblemType" runat="server" Text="Problem  Type" 
                        SkinID="skin1"></asp:Label>
                </td>
                <td align="left">
                    <asp:Label ID="lblProblemTypeValue" runat="server" Text="Problem Type Value" 
                        SkinID="skin2"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style1" align="left">
                    <asp:Label ID="lblSubCategory" runat="server" Text="Sub Category" 
                        SkinID="skin1"></asp:Label>
                </td>
                <td class="style1" align="left">
                    <asp:Label ID="lblSubCategoryValue" runat="server" Text="Sub Category Value" 
                        SkinID="skin2"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="left">
                    <asp:Label ID="lblDepartment" runat="server" Text="Department" SkinID="skin1"></asp:Label>
                </td>
                <td align="left">
                    <asp:Label ID="lblDepartmentValue" runat="server" Text="Department Type Value " 
                        SkinID="skin2"></asp:Label>
                </td>
            </tr>
            <tr>
            <td align="left">
                <asp:Label ID="lblRemarks" runat="server" Text="Remarks" SkinID="skin1"></asp:Label> </td>
                <td align="left">
                    <asp:Label ID="lblRemarksValue" runat="server" Text="Label" SkinID="skin2"></asp:Label> </td>
                
            </tr>
            <tr>
                <td align="left">
                    <asp:Label ID="lblStatus" runat="server" Text="Status" SkinID="skin1"></asp:Label>
                </td>
                <td align="left">
                    <asp:Label ID="lblStatusValue" runat="server" SkinID="skin2"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="left">
                    <asp:Label ID="lblFaultID" runat="server" Text="Fault ID" SkinID="skin1"></asp:Label> </td>
                <td align="left" > 
                    <asp:Label ID="lblFaultIDValue" runat="server" Text="Fault ID Value" 
                        SkinID="skin2"></asp:Label> </td>
            </tr>
            <tr>
                <td align="left">
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnUpdate" runat="server" onclick="lbtnUpdate_Click" 
                        Text="Update " /></td>
                <td align="left">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnClose" runat="server" onclick="lbtnClose_Click" 
                        Text="Close" />

                </td></tr>
                </table>
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <%-- <asp:Button ID="btnBack" runat="server" Text="Back" onclick="btnBack_Click" />
                                </div>
                --%>
    </div>
    <div runat = "server" id="divViewUpdate" visible="False" >   
    <table><tr>
    <td>
     <asp:Label ID="lblDisplayAlertMessage" runat="server" 
                                        Text="Fault has been Closed" ForeColor="Red"></asp:Label>
       </td> <td>
           <asp:Button ID="btnBack" runat="server" Text="Back" onclick="btnBack_Click" /> </td>
        </tr>  </table>
         </div  >
         
             <asp:Button ID="btnViewFaultBack" runat="server" Text= "Back" 
             onclick="btnViewFaultBack_Click" />
       
    
</asp:Content>
