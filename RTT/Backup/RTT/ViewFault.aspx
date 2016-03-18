<%@ Page Title="" Language="C#" MasterPageFile="~/RTTMasterPage.Master" Theme="Skin1" AutoEventWireup="true" CodeBehind="ViewFault.aspx.cs" Inherits="RTT.ViewFault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 466px;
        }
    .style2
    {
        width: 94px;
    }
    .style3
    {
        width: 96px;
    }
    .style4
    {
        width: 97px;
    }
    .style5
    {
        width: 115px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="height: 156px">
        <table >
            <tr>
                <td colspan="5" align="center">
                    <asp:Label ID="Label1" runat="server" Text="Ticket Management System" 
                        SkinID="skin1"></asp:Label>
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
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="5" align="center">
                    <asp:Label ID="lblViewFaultAlert" runat="server" Text="View Fault Incident" 
                        SkinID="skin1"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style2" align="right">
                    <asp:Label ID="lblUserId" runat="server" Text="User Id" Font-Size="Medium" 
                        ForeColor="Black" SkinID="skin1"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtUserId" runat="server" Height="22px" BackColor="#CCFFFF" 
                        BorderColor="#FF99FF" ForeColor="Blue"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style2" align="right">
                    <asp:Label ID="Label3" runat="server" Text="Fault ID" Font-Size="Medium" 
                        ForeColor="Black" SkinID="skin1"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtFaultId" runat="server" Enabled="False" BackColor="#CCFFFF" 
                        BorderColor="#FF99FF" ForeColor="Blue"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    
    <div>
    <table class="style1">
        <tr>
            <td align="left" class="style5" 
                style="font-family: Calibri; color: #000000; font-weight: bold">
                <asp:Label ID="LblPhoneNo" runat="server" Text="Phone No : " SkinID="skin1"></asp:Label>
            </td>
            <td class="style2" colspan="2" align="right">
                <asp:Label ID="LblCustPhoneNo" runat="server" Text="123456789" 
                    Font-Names="Calibri" Font-Size="Medium" ForeColor="#660033"></asp:Label>
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" class="style5" 
                style="font-family: Calibri; color: #000000; font-weight: bold">
                &nbsp;</td>
            <td class="style2" colspan="2" align="right">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left" class="style5" 
                style="font-family: Calibri; color: #000000; font-weight: bold">
                <asp:Label ID="lblProblemType" runat="server" Text="Problem Type" 
                    SkinID="skin1"></asp:Label>
            </td>
            <td class="style2" colspan="3" align="left">
                <asp:Label ID="lblCustProblemType" runat="server" Text="lblCustProblemType" 
                    Font-Names="Calibri" Font-Size="Medium" SkinID="skin2"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left" class="style5" 
                style="font-family: Calibri; color: #000000; font-weight: bold">
                <asp:Label ID="lblSubCategory" runat="server" Text="Sub Category" 
                    SkinID="skin1"></asp:Label>
            </td>
            <td class="style2" colspan="3" align="left">
                <asp:Label ID="lblCustSubCategory" runat="server" Text="lblCustSubCategory" 
                    Font-Names="Calibri" Font-Size="Medium" SkinID="skin2"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left" class="style5" 
                style="font-family: Calibri; color: #000000; font-weight: bold">
                <asp:Label ID="lblDepartment" runat="server" Text="Department" SkinID="skin1"></asp:Label>
            </td>
            <td class="style2" colspan="3" align="left">
                <asp:Label ID="lblCustDepartment" runat="server" Text="lblCustDepartment" 
                    Font-Names="Calibri" Font-Size="Medium" SkinID="skin2"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style5" align="left" 
                style="font-family: Calibri; color: #000000; font-weight: bold">
                <asp:Label ID="lblRemarks" runat="server" Text="Remarks" SkinID="skin1"></asp:Label>
            </td>
            <td class="style2" colspan="3" align="left">
                <asp:Label ID="lblCustRemarks" runat="server" Text="lblCustRemarks" 
                    Font-Names="Calibri" Font-Size="Medium" SkinID="skin2"></asp:Label>
            </td>
        </tr>
       
        <tr>
            <td colspan="2" align="left" 
                style="font-family: Calibri; color: #000000; font-weight: bold">
                &nbsp;</td>
            <td colspan="2" align="left">
                &nbsp;</td>
        </tr>
        
        <tr>
            <td colspan="2" align="left" 
                style="font-family: Calibri; color: #000000; font-weight: bold">
                <asp:Button ID="btnback" runat="server" onclick="btnback_Click" Text="Back" 
                    CausesValidation="False" />
            </td>
            <td align="left" class="style4">
                <asp:Button ID="btnUpdate" runat="server" onclick="btnUpdate_Click" 
                    Text="Update Incident" />
            </td>
            <td align="center">
                &nbsp;</td>
        </tr>
        
        <tr>
            <td colspan="2" align="left" 
                style="font-family: Calibri; color: #000000; font-weight: bold">
                &nbsp;</td>
            <td align="left" class="style4">
                <asp:Label ID="lblmessage" runat="server" 
                    Text="Fault is closed : Can not be updated" Visible="False" 
                    Font-Names="Arial" Font-Size="Smaller" ForeColor="#CC0000"></asp:Label>
            </td>
            <td align="center">
                &nbsp;</td>
        </tr>
        
    </table>
    </div>

</asp:Content>
