<%@ Page Language="C#" MasterPageFile="~/RTTMasterPage.Master" Theme="Skin1" AutoEventWireup="true"  CodeBehind="CustomerHomePage.aspx.cs" Inherits="RTT.CustomerHomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <table class="style1">
        <tr>
            <td class="style13" align="left">
                &nbsp;</td>
            <td class="style14">
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style9" align="left">
                <asp:Label ID="lblUserName" runat="server" Text="User Name :" SkinID="skin1"></asp:Label>
            </td>
            <td class="style5">
                <asp:TextBox ID="txtUserName" runat="server" Enabled="False" 
                    ></asp:TextBox>
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style10" align="left">
                <asp:Label ID="lblDOJ" runat="server" Text="DOJ :" SkinID="skin1"></asp:Label>
            </td>
            <td class="style6">
                <asp:TextBox ID="txtDOJ" runat="server" onfocus="showCalendarControl(this);" Enabled="False"></asp:TextBox>
            </td>
            <td class="style3">
                 &nbsp;</td>
        </tr>
        <tr>
            <td class="style10" align="left">
                <asp:Label ID="lblAddress" runat="server" Text="Address" SkinID="skin1"></asp:Label>
            </td>
            <td class="style6">
                <asp:TextBox ID="txtAddress" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style10" align="left">
                <asp:Label ID="lblEmailID" runat="server" Text="EmailID :" SkinID="skin1"></asp:Label>
            </td>
            <td class="style6">
                <asp:TextBox ID="txtEmailID" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11" align="left">
                <asp:Label ID="lblContactNo" runat="server" Text="Contact No :" SkinID="skin1"></asp:Label>
            </td>
            <td class="style7">
                <asp:TextBox ID="txtContactNo" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11" align="left">
                <asp:Label ID="lblAltContactNo" runat="server" Text="AltContact No :" 
                    SkinID="skin1"></asp:Label>
            </td>
            <td class="style7">
                <asp:TextBox ID="txtAltContactNo" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="style4">
                &nbsp;</td>
        </tr>
         </table>
            </div>
       <table class="style1">
       
    </asp:Content>
