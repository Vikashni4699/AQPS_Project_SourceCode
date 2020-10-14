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
public partial class studentlogin : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
      
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
       

        con.Open();
        cmd = new SqlCommand("select * from Staff where Userid='" + TextBox1.Text + "' and pwd='" + TextBox2.Text + "'", con);

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Session["User"] = TextBox1.Text;

            Response.Redirect("Staffhome.aspx");
        }
        else
        {
            Response.Write("<script>alert('Username password Error. pls Try Again Later')</script>");
        }
        con.Close();
    }
}
