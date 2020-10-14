<%@ Page Language="C#" MasterPageFile="~/Staffmas.master" AutoEventWireup="true" CodeFile="AddQustion.aspx.cs" Inherits="AddQustion" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
<div align=center>
<br />
 <span class="style2" style="font-weight: bold">Add Question</span>
 <br />
<table cellpadding="2" cellspacing="15" width="750" height="300">

<tr>
<td class="style1">
    <b>Question :
</b>
</td>
<td>
    <asp:TextBox ID="TextBox1" runat="server" Width="597px" Height="90px" 
        TextMode="MultiLine"></asp:TextBox>
</td>
<td> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="*"></asp:RequiredFieldValidator>

</td>
</tr>

<tr>
<td class="style1">
    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Search" />
</td>
<td>
    <asp:TextBox ID="TextBox2" runat="server" Height="34px" Width="155px" 
        Visible="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server" Height="34px" Width="155px" 
        Visible="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox4" runat="server" Height="25px" Width="155px"></asp:TextBox>
&nbsp;<asp:ListBox ID="ListBox1" runat="server" Height="20px" Width="57px" 
           Visible="False">
       </asp:ListBox></td>
</tr>

<tr>
<td class="style1">
    <b>Mark :</b>
</td>
<td>
    <asp:DropDownList ID="DropDownList2" runat="server" Height="26px" Width="198px">
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
        <asp:ListItem>6</asp:ListItem>
        <asp:ListItem>11</asp:ListItem>
    </asp:DropDownList>
</td>
</tr>

<tr>
<td class="style1">
    <b>Department :
</b>
</td>
<td>
    <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="198px">
        <asp:ListItem>BE-CSE</asp:ListItem>
        <asp:ListItem>BE-ECE</asp:ListItem>
        <asp:ListItem>BE-EEE</asp:ListItem>
        <asp:ListItem>BE-Mech</asp:ListItem>
        <asp:ListItem>BE-Civil</asp:ListItem>
        <asp:ListItem>BSc-CS</asp:ListItem>
    </asp:DropDownList>
</td>
</tr>
<tr>
<td class="style1">
    <b>Subject :
</b>
</td>
<td>
    <asp:DropDownList ID="DropDownList3" runat="server" Height="26px" Width="198px">
    </asp:DropDownList>
</td>
</tr>
<tr>
<td class="style1">
    <b>Unit :
</b>
</td>
<td>
    <asp:DropDownList ID="DropDownList4" runat="server" Height="26px" Width="198px">
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
    </asp:DropDownList>
</td>
</tr>


</table>
<br />
<table cellpadding="2" cellspacing="15">
<tr>
<td>
    <asp:Button ID="Button1" runat="server" Text="Add" onclick="Button1_Click" />
</td>
<td>
    <asp:Button ID="Button2" runat="server" Text="Cancel" />
</td>
</tr>

</table>
<br />
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
<br />

</div>

</asp:Content>

