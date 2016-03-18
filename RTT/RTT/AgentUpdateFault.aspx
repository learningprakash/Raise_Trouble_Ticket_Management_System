<%@ Page Title="" Language="C#" MasterPageFile="~/RTTMasterPage.Master" Theme="Skin1" AutoEventWireup="true" CodeBehind="AgentUpdateFault.aspx.cs" Inherits="RTT.AgentUpdateFault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div>
    
        <table class="style1">
            <tr>
                <td colspan="6" align="center">
                    <asp:Label ID="Label1" runat="server" Text="Ticket Management System" 
                        SkinID="skin2"></asp:Label>
                </td>

            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="6" align="center">
                    <asp:Label ID="Label2" runat="server" Text="Update Fault Incident" 
                        SkinID="skin1"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style2" align="right">
                    <asp:Label ID="Label3" runat="server" Text="User ID" SkinID="skin1"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtUserID" runat="server" Width="113px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style2" align="right">
                    <asp:Label ID="lblfaultId" runat="server" Text="Fault Id" SkinID="skin1"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtfaultId" runat="server" Width="112px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    
    <div>
    <table class="style1">
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style2" align="right">
                <asp:Label ID="LblPhoneNo" runat="server" Text="Phone No : " SkinID="skin1"></asp:Label>
            </td>
            <td class="style2" align="left">
                <asp:Label ID="LblCustPhoneNo" runat="server" Text="123456789" 
                    ForeColor="#FF6699"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style4">
                <asp:Label ID="lblProblemType" runat="server" Text="Problem Type" 
                    SkinID="skin1"></asp:Label>
            </td>
            <td class="style2" colspan="2">
                <asp:TextBox ID="txtProblemType" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                <asp:Label ID="lblSubCategory" runat="server" Text="Sub Category" 
                    SkinID="skin1"></asp:Label>
            </td>
            <td class="style2" colspan="2">
                <asp:TextBox ID="txtSubCategory" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                <asp:Label ID="lblDepartment" runat="server" Text="Department" SkinID="skin1"></asp:Label>
            </td>
            <td class="style2" colspan="2">
                <asp:TextBox ID="txtDepartment" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                <asp:Label ID="lblRemarks" runat="server" Text="Remarks" SkinID="skin1"></asp:Label>
            </td>
            <td class="style2" colspan="2">
                <asp:TextBox ID="txtUserRemarks" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
       
        <tr>
            <td align="center" class="style4">
                <asp:Button ID="btnmoreincidents" runat="server" 
                    onclick="btnmoreincidents_Click" Text="View More Incidents" />
            </td>
            <td align="center">
                <asp:Button ID="btnupdate" runat="server" onclick="btnupdate_Click" 
                    Text="Update Incident" />
            </td>
            <td align="center">
                <asp:Button ID="btnnewusersfaults" runat="server" 
                    onclick="btnnewusersfaults_Click" Text="Search New User's Faults" />
            </td>
        </tr>
        
    </table>
    </div>

</asp:Content>
