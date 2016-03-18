<%@ Page Title="" Language="C#" MasterPageFile="~/RTTMasterPage.Master"Theme="Skin1" AutoEventWireup="true" CodeBehind="AgentHomePage.aspx.cs" Inherits="RTT.AgentHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table class="style1" width="100%">
            <tr>
                <td align="center" colspan="6" class="style1">
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
                <td align="center" colspan="6">
                    <asp:Label ID="Label2" runat="server" Text="View Faults" SkinID="skin1"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style2" align="right">
                    &nbsp;</td>
                <td colspan="2" align="center">
                    <asp:Label ID="Label3" runat="server" Text="User ID" SkinID="skin1"></asp:Label>
                &nbsp;<asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
                    &nbsp;<asp:Button ID="btnSearchUser" runat="server" onclick="btnSearchUser_Click" Text="Search" />
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtUserID" ErrorMessage="User Id  Can not be empty" 
                        ForeColor="Red" Font-Size="Smaller"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RangeValidator ID="rgvUserId" runat="server" 
                        ControlToValidate="txtUserID" ErrorMessage="Enter valid user id" MaximumValue="9999" 
                        MinimumValue="100" Type="Integer" Font-Size="Smaller" ForeColor="Red"></asp:RangeValidator>
                </td>
                <td>
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>
