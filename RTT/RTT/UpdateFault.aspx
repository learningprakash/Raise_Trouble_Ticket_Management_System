<%@ Page Title="" Language="C#" MasterPageFile="~/RTTMasterPage.Master" Theme="Skin1" AutoEventWireup="true" CodeBehind="UpdateFault.aspx.cs" Inherits="RTT.UpdateFault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="Display" runat="server">
   
        <table class="style1" id="Display1">
            <tr>
            <td align="left">
                <asp:Label ID="lblFaultId" runat="server" Text="Fault ID" SkinID="skin1"></asp:Label> </td>
                <td>
                <asp:Label ID="lblFaultIdDisplay" runat="server" Text="Label"></asp:Label> </td>
            </tr>
            <tr>
                <td align="left">
                    <asp:Label ID="lblProblemType" runat="server" Text="Problem Type" 
                        SkinID="skin1"></asp:Label>
                </td>
                <td class="style2">
                    <asp:DropDownList ID="cmbProblemType" runat="server" AutoPostBack="True" 
                        Height="20px" onselectedindexchanged="cmbProblemType_SelectedIndexChanged" 
                        Width="200px">
                        <asp:ListItem Value="-1">select</asp:ListItem>
                        <asp:ListItem Value="0">Line issue</asp:ListItem>
                        <asp:ListItem Value="1">Service issue</asp:ListItem>
                        <asp:ListItem Value="2">Equipment issue</asp:ListItem>
                        <asp:ListItem Value="3">Billing issue</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="left">
                    <asp:Label ID="lblSubCategory" runat="server" Text="Sub Category" 
                        SkinID="skin1"></asp:Label>
                </td>
                <td class="style2">
                    <asp:DropDownList ID="cmbSubCategory" runat="server" AutoPostBack="True" 
                        Height="20px" onselectedindexchanged="cmbSubCategory_SelectedIndexChanged" 
                        Width="200px"> </asp:DropDownList></td>
                <td> <asp:RequiredFieldValidator ID="rfvSubCategory" runat="server" 
                            ErrorMessage="*" ControlToValidate="cmbSubCategory" ForeColor="Red"></asp:RequiredFieldValidator></td>             

            </tr>
            <tr>
                <td align="left">
                    <asp:Label ID="lblDepartment" runat="server" Text="Department" SkinID="skin1"></asp:Label>
                </td>
                <td class="style2">
                    <asp:DropDownList ID="cmbDepartment" runat="server" AutoPostBack="True" 
                        Height="20px" Width="200px"> </asp:DropDownList></td>
                 <td> 
                        <asp:RequiredFieldValidator ID="rfvDepartment" runat="server" 
                            ErrorMessage="*" ControlToValidate="cmbDepartment" ForeColor="Red"></asp:RequiredFieldValidator> </td>              

            </tr>
            <tr>
                <td align="left">
                    <asp:Label ID="lblRemarks" runat="server" Text="Remarks" SkinID="skin1"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtUserRemarks" runat="server" 
                        TextMode="MultiLine" Rows="3" Height="50px" Width="200px"></asp:TextBox></td>
                <td>
                        <asp:RequiredFieldValidator ID="rfvUserRemarks" runat="server" 
                            ErrorMessage="*" ControlToValidate="txtUserRemarks" ForeColor="Red"></asp:RequiredFieldValidator> </td>

            </tr>
            <tr>
                <td align="left">
                    <asp:Label ID="lblStatus" runat="server" Text="Status" SkinID="skin1"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="cmbStatus" runat="server" Width="86px" 
                        AutoPostBack="True">
                        <asp:ListItem Value="1">open</asp:ListItem>
                        <asp:ListItem Value="0">close</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
            <td align="left">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                    onclick="btnSubmit_Click" /> </td>
                    <td>
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" 
                            CausesValidation="False" onclick="btnCancel_Click" /> </td> 
             </tr>
             </table>
          </div>      

  <table cellspacing = "3" >     
      <tr>       
         <td><asp:Label ID="lblStuatesDisplay" runat="server" Text="Updated Suceesfully" 
                 Visible="False" SkinID="skin2"></asp:Label> </td>
         <td>   
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
             <asp:Button ID="btnBack" runat="server" Text="Back" Visible="False" 
                 onclick="btnBack_Click" CausesValidation="False" /> </td>
      </tr>
  </table>

</asp:Content>
