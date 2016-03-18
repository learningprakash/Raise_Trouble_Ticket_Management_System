<%@ Page Title="" Language="C#" MasterPageFile="~/RTTMasterPage.Master" Theme="Skin1" AutoEventWireup="true" CodeBehind="UserFaultManagement.aspx.cs" Inherits="RTT.UserFaultManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div   id="search" runat="server"  style="margin-right: 140px; margin-left: 50px" visible="True">   
  <table class="style1">
     <tr>
        <td><asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number" 
                SkinID="skin1"></asp:Label></td>
        <td><asp:TextBox ID="txtPhoneNumber" runat="server" ToolTip="Phone Number"></asp:TextBox></td>
         
                
         <td>
            <asp:RequiredFieldValidator ID="rfvPhoneNo" runat="server" 
                ControlToValidate="txtPhoneNumber" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
             <asp:RegularExpressionValidator ID="revPhoneNo" runat="server" 
                 ControlToValidate="txtPhoneNumber" ErrorMessage="Enter valid number" 
                 Font-Size="Smaller" ForeColor="Red" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
         </td>
         
                
     </tr>

     <tr>
        <td class="style1"><asp:Button ID="btnSubmit" runat="server" Text="Submit" onclick="btnSubmit_Click" CausesValidation="True" /> </td>
        <td class="style1"> 
            <asp:Label ID="lblDisplayErorrMessage" runat="server" 
                Text="Phone Number Does Not Exist" Visible="False" ForeColor="Red"></asp:Label> </td>
     </tr>
  </table>  
</div> 

<div  id="details"  runat="server"  style="margin-right: 150px; margin-left: 150px;" >
   <table class="style1" >
      <tr>
        <td align="left"><asp:Label ID="lblUserID" runat="server" Text="User ID" 
                SkinID="skin1"></asp:Label> </td>
        <td align="left"><asp:Label ID="lblUserIDValue" runat="server" Text="User ID Value" 
                SkinID="skin2"></asp:Label></td>
      </tr>

      <tr>
        <td align="left"><asp:Label ID="lblUserName" runat="server" Text="User Name" 
                SkinID="skin1"></asp:Label></td>
        <td align="left"><asp:Label ID="lblUserNameValue" runat="server" 
                Text="User Name Value" SkinID="skin2"></asp:Label></td>
      </tr>

      <tr>
        <td align="left"><asp:Label ID="lblDOJ" runat="server" Text="DOJ" SkinID="skin1"></asp:Label></td>
        <td align="left"><asp:Label ID="lblDOJValue" runat="server" Text="DOJ Value" 
                SkinID="skin2"></asp:Label></td>
      </tr>

      <tr>
        <td align="left"><asp:Label ID="lblAddress" runat="server" Text="Address" 
                SkinID="skin1"></asp:Label> </td>
        <td align="left"><asp:Label ID="lblAddressValue" runat="server" 
                Text="Address Value" SkinID="skin2"></asp:Label></td>
      </tr>

      <tr>
        <td align="left"><asp:Label ID="lblEmailID" runat="server" Text="EmailID" 
                SkinID="skin1"></asp:Label> </td>
        <td align="left"><asp:Label ID="lblEmailIDValue" runat="server" Text="Email ID" 
                SkinID="skin2"></asp:Label></td>
      </tr>


      <tr>
         <td align="left"><asp:Button ID="btnCreateFault" runat="server" Text="Create Fault" 
                 onclick="btnCreateFault_Click"  /> </td>
         <td align="left"> 
             <asp:Button ID="btnViewFault" runat="server" Text="View Fault" 
                 onclick="btnViewFault_Click1" /> </td>
       </tr>

      </table>     
  </div>

</asp:Content>
