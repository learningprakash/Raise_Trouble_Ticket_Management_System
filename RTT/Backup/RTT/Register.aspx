<%@ Page Language="C#" MasterPageFile="~/RTTMasterPage.Master" Theme="Skin1" AutoEventWireup="true"  CodeBehind="Register.aspx.cs" Inherits="RTT.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="../Calender.js"></script>
    <link rel="Stylesheet" type="text/css" href="../Calender.css" />
    <style type="text/css">
        .style2
        {
            height: 36px;
            width: 168px;
        }
        .style4
        {
            height: 29px;
            width: 168px;
        }
        .style5
        {
            width: 201px;
        }
        .style7
        {
            height: 36px;
            width: 201px;
        }
        .style8
        {
            height: 29px;
            width: 201px;
        }
        .style13
        {
            height: 12px;
            width: 201px;
        }
        .style14
        {
            height: 12px;
            width: 168px;
        }
        .style20
        {
            height: 51px;
        }
        .style21
        {
            height: 44px;
        }
        .style22
        {
            height: 44px;
            width: 91px;
        }
        .style23
        {
            height: 29px;
            width: 91px;
        }
        .style24
        {
            height: 12px;
            width: 91px;
        }
        .style25
        {
            height: 36px;
            width: 91px;
        }
        .style27
        {
            width: 91px;
        }
        .style28
        {
            width: 201px;
            height: 25px;
        }
        .style29
        {
            width: 91px;
            height: 25px;
        }
        .style30
        {
            height: 25px;
            width: 168px;
        }
        .style31
        {
            height: 44px;
            width: 417px;
        }
        .style32
        {
            height: 29px;
            width: 417px;
        }
        .style33
        {
            height: 12px;
            width: 417px;
        }
        .style34
        {
            height: 36px;
            width: 417px;
        }
        .style36
        {
            width: 417px;
            height: 25px;
        }
        .style37
        {
            width: 417px;
        }
        .style38
        {
            height: 28px;
            width: 201px;
        }
        .style39
        {
            width: 201px;
            height: 7px;
        }
        .style40
        {
            width: 91px;
            height: 7px;
        }
        .style41
        {
            height: 7px;
            width: 168px;
        }
        .style42
        {
            width: 417px;
            height: 7px;
        }
        .style43
        {
            height: 44px;
            width: 168px;
        }
        .style44
        {
            width: 168px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="margin-top: 30px; margin-left: 40px">
    <table>

    <tr>
        <td colspan="3" style="font-weight: bold; color: #000000; font-family: Calibri">
            <span style="font-family: Calibri; font-size: large; font-weight: bold; color: #0000FF">New User Registraion</span>
        </td>
        <td colspan="2" class="style20">
            &nbsp;</td>
    </tr>

    <tr>
        <td class="style38" align="left" 
            style="font-weight: bold; color: #000000; font-family: Calibri">
                <asp:Label ID="lblUserName" runat="server"  Text="User Name : *"></asp:Label>
            </td>
        <td class="style22">
                &nbsp;</td>
        <td class="style43">
                <asp:TextBox ID="txtUserName" runat="server" MaxLength="30" Width="137px" 
                    BackColor="#CCFFFF" BorderColor="#CC99FF" Font-Names="Calibri" 
                    ForeColor="#0000CC"></asp:TextBox>
                
            </td>
        <td class="style31" align="left">
             <asp:RequiredFieldValidator ID="rfvUserName" runat="server" 
                    ErrorMessage="*" ForeColor="#CC0000" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revUserName" runat="server" 
                    ErrorMessage="Enter Alphabets only(max 30 char)" ForeColor="Red" 
                    ValidationExpression="^[a-zA-Z][a-zA-Z ]*[a-zA-Z]$" 
                    ControlToValidate="txtUserName" Font-Size="Smaller"></asp:RegularExpressionValidator>
        </td>
        <td class="style21">
        </td>
    </tr>
        <tr>
            <td class="style8" align="left" 
                style="font-weight: bold; color: #000000; font-family: Calibri">
                <asp:Label ID="lblDOJ" runat="server" Text="DOJ : *"></asp:Label>
                <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="Smaller" 
                    ForeColor="Red" Text="(Please use calender)"></asp:Label>
            </td>
            <td class="style23">
                &nbsp;</td>
            <td class="style4">
                <asp:TextBox ID="txtDOJ" onfocus="showCalendarControl(this);" runat="server" 
                    Width="137px" BackColor="#CCFFFF" BorderColor="#CC99FF" 
                    Font-Names="Calibri" ForeColor="#0000CC" MaxLength="1"></asp:TextBox>
            </td>
            <td class="style32" align="left">
            <asp:RequiredFieldValidator ID="rfvDOJ" runat="server" 
                    ErrorMessage="*" ForeColor="#CC0000" ControlToValidate="txtDOJ"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="rgvDOJ" runat="server" 
                    ControlToValidate="txtDOJ" 
                    ErrorMessage="Can't take future dates" ForeColor="Red" 
                    MinimumValue="01/01/1968" SetFocusOnError="True" 
                    Type="Date" Font-Size="Smaller"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td align="left" class="style13" 
                style="font-weight: bold; color: #000000; font-family: Calibri">
                <asp:Label ID="lblAddress" runat="server" Text="Address :*"></asp:Label>
            </td>
            <td class="style24">
                &nbsp;</td>
            <td class="style14">
                <asp:TextBox ID="txtAddress" runat="server" Height="52px" MaxLength="200" 
                    TextMode="MultiLine" Width="137px" BackColor="#CCFFFF" 
                    BorderColor="#CC99FF" Font-Names="Calibri" ForeColor="#0000CC"></asp:TextBox>
            </td>
            <td align="left" class="style33">
                <asp:RequiredFieldValidator ID="rfvAddress" runat="server" 
                    ErrorMessage="*Required" ForeColor="Red" ControlToValidate="txtAddress" 
                    Font-Size="Smaller"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="style7" align="left" 
                style="font-weight: bold; color: #000000; font-family: Calibri">
                <asp:Label ID="lblEmailID" runat="server" Text="Email ID :*"></asp:Label>
            </td>
            <td class="style25">
                &nbsp;</td>
            <td class="style2">
                <asp:TextBox ID="txtEmailID" runat="server" MaxLength="30" Width="137px" 
                    BackColor="#CCFFFF" BorderColor="#CC99FF" Font-Names="Calibri" 
                    ForeColor="#0000CC"></asp:TextBox>
            </td>
            <td class="style34" align="left">
             <asp:RequiredFieldValidator ID="rfvEmailID" runat="server" 
                    ErrorMessage="*" ForeColor="#CC0000" ControlToValidate="txtEmailID"></asp:RequiredFieldValidator>
        
                <asp:RegularExpressionValidator ID="revEmailID" runat="server" 
                    ControlToValidate="txtEmailID" ErrorMessage="*Invalid e-mailid" 
                    ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    Font-Size="Smaller"></asp:RegularExpressionValidator>
                </td>
        </tr>
        <tr>
            <td class="style7" align="left" 
                style="font-weight: bold; color: #000000; font-family: Calibri">
                <asp:Label ID="lblContactNo" runat="server" Text="ContactNo. :*"></asp:Label>
            </td>
            <td class="style25">

                &nbsp;</td>
            <td class="style2">

                <asp:TextBox ID="txtContactNo" runat="server" MaxLength="10" Width="137px" 
                    BackColor="#CCFFFF" BorderColor="#CC99FF" Font-Names="Calibri" 
                    ForeColor="#0000CC"></asp:TextBox>
            </td>
            <td class="style34" align="left">
             <asp:RequiredFieldValidator ID="rfvContactNo" runat="server" 
                    ErrorMessage="*" ForeColor="#CC0000" ControlToValidate="txtContactNo"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="rgvContactNo" runat="server" 
                    ControlToValidate="txtContactNo" ErrorMessage="*Enter a valid 10 digit number" 
                    ForeColor="Red" MaximumValue="9999999999" MinimumValue="7000000000" 
                    Type="Currency" Font-Size="Smaller"></asp:RangeValidator>
                </td>
        </tr>
        <tr>
            <td align="left" class="style8" 
                style="font-weight: bold; color: #000000; font-family: Calibri">
                <asp:Label ID="lblAltContactNo" runat="server" Text="AltContactNo :"></asp:Label>
            </td>
            <td class="style23">
                &nbsp;</td>
            <td class="style4">
                <asp:TextBox ID="txtAltContactNo" runat="server" MaxLength="10" Width="137px" 
                    BackColor="#CCFFFF" BorderColor="#CC99FF" Font-Names="Calibri" 
                    ForeColor="#0000CC"></asp:TextBox>
            </td>
            <td align="left" class="style32">
                <asp:RangeValidator ID="rgvAltContactNo0" runat="server" 
                    ControlToValidate="txtAltContactNo" ErrorMessage="*Enter a valid 10 digit number" 
                    ForeColor="Red" MaximumValue="9999999999" MinimumValue="7000000000" 
                    Type="Currency" Font-Size="Smaller"></asp:RangeValidator>
                </td>
        </tr>
        <tr>
            <td class="style39" align="left" 
                style="font-weight: bold; color: #000000; font-family: Calibri">
                <asp:Label ID="lblPassword" runat="server" Text="Password :*"></asp:Label>
            </td>
            <td class="style40">
                </td>
            <td class="style41">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" MaxLength="15" 
                    Width="137px" BackColor="#CCFFFF" BorderColor="#CC99FF" Font-Names="Calibri" 
                    ForeColor="#0000CC"></asp:TextBox>
            </td>
            <td class="style42" align="left">
                            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
                    ErrorMessage="*" ForeColor="#CC0000" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revPassword" runat="server" 
                    ControlToValidate="txtPassword" 
                    
                                ErrorMessage="Enter strong password of length(8-15)  which has at least 1 uppercase,1 lowercase,1 special and 1 numeric character " ForeColor="Red" 
                    
                    ValidationExpression="^.*(?=.{8,15})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&amp;+=]).*$" 
                    Font-Size="Smaller"></asp:RegularExpressionValidator>
                </td>
        </tr>
        <tr>
            <td align="left" class="style28" 
                style="font-weight: bold; color: #000000; font-family: Calibri">
                <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password :*"></asp:Label>
            </td>
            <td class="style29">
            </td>
            <td class="style30">
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" 
                    MaxLength="15" Width="137px" BackColor="#CCFFFF" BorderColor="#CC99FF" 
                    Font-Names="Calibri" ForeColor="#0000CC"></asp:TextBox>
            </td>
            <td align="left" class="style36">
             <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" 
                    ErrorMessage="*" ForeColor="#CC0000" 
                    ControlToValidate="txtConfirmPassword"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cmvPassword" runat="server" 
                    ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" 
                    ErrorMessage="Passwords do not match" ForeColor="Red" Font-Size="Smaller"></asp:CompareValidator>
                </td>
        </tr>
        <tr>
            <td align="left" class="style5" 
                style="font-weight: bold; color: #000000; font-family: Calibri">
                &nbsp;</td>
            <td class="style27">
                &nbsp;</td>
            <td class="style44">
                &nbsp;</td>
            <td align="left" class="style37">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="Left" colspan="4" 
                style="font-weight: bold; color: #000000; font-family: Calibri">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRegister" runat="server" Text="Register" 
                    onclick="btnRegister_Click1" />
            </td>
        </tr>
    </table>
    </div>
</asp:Content>

