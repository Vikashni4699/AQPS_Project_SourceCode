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
public partial class GenerateQus : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    string str;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DropDownList1.Items.Clear();
            cmd = new SqlCommand("select Subjectname from Subject", con);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                DropDownList1.Items.Add(dr1[0].ToString());
            }
            con.Close();
        }

        if (!Page.IsPostBack)
        {
            DropDownList4.Items.Clear();
            cmd = new SqlCommand("select distinct(Qusname) from Genqus", con);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            SqlDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                DropDownList4.Items.Add(dr2[0].ToString());
            }
            con.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "" && TextBox2.Text == "")
        {
            Response.Write("<script>alert('pls Enter no Question')</script>");
        }

        else
        {
            bindgrid();
        }
      
    }

     private void bindgrid()
    {

        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
     
        cmd = new SqlCommand("SELECT TOP "+ TextBox1.Text +" * FROM AddQues where  Sub='"+ DropDownList1.Text +"' and Mark='"+ DropDownList2.Text +"' and Unit='"+ DropDownList3.Text +"' ORDER By NEWID() ", con);
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
    }
     protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
     {

     }
     protected void Button3_Click(object sender, EventArgs e)
     {
         
         for (int i = 0; i <= GridView1.Rows.Count-1; i++)
         {
             string qus = GridView1.Rows[i].Cells[2].Text;
             string mark = GridView1.Rows[i].Cells[3].Text;

             string dept = HttpUtility.HtmlDecode(GridView1.Rows[i].Cells[4].Text);
             string sub = GridView1.Rows[i].Cells[5].Text;

             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             cmd = new SqlCommand("insert into Genqus values('" + qus + "','" + mark + "','" + dept + "','" + sub + "','"+ TextBox2.Text +"')", con);
             cmd.ExecuteNonQuery();
             cmd.Dispose();
         }
         Response.Redirect("GenerateQus.aspx");
     }
     protected void Button2_Click(object sender, EventArgs e)
     {
         Session["qname"] = DropDownList4.Text;
         Response.Redirect("Viewrpt.aspx");
     }
}
