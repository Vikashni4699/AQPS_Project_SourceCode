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
using System.Net;
using System.IO;
using System.Text;
public partial class NewUser : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
   
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
                
        con.Open();
        cmd = new SqlCommand("select Userid from Staff where Userid='" + TextBox2.Text + "'", con);
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Response.Write("<script>alert('The user id are Already Exist')</script>");
            cmd.Dispose();
            dr.Close();
        }
        else
        {
            try
           {
                dr.Close();
                cmd = new SqlCommand("insert into Staff values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + DropDownList1.Text + "')", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                Response.Write("<script>alert('Added')</script>");


               
           }
            catch
            {


            }

        }
        con.Close();
    }
}
