<%@ Page Language="C#" MasterPageFile="~/Homemas.master" AutoEventWireup="true" CodeFile="Userlogin.aspx.cs" Inherits="studentlogin" Title="Untitled Page" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div align=center>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Staff Login" Font-Bold="True" 
            Font-Size="Large"></asp:Label>
    <br />
     
    <tr align=center>
    <td>
      <br />
    <table cellpadding="5" cellspacing="15" width="300" height="65">
    <tr>
    <td class="style2">
        <span class="style1">User Id :</span>
    </td>
    <td>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td class="style2" style="height: 30px">
        <span class="style1">Password :</span>
    </td>
    <td style="height: 30px">
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
    </td>
    </tr>
    
    </table>
    <br />
    <table>
    <tr>
    <td>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="32px" 
            ImageUrl="~/img/login.jpg" Width="111px" onclick="ImageButton1_Click" />
    </td>
    <td>
        <asp:ImageButton ID="ImageButton2" runat="server" Height="32px" 
            ImageUrl="~/img/burcancel.jpg" Width="111px" />
    </td>
    </tr>
    </table>
     <table>
    <tr>
    <td>
        
    </td>
 
    </tr>
    </table>
    </td>
    </tr>
    </div>
</asp:Content>

