<%@ Page Title="" Language="C#" MasterPageFile="~/RTTMasterPage.Master"  Theme="Skin1" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="RTT.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="padding: 10px 10px 10px 10px; margin-top: 30px; margin-left: 100px; margin-right: 100px; ">
         <table style="border: thin solid #66CCFF; padding: 15px;" cellpadding="10px" cellspacing="0px" border="1px">
            <tr>
                <td><asp:Label ID="lblUserID" runat="server" Text="User ID:" SkinID="skin1"></asp:Label></td>
                <td><asp:TextBox ID="txtUserID" runat="server" MaxLength="3" Width="136px"></asp:TextBox>
                
                    &nbsp;&nbsp;
                
                    <asp:RequiredFieldValidator ID="rfvUserId" runat="server" 
                        ErrorMessage="*Required" ControlToValidate="txtUserID" Font-Size="Smaller" 
                        ForeColor="Red"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblPassword" runat="server" Text="Password :" SkinID="skin1"></asp:Label></td>
                <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" MaxLength="15" Width="136px"></asp:TextBox>&nbsp;&nbsp; 
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
                        ErrorMessage="*Required" ControlToValidate="txtPassword" 
                        Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator></td>
                
            </tr>
            <tr>
                <td colspan="2">&nbsp;<asp:Label ID="lblRegisrer" runat="server" 
                        Text="New user? Register" SkinID="skin1"></asp:Label> 
                    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Register.aspx" 
                        runat="server">here</asp:HyperLink></td>
                
                
            </tr>
            <tr>
             <td colspan="2" align="center">
                <asp:Label ID="lblMessage" runat="server" Text="Invalid User id or Password" 
                     Visible="False" Font-Bold="True" Font-Overline="False" ForeColor="Red"></asp:Label>
             </td>
             </tr>
             <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnLogIn" runat="server" Text="Log In" 
                        onclick="btnLogIn_Click" BackColor="White" ForeColor="#993333" /></td>
             </tr>
            </table>
        </div>
 </asp:Content>
