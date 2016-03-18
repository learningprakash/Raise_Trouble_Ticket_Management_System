<%@ Page Title="" Language="C#" MasterPageFile="~/RTTMasterPage.Master" Theme="Skin1" AutoEventWireup="true" CodeBehind="FaultManagement.aspx.cs" Inherits="RTT.FaultManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div style="width: 602px">
        <table class="style1" width="100%">
            <tr>
                <td align="center" colspan="5">
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
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="center" colspan="5">
                    <asp:Label ID="Label2" runat="server" Text="View Faults" SkinID="skin1"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style2" align="right">
                    <asp:Label ID="lblUserId" runat="server" Text="User ID" SkinID="skin1"></asp:Label>
                </td>
                <td colspan="2" style="margin-left: 40px">
                    <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
                </td>
                <td>
                </td>
            </tr>
        </table>
    </div>
    <div id="Faults" runat="server">
        <table class="style1"  width="100%">
            
            <tr>
            <td colspan="3">
                &nbsp;</td>
            </tr>
            <tr>
            <td class="style7">
                </td>
            <td align="right" class="style8">
                <asp:Label ID="LblStatus" runat="server" Text="Filter By Status" SkinID="skin1"></asp:Label>
            </td>
            <td class="style9">
                <asp:DropDownList ID="cmbStatus" runat="server" 
                    onselectedindexchanged="cmbStatus_SelectedIndexChanged" 
                    AutoPostBack="True">
                    <asp:ListItem Selected="True">Both</asp:ListItem>
                    <asp:ListItem Value="1">Open</asp:ListItem>
                    <asp:ListItem Value="0">Closed</asp:ListItem>
                </asp:DropDownList>
            </td>
            </tr>
            <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style6" align="right">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            </tr>
            <tr>
            <td class="style5">
                <asp:Button ID="btnback" runat="server" onclick="btnback_Click" Text="Back" />
            </td>
            <td class="style6" align="right">
                <asp:Label ID="LblPhoneNo" runat="server" Text="Phone No" SkinID="skin1"></asp:Label>
            </td>
            <td class="style4">
                <asp:Label ID="LblCustPhoneNo" runat="server" Text="123456789" 
                    ForeColor="#3366CC"></asp:Label>
            </td>
            </tr>
            <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style6" align="right">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" colspan="3" align="center">
                    <asp:GridView ID="gvFaults" runat="server" 
                       onrowdeleting="gvFaults_RowDeleting" BackColor="White" 
                        BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" onselectedindexchanged="gvFaults_SelectedIndexChanged"
                        >
                        <Columns>
                            <asp:HyperLinkField DataNavigateUrlFields="FaultId" 
                                DataNavigateUrlFormatString="ViewFault.aspx?FaultId={0} " HeaderText="View" 
                                Text="View" />
                         <asp:TemplateField HeaderText="Action">
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkButton" runat="server" Text="" ></asp:LinkButton>
                            </ItemTemplate> 
                        </asp:TemplateField>

                        </Columns>
                        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" ForeColor="#003399" />
                        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SortedAscendingCellStyle BackColor="#EDF6F6" />
                        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                        <SortedDescendingCellStyle BackColor="#D6DFDF" />
                        <SortedDescendingHeaderStyle BackColor="#002876" />
                    </asp:GridView>
                    <br />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
