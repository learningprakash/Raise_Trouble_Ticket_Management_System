<%@ Page Title="" Language="C#" MasterPageFile="~/RTTMasterPage.Master" Theme="Skin1" AutoEventWireup="true" CodeBehind="CreateFault.aspx.cs" Inherits="RTT.CreateFault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div id="divDetails" runat = "server"> 


 <table class="style1">
   <tr>
   <td align="left"> <asp:Label ID="lblPhoneNumber" runat="server"  
           Text="Phone Number" Height="20px" Width="100px" SkinID="skin1" ></asp:Label> </td>
   <td class="style3">
       <asp:Label ID="lblPhoneNumberValue" runat="server" 
           Width="200px" SkinID="skin2"  ></asp:Label></td>
   </tr>
   <tr>
   <td align="left"> 
       <asp:Label ID="lblUserID" runat="server"  Text="User ID" Height="20px" 
           Width="100px" SkinID="skin1"  ></asp:Label> </td>
   <td class="style3"><asp:Label  ID="lblUserIDValue" runat="server" Width="200px" 
           SkinID="skin2"  ></asp:Label></td>
   </tr>
        <tr>
            <td align="left"><asp:Label ID="lblProblemType" runat="server" Text="Problem Type" 
                    SkinID="skin1"></asp:Label></td>
            <td class="style2">
                <asp:DropDownList ID="cmbProblemType" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="cmbProblemType_SelectedIndexChanged" Width="200px"> </asp:DropDownList></td> 
             <td> 
                 <asp:RequiredFieldValidator ID="rfvProblemType" runat="server" 
                            ErrorMessage="*" ControlToValidate="cmbProblemType" ForeColor="Red"></asp:RequiredFieldValidator></td> </td>             
        </tr>
        
        <tr>
            <td align="left"><asp:Label ID="lblSubCategory" runat="server" Text="Sub Category" 
                    SkinID="skin1"></asp:Label></td>
            <td class="style2">
                <asp:DropDownList ID="cmbSubCategory" runat="server"  onselectedindexchanged="cmbSubCategory_SelectedIndexChanged" 
                    AutoPostBack="True" Height="20px" Width="200px"></asp:DropDownList> </td> 
            <td> <asp:RequiredFieldValidator ID="rfvSubCategory" runat="server" 
                            ErrorMessage="*" ControlToValidate="cmbSubCategory" ForeColor="Red"></asp:RequiredFieldValidator></td>             
        </tr>

        <tr>
            <td align="left"><asp:Label ID="lblDepartment" runat="server" Text="Department" 
                    SkinID="skin1"></asp:Label></td>
            <td class="style2">
                <asp:DropDownList ID="cmbDepartment" runat="server" Height="20px" Width="200px" AutoPostBack="True" ></asp:DropDownList> </td>
                    <td> 
                        <asp:RequiredFieldValidator ID="rfvDepartment" runat="server" 
                            ErrorMessage="*" ControlToValidate="cmbDepartment" ForeColor="Red"></asp:RequiredFieldValidator> </td>              
        </tr>

        <tr>
            <td align="left"><asp:Label ID="lblRemarks" runat="server" Text="Remarks" 
                    SkinID="skin1"></asp:Label></td>
            <td class="style2">
                <asp:TextBox ID="txtUserRemarks" runat="server" 
                    TextMode="MultiLine" Height="50px"
                    Width="200px" ToolTip="Enter Remarks" Rows="3" AutoPostBack="True"></asp:TextBox> </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvUserRemarks" runat="server" 
                            ErrorMessage="*" ControlToValidate="txtUserRemarks" ForeColor="Red"></asp:RequiredFieldValidator> </td>
        </tr>
        <tr>
        <td align="left">
            <asp:Label ID="lblStatus" runat="server" Text="Status" SkinID="skin1"></asp:Label> </td>
            <td>
               <asp:DropDownList ID="cmbStatus"
                    runat="server" Width="86px" AutoPostBack="True" Enabled="False">
                   <asp:ListItem Value="0" Selected="True">open</asp:ListItem>
                </asp:DropDownList> </td>
        </tr>
        </table>
<table>

        <tr>
        <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                onclick="btnSubmit_Click" /></td>
                <td> 
                    &nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" 
                        onclick="btnCancel_Click" CausesValidation="False" /></td>
       </tr>
 </table> 
    </div>
    
    <div title="FaultID1"  >
<table>
         <tr>     
                <td> 
                    <asp:Label ID="lblFaultAlert" runat="server" Text="Fault Not Created" 
                        Visible="False" ForeColor="Red"></asp:Label></td>
             <td> <asp:Button ID="btnBack" runat="server" Text="Back" CausesValidation="False" 
                     onclick="btnBack_Click" Visible="False" /> </td>
        </tr>
        </table>
</div> 
</asp:Content>
