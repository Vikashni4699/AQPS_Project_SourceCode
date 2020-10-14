<%@ Page Language="C#" MasterPageFile="~/Staffmas.master" AutoEventWireup="true" CodeFile="Viewrpt.aspx.cs" Inherits="Viewrpt" Title="Untitled Page" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align=center>
   
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
            AutoDataBind="True" Height="1119px" ReportSourceID="CrystalReportSource1" 
            Width="878px" />
        <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
            <Report FileName="Qusrpt.rpt">
            </Report>
        </CR:CrystalReportSource>
       
</div>
</asp:Content>

