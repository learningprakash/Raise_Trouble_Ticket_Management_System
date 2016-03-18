<%@ Page Title="" Language="C#" MasterPageFile="~/RTTMasterPage.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="RTT.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:Label ID="lblErrorMessage" runat="server" BorderColor="Red" 
            Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="Red" 
            Text="Your Process has not Completed. Please Try After Some Time"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
