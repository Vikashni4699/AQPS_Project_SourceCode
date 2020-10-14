<%@ Page Language="C#" MasterPageFile="~/Adminmas.master" AutoEventWireup="true" CodeFile="Addstaff.aspx.cs" Inherits="NewUser" Title="Automatic Question paper generation" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
<div align=center>
<br />
 <span class="style2" style="font-weight: bold">Add Staff Details</span>
 <br />
<table cellpadding="2" cellspacing="15" height="300">

<tr>
<td class="style1">
    <b>Full Name :
</b>
</td>
<td>
    <asp:TextBox ID="TextBox1" runat="server" Width="197px"></asp:TextBox>
</td>

<td style="width: 338px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="*"></asp:RequiredFieldValidator>
    </td>
</tr>

<tr>
<td class="style1">
    <b>User Id :</b>
</td>
<td>
    <asp:TextBox ID="TextBox2" runat="server" Width="197px"></asp:TextBox>
</td>
<td style="width: 338px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
            ErrorMessage="*"></asp:RequiredFieldValidator>
    </td>
</tr>

<tr>
<td class="style1">
    <b>Password :
</b>
</td>
<td>
    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="197px"></asp:TextBox>
</td>
<td style="width: 338px">
    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Password must contain: Minimum 8 characters atleast 1 Alphabet and 1 Number "
     ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$" ControlToValidate="TextBox3"></asp:RegularExpressionValidator>
</td>
</tr>

<tr>
<td class="style1">
    <b>Address :
</b>
</td>
<td>
    <asp:TextBox ID="TextBox4" runat="server" Height="68px" TextMode="MultiLine" 
        Width="197px"></asp:TextBox>
</td>
<td style="width: 338px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4"
            ErrorMessage="*"></asp:RequiredFieldValidator>
    </td>
</tr>

<tr>
<td class="style1">
    <b>Mobile :
</b>
</td>
<td>
    <asp:TextBox ID="TextBox5" runat="server" Height="22px" Width="197px"></asp:TextBox>
</td>
<td style="width: 338px">
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="*" ControlToValidate="TextBox5" 
    ValidationExpression="[0-9]{10}" ></asp:RegularExpressionValidator>
</td>
</tr>

<tr>
<td class="style1">
    <b>Email Id :
</b>
</td>
<td>
    <asp:TextBox ID="TextBox6" runat="server" Width="197px"></asp:TextBox>
</td>
<td style="width: 338px">
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox6" 
    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    
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
        <asp:ListItem>BE-Mech</asp:ListItem>
        <asp:ListItem>BE-EEE</asp:ListItem>
        <asp:ListItem>BE-Civil</asp:ListItem>
        <asp:ListItem>BSc-CS</asp:ListItem>
    </asp:DropDownList>
</td>
</tr>


</table>

<table cellpadding="2" cellspacing="15">
<tr>
<td>
    <asp:ImageButton ID="ImageButton1" runat="server" Height="38px" 
        ImageUrl="~/img/bureg.jpg" Width="117px" onclick="ImageButton1_Click" />
</td>
<td>
    <asp:ImageButton ID="ImageButton2" runat="server" Height="38px" 
        ImageUrl="~/img/burcancel.jpg" Width="117px" />
</td>
</tr>

</table>
<br />
<br />

</div>

</asp:Content>

