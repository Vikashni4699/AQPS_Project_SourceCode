<%@ Page Language="C#" MasterPageFile="~/Adminmas.master" AutoEventWireup="true" CodeFile="AddVerbs.aspx.cs" Inherits="AddVerbs" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align=center>
    <asp:Label ID="Label1" runat="server" 
        Text="Verbs that demonstrate Critical Thinking" ForeColor="#CC0066"></asp:Label>
        <br />
        
<table width="350" height="80">
<tr>
<td>
    <asp:Label ID="Label2" runat="server" Text="Verbs"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList1" runat="server" Width="150px">
        <asp:ListItem>KNOWLEDGE</asp:ListItem>
        <asp:ListItem>COMPREHENSION</asp:ListItem>
        <asp:ListItem>APPLICATION</asp:ListItem>
        <asp:ListItem>ANALYSIS</asp:ListItem>
        <asp:ListItem>SYNTHESIS</asp:ListItem>
        <asp:ListItem>EVALUATION</asp:ListItem>
    </asp:DropDownList>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label3" runat="server" Text="Objective"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBox1" runat="server" Width="150px"></asp:TextBox>
</td>
<td> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="*"></asp:RequiredFieldValidator>

</td>
</tr>
</table>
<br />
<table>
<tr>
<td>
    <asp:Button ID="Button1" runat="server" Text="Add" onclick="Button1_Click" />
</td>
</tr>
</table>
<br />
<table cellpadding="2" cellspacing="15" width="750" height="200">
<tr>
<td>
     <asp:GridView ID="GridView1" runat="server" width="700px" CellPadding="4" 
        GridLines="None" onrowdeleting="GridView1_RowDeleting1" 
        onselectedindexchanging="GridView1_SelectedIndexChanging" 
         ForeColor="#333333">
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
        <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
</td>

</tr>

</table>
</div>
</asp:Content>

