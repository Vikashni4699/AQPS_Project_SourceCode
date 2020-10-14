using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using CrystalDecisions.Enterprise;
using System.Web;
using CrystalDecisions.Shared;
public partial class Viewrpt : System.Web.UI.Page
{
     SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
    SqlCommand cmd = new SqlCommand();
    ReportDocument TestReport=new ReportDocument();
        
    SqlDataReader dr;
    SqlDataAdapter da;
    DataSet ds;
    DataTable dt;
    string strpath;
    protected void Page_Load(object sender, EventArgs e)
    {
    da =new SqlDataAdapter("SELECT * FROM Genqus WHERE Qusname = '" + Session["qname"].ToString() + "' ", con);
        if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
        ds = new DataSet();
        dt = new DataTable();
        da.Fill(dt);
       
       
        TestReport.Load(Server.MapPath("~/Qusrpt.rpt"));
        TestReport.SetDataSource(dt);
        CrystalReportViewer1.ReportSource = TestReport;
        CrystalReportViewer1.RefreshReport();
        con.Close();
    }
}
