<%@ Page Language="C#" MasterPageFile="~/Staffmas.master" AutoEventWireup="true" CodeFile="GenerateQus.aspx.cs" Inherits="GenerateQus" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align=center>
    <asp:Label ID="Label1" runat="server" Text="Generate Question" Font-Bold="True" 
        Font-Names="Arabic Typesetting" Font-Size="XX-Large"></asp:Label>
    <br />
    <table cellpadding="5" cellspacing="5" width="300" Height="50">
    <tr>
    <td style="height: 22px">
        <asp:Label ID="Label2" runat="server" Text="Subject"></asp:Label>
    </td>
    <td style="height: 22px">
        <asp:DropDownList ID="DropDownList1" runat="server" Width="180px">
        </asp:DropDownList>
    </td>
      <td style="height: 22px">
        <asp:Label ID="Label3" runat="server" Text="Mark"></asp:Label>
    </td>
    <td style="height: 22px">
        <asp:DropDownList ID="DropDownList2" runat="server" Width="150px">
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
        </asp:DropDownList>
    </td>
      <td style="height: 22px">
        <asp:Label ID="Label4" runat="server" Text="Unit"></asp:Label>
    </td>
    <td style="height: 22px">
        <asp:DropDownList ID="DropDownList3" runat="server" Width="150px">
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
    <table width="700" Height="50">
     <tr>
      
    <td>
    <asp:Label ID="Label6" runat="server" Text="Question paper name"></asp:Label>
    
    </td>
    <td>
        <asp:TextBox ID="TextBox2" runat="server" Width="160px"></asp:TextBox>
    
    </td>
    <td>
    <asp:Label ID="Label5" runat="server" Text="Enter No of Question"></asp:Label>
    
    </td>
    <td>
        <asp:TextBox ID="TextBox1" runat="server" Width="160px"></asp:TextBox>
    
    </td>
      <td>
          <asp:Button ID="Button1" runat="server" Text="Search" onclick="Button1_Click" />
    </td>
    <td>
          <asp:Button ID="Button3" runat="server" Text="Add" onclick="Button3_Click" />
    </td>
    </tr>
    </table>
     <br />
    
<table cellpadding="2" cellspacing="15" width="750" height="200">
<tr>
<td>
     <asp:GridView ID="GridView1" runat="server" width="700px" CellPadding="4" 
        GridLines="None" onrowdeleting="GridView1_RowDeleting1" 
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
<table>
<tr>
<td>
    <asp:DropDownList ID="DropDownList4" runat="server" Width="100px">
    </asp:DropDownList>
</td>
<td>
    <asp:Button ID="Button2" runat="server" Text="Generate Question" 
        onclick="Button2_Click" Width="150px" />
</td>
</tr>
</table>
 <br />
</div>
</asp:Content>

