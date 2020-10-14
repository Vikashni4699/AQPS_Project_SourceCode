<%@ Page Language="C#" MasterPageFile="~/Homemas.master" AutoEventWireup="true" CodeFile="Adminlogin.aspx.cs" Inherits="hodlogin" Title="Untitled Page" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div align=center>
    <asp:Label ID="Label1" runat="server" Text="Admin Login" Font-Bold="True" 
            Font-Size="Medium"></asp:Label>
    <br />
    <tr align=center>
    <td>
    <table cellpadding="5" cellspacing="5" width="300" height="65">
    <tr>
    <td class="style2">
        <span class="style1" 
            style="font-family: 'Bodoni MT'; font-weight: bold; font-size: large">User Name :</span>
    </td>
    <td>
        <asp:TextBox ID="TextBox1" runat="server" Width="190px"></asp:TextBox>
    </td>
    <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="*"></asp:RequiredFieldValidator>

</td>
    </tr>
    <tr>
    <td class="style2">
        <span class="style1" style="font-family: 'Bodoni MT'; font-weight: bold; font-size: large">Password :</span>
    </td>
    <td>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="190px"></asp:TextBox>
    </td>
    <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
            ErrorMessage="*"></asp:RequiredFieldValidator>

</td>
    </tr>
    </table>
    <table>
    <tr>
    <td>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="32px" 
            ImageUrl="~/img/login.jpg" Width="111px" onclick="ImageButton1_Click" />
    </td>
    <td>
        <asp:ImageButton ID="ImageButton2" runat="server" Height="32px" 
            ImageUrl="~/img/burcancel.jpg" Width="111px" 
            onclick="ImageButton2_Click" />
    </td>
    </tr>
    </table>
    
    </td>
    </tr>
    <table>
    <tr>
    <td>
       
    </td>
    </tr>
    </table>
    </div>
</asp:Content>

