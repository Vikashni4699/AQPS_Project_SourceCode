<%@ Page Language="C#" MasterPageFile="~/Adminmas.master" AutoEventWireup="true" CodeFile="Addsubject.aspx.cs" Inherits="Addsubject" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align=center>
<table>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" Text="Add Subject"></asp:Label>
</td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:Label ID="Label2" runat="server" Text="Subject name"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</td>
    <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="*"></asp:RequiredFieldValidator>

</td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:Button ID="Button1" runat="server" Text="Add" onclick="Button1_Click" />
</td>
<td>
    <asp:Button ID="Button2" runat="server" Text="Delete All" 
        onclick="Button2_Click" />
</td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
        GridLines="None" onrowdeleting="GridView1_RowDeleting">
        <RowStyle BackColor="#E3EAEB" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
</td>
</tr>
</table>
</div>
</asp:Content>

