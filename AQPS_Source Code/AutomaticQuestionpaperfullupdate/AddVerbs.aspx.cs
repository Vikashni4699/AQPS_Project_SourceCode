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
public partial class AddVerbs : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    string str;
    protected void Page_Load(object sender, EventArgs e)
    {
        bindgrid();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd = new SqlCommand("insert into Verbstbl values('"+ DropDownList1.Text +"','" + TextBox1.Text + "')", con);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        con.Close();
        Response.Redirect("AddVerbs.aspx");
    }

    private void bindgrid()
    {

        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd = new SqlCommand("select * from Verbstbl", con);
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
        if (con.State == System.Data.ConnectionState.Closed)
            con.Open();
        try
        {
            str = GridView1.Rows[e.RowIndex].Cells[1].Text;
            cmd = new SqlCommand("delete from Verbstbl where id='" + str + "'", con);
            cmd.ExecuteNonQuery();
            GridView1.EditIndex = -1;
            con.Close();
            bindgrid();
        }
        catch (Exception ex)
        {

        }
    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {

    }
}
