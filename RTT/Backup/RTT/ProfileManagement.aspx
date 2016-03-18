<%@ Page Title="" Language="C#"MasterPageFile="~/RTTMasterPage.Master"Theme="Skin1" AutoEventWireup="true" CodeBehind="ProfileManagement.aspx.cs" Inherits="RTT.ProfileManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="../Calender.js"></script>
    <link rel="Stylesheet" type="text/css" href="../Calender.css" />
    <style type="text/css">
        .style1
        {
            width: 355px;
        }
        .style2
        {
            width: 131px;
        }
        .style3
        {
            width: 67px;
        }
        .style4
        {
            width: 72px;
        }
        .style5
        {
            width: 91px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<br />

<table class="style1">
        <tr>
            
               <td>
                   <asp:Label ID="lblUserId" runat="server" Text="User Id" SkinID="skin1"></asp:Label>
                   &nbsp;
                   <asp:TextBox ID="txtSearch" runat="server" ForeColor="#999999" 
                    ToolTip="User Id" MaxLength="4">Enter UserId</asp:TextBox></td>

           <td>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                   ControlToValidate="txtSearch" ErrorMessage="*" Font-Size="Smaller" 
                   ForeColor="Red"></asp:RequiredFieldValidator>
               <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                   ControlToValidate="txtSearch" ErrorMessage="Enter a valid Id" 
                   ValidationExpression="^[0-9]*" Font-Size="Smaller" ForeColor="Red"></asp:RegularExpressionValidator>
               </td>
                    <td> &nbsp;</td>
            <td><asp:Button ID="btnSearch" runat="server" onclick="btnSearch_Click1" 
                    Text="Search" ForeColor="Black" CausesValidation="True" /></td>
           
            
        </tr>
        </table>
        <div id ="divProfile" visible = "False" runat="server">
        <table class="style1">
        <tr>
            <td class="style5" align="left">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td class="style15" align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5" align="left">
                <asp:Label ID="lblUserName" runat="server" Text="User Name :" SkinID="skin1"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtUserName" runat="server" Enabled="False" MaxLength="30" 
                    ></asp:TextBox>
            </td>
            <td class="style2" align="left">
            <asp:RequiredFieldValidator ID="rfvUserName" runat="server" 
                    ErrorMessage="*" ForeColor="#CC0000" ControlToValidate="txtUserName" 
                    Enabled="False"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revUserName" runat="server" 
                    ErrorMessage="Enter Alphabets only" ForeColor="Red" 
                    ValidationExpression="^[a-zA-Z][a-zA-Z ]*[a-zA-Z]$" 
                    ControlToValidate="txtUserName" Font-Size="Smaller" Enabled="False"></asp:RegularExpressionValidator>
                </td>
        </tr>
        <tr>
            <td class="style5" align="left">
                <asp:Label ID="lblDOJ" runat="server" Text="DOJ :" SkinID="skin1"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtDOJ" runat="server" 
                    Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style3" align="left">
                 <asp:RequiredFieldValidator ID="rfvDOJ" runat="server" 
                    ErrorMessage="*" ForeColor="#CC0000" ControlToValidate="txtDOJ" 
                     Enabled="False"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="style5" align="left">
                <asp:Label ID="lblAddress" runat="server" Text="Address" SkinID="skin1"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtAddress" runat="server" Enabled="False" Height="34px" 
                    MaxLength="100" TextMode="MultiLine" Width="128px"></asp:TextBox>
            </td>
            <td class="style3" align="left">
            <asp:RequiredFieldValidator ID="rfvAddress" runat="server" 
                    ErrorMessage="*" ForeColor="Red" ControlToValidate="txtAddress" 
                    Enabled="False"></asp:RequiredFieldValidator>
             </td>
        </tr>
        <tr>
            <td class="style5" align="left">
                <asp:Label ID="lblEmailID" runat="server" Text="EmailID :" SkinID="skin1"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtEmailID" runat="server" Enabled="False" MaxLength="30"></asp:TextBox>
            </td>
            <td class="style3" align="left">
             <asp:RequiredFieldValidator ID="rfvEmailID" runat="server" 
                    ErrorMessage="*" ForeColor="#CC0000" ControlToValidate="txtEmailID" 
                    Enabled="False"></asp:RequiredFieldValidator>
        
                <asp:RegularExpressionValidator ID="revEmailID" runat="server" 
                    ControlToValidate="txtEmailID" ErrorMessage="*Invalid Email Id" 
                    ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    Font-Size="Smaller" Enabled="False"></asp:RegularExpressionValidator>
                </td>
        </tr>
        <tr>
            <td class="style5" align="left">
                <asp:Label ID="lblContactNo" runat="server" Text="Contact No :" SkinID="skin1"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtContactNo" runat="server" Enabled="False" MaxLength="10"></asp:TextBox>
            </td>
            <td class="style4" align="left">
              <asp:RequiredFieldValidator ID="rfvContactNo" runat="server" 
                    ErrorMessage="*" ForeColor="#CC0000" ControlToValidate="txtContactNo" 
                    Enabled="False"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="rgvContactNo" runat="server" 
                    ControlToValidate="txtContactNo" ErrorMessage="*Enter a Valid 10 digit number" 
                    ForeColor="Red" MaximumValue="9999999999" MinimumValue="7000000000" 
                    Type="Currency" Font-Size="Smaller" Enabled="False"></asp:RangeValidator>
                </td>
        </tr>
        <tr>
            <td class="style5" align="left">
                <asp:Label ID="lblAltContactNo" runat="server" Text="AltContact No :" 
                    SkinID="skin1"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtAltContactNo" runat="server" Enabled="False" MaxLength="10"></asp:TextBox>
            </td>
            <td class="style4" align="left">
            <asp:RequiredFieldValidator ID="rfvAltContactNo" runat="server" 
                    ErrorMessage="*" ForeColor="#CC0000" ControlToValidate="txtAltContactNo" 
                    Enabled="False"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="rgvAltContactNo" runat="server" 
                    ControlToValidate="txtAltContactNo" ErrorMessage="*Enter a valid 10 digit number" 
                    ForeColor="Red" MaximumValue="9999999999" MinimumValue="7000000000" 
                    Type="Currency" Font-Size="Smaller" Enabled="False"></asp:RangeValidator>
                </td>
        </tr>
         </table>
            </div>
       <table class="style1">
       
        <tr>
            <td class="style12">
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11">
                </td>
            <td class="style7">
                <asp:Button ID="btnEdit" runat="server" ForeColor="Black" 
                    onclick="btnEdit_Click" Text="Edit Details" Visible="False" 
                    CausesValidation="False" />
            </td>
            <td class="style4">
                </td>
        </tr>
        <tr>
            <td class="style12">
                &nbsp;</td>
            <td class="style8">
                <asp:Button ID="btnUpdate" runat="server" ForeColor="Black" 
                    onclick="btnUpdate_Click" Text="Update" Visible="False" 
                    CausesValidation="False" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style12">
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
