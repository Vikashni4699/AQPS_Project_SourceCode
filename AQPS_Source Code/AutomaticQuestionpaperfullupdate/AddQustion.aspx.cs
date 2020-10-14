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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.IO;
using System.Net;
public partial class AddQustion : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
    SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    string str;
    protected void Page_Load(object sender, EventArgs e)
    {
        //bindgrid();
        if (!Page.IsPostBack)
        {
            DropDownList3.Items.Clear();
            cmd = new SqlCommand("select Subjectname from Subject", con);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                DropDownList3.Items.Add(dr1[0].ToString());
            }
            con.Close();
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (con.State == System.Data.ConnectionState.Closed)
            con.Open();
        cmd = new SqlCommand("insert into AddQues values('" + TextBox1.Text + "','" + DropDownList2.Text + "','" + DropDownList1.Text + "','" + DropDownList3.Text + "','" + DropDownList4.Text + "','"+ TextBox4.Text +"')", con);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        //bindgrid();
        Response.Write("<script>alert('Added')</script>");
    }

    private void bindgrid()
    {

        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd = new SqlCommand("select * from AddQues", con);
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
            cmd = new SqlCommand("delete from AddQues where Sno='" + str + "'", con);
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
    public void fun1()
    {
        if (cn.State == ConnectionState.Closed) cn.Open();
        cmd.CommandText = "truncate table tbl_stemwords";
        cmd.Connection = cn;
        cmd.ExecuteNonQuery();

        SqlCommand cmddel = new SqlCommand("delete from tbl_stemwords",cn);
        cmddel.ExecuteNonQuery();

        String pp;
        pp = TextBox2.Text;
        string[] strArr = pp.Split(' ');
        List<string> namesList = new List<string>(strArr.Length);
        namesList.AddRange(strArr);

        //Step1

        foreach (var s in namesList)
        {

            if (s.ToLower().ToString().EndsWith("ed"))
            {
                
                TextBox3.Text += " " + s.Replace("ed", "");
            }
            else if (s.ToLower().ToString().EndsWith("ing"))
            {
                if (s.ToLower().Length > 4)
                {
                    TextBox3.Text += " " + s.Replace("ing", "");
                }
                else
                {
                    TextBox3.Text += " " + s.ToString();
                }
            }
            else if (s.ToLower().ToString().EndsWith("ies"))
            {

                TextBox3.Text += " " + s.Replace("ies", "y");
            }
            else if (s.ToLower().ToString().EndsWith("sses"))
            {

                TextBox3.Text += " " + s.Replace("sses", "ss");
            }
            else if (s.ToLower().ToString().EndsWith("ies"))
            {

                TextBox3.Text += " " + s.Replace("ies", "i");
            }
            else
            {
                TextBox3.Text += " " + s.ToLower().ToString();
            }
        }




        //Step2
        String pp1;
        pp1 = TextBox3.Text;
        string[] strArr1 = pp1.Split(' ');
        List<string> namesList1 = new List<string>(strArr1.Length);
        namesList1.AddRange(strArr1);
        TextBox3.Text = "";
        foreach (var s in namesList1)
        {
            if (s.ToLower().ToString().EndsWith("ational"))
            {
                TextBox3.Text += " " + s.Replace("ational", "ate");
            }
            else if (s.ToLower().ToString().EndsWith("tional"))
            {
                TextBox3.Text += " " + s.Replace("tional", "tion");
            }
            else if (s.ToLower().ToString().EndsWith("enci"))
            {
                TextBox3.Text += " " + s.Replace("enci", "ence");
            }
            else if (s.ToLower().ToString().EndsWith("izer"))
            {
                TextBox3.Text += " " + s.Replace("izer", "ize");
            }
            else if (s.ToLower().ToString().EndsWith("abli"))
            {
                TextBox3.Text += " " + s.Replace("abli", "able");
            }
            else if (s.ToLower().ToString().EndsWith("alli"))
            {
                TextBox3.Text += " " + s.Replace("alli", "al");
            }
            else if (s.ToLower().ToString().EndsWith("entli"))
            {
                TextBox3.Text += " " + s.Replace("entli", "ent");
            }
            else if (s.ToLower().ToString().EndsWith("eli"))
            {
                TextBox3.Text += " " + s.Replace("eli", "e");
            }
            else if (s.ToLower().ToString().EndsWith("ousli"))
            {
                TextBox3.Text += " " + s.Replace("ousli", "ous");
            }
            else if (s.ToLower().ToString().EndsWith("ation"))
            {
                TextBox3.Text += " " + s.Replace("ation", "ate");
            }
            else if (s.ToLower().ToString().EndsWith("fulness"))
            {
                TextBox3.Text += " " + s.Replace("fulness", "ful");
            }
            else if (s.ToLower().ToString().EndsWith("biliti"))
            {
                TextBox3.Text += " " + s.Replace("biliti", "ble");
            }
            else
            {
                TextBox3.Text += " " + s.ToLower().ToString();
            }
        }



        //Step3
        String pp2;
        pp2 = TextBox3.Text;
        string[] strArr2 = pp2.Split(' ');
        List<string> namesList2 = new List<string>(strArr2.Length);
        namesList2.AddRange(strArr2);
        TextBox3.Text = "";
        foreach (var s in namesList2)
        {
            if (s.ToLower().ToString().EndsWith("icate"))
            {
                TextBox3.Text += " " + s.Replace("icate", "ic");
            }
            else if (s.ToLower().ToString().EndsWith("ative"))
            {
                TextBox3.Text += " " + s.Replace("ative", "");
            }
            else if (s.ToLower().ToString().EndsWith("alize"))
            {
                TextBox3.Text += " " + s.Replace("alize", "al");
            }
            else if (s.ToLower().ToString().EndsWith("iciti"))
            {
                TextBox3.Text += " " + s.Replace("iciti", "ic");
            }
            else if (s.ToLower().ToString().EndsWith("ical"))
            {
                TextBox3.Text += " " + s.Replace("ical", "ic");
            }
            else if (s.ToLower().ToString().EndsWith("ful"))
            {
                TextBox3.Text += " " + s.Replace("ful", "");
            }
            else if (s.ToLower().ToString().EndsWith("ness"))
            {
                TextBox3.Text += " " + s.Replace("ness", "");
            }
            else
            {
                TextBox3.Text += " " + s.ToLower().ToString();
            }
        }





        //Step4
        String pp3;
        pp3 = TextBox3.Text;
        string[] strArr3 = pp3.Split(' ');
        List<string> namesList3 = new List<string>(strArr3.Length);
        namesList3.AddRange(strArr3);
        TextBox3.Text = "";
        foreach (var s in namesList3)
        {
            if (s.ToLower().ToString().EndsWith("al"))
            {
                TextBox3.Text += " " + s.Replace("al", "e");
            }
            else if (s.ToLower().ToString().EndsWith("ance"))
            {
                TextBox3.Text += " " + s.Replace("ance", "");
            }
            else if (s.ToLower().ToString().EndsWith("ence"))
            {
                TextBox3.Text += " " + s.Replace("ence", "");
            }
            else if (s.ToLower().ToString().EndsWith("er"))
            {
                TextBox3.Text += " " + s.Replace("er", "");
            }
            else if (s.ToLower().ToString().EndsWith("ic"))
            {
                TextBox3.Text += " " + s.Replace("ic", "");
            }
            else if (s.ToLower().ToString().EndsWith("able"))
            {
                TextBox3.Text += " " + s.Replace("able", "");
            }
            else if (s.ToLower().ToString().EndsWith("ible"))
            {
                TextBox3.Text += " " + s.Replace("ible", "e");
            }
            else if (s.ToLower().ToString().EndsWith("ant"))
            {
                TextBox3.Text += " " + s.Replace("ant", "");
            }
            else if (s.ToLower().ToString().EndsWith("ement"))
            {
                TextBox3.Text += " " + s.Replace("ement", "e");
            }
            else if (s.ToLower().ToString().EndsWith("ment"))
            {
                TextBox3.Text += " " + s.Replace("ment", "");
            }
            else if (s.ToLower().ToString().EndsWith("ent"))
            {
                TextBox3.Text += " " + s.Replace("ent", "");
            }
            else if (s.ToLower().ToString().EndsWith("ou"))
            {
                TextBox3.Text += " " + s.Replace("ou", "");
            }
            else if (s.ToLower().ToString().EndsWith("ate"))
            {
                TextBox3.Text += " " + s.Replace("ate", "e");
            }
            else if (s.ToLower().ToString().EndsWith("iti"))
            {
                TextBox3.Text += " " + s.Replace("iti", "");
            }
            else
            {
                TextBox3.Text += " " + s.ToLower().ToString();
            }
        }


        //Step5

        String pp4;
        pp4 = TextBox3.Text;
        string[] strArr4 = pp4.Split(' ');
        List<string> namesList4 = new List<string>(strArr4.Length);
        namesList4.AddRange(strArr4);
        TextBox3.Text = "";
        string strText = "";
        foreach (var s in namesList4)
        {
            if (s.ToLower().ToString().EndsWith("s"))
            {
                if (s.ToString().Length > 4)
                {
                    TextBox3.Text += " " + s.Substring(0, s.LastIndexOf("s"));
                    strText = s.Substring(0, s.LastIndexOf("s"));
                }
                else
                {
                    TextBox3.Text += s.ToString();
                    strText = s.ToString();
                }
            }
            else
            {
                TextBox3.Text += " " + s.ToLower().ToString();
                strText = s.ToLower().ToString();
            }
            if (s.ToString() != "")
            {
                if (cn.State == ConnectionState.Closed) cn.Open();
                cmd.CommandText = "insert into tbl_stemwords values('" + strText.ToString() + "')";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }

        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //TextBox0.Text = Session["Msg"].ToString();
        SqlCommand cmdStopWords = new SqlCommand("select * from tbl_stopwords", cn);
        if (cn.State == ConnectionState.Closed) cn.Open();
        SqlDataReader dr;
        dr = cmdStopWords.ExecuteReader();
        while (dr.Read())
        {
            ListBox1.Items.Add(dr[0].ToString());
        }
        dr.Close();
        cn.Close();

        String pp;
        //pp = "\r\n\r\n1\r\n23\r\n\r\n4";
        pp = TextBox1.Text;
        pp = pp.Replace("\r\n\r\n", "\r\n");
        pp = pp.Replace("\n\n", " ");
        pp = pp.Replace("\n", " ");
        string strDelim = " ,.-/\':;~!@#$%&*()";
        string[] strArr = pp.Split(strDelim.ToCharArray());
        strArr = strArr.Where(x => !string.IsNullOrEmpty(x)).ToArray();

        List<string> namesList = new List<string>(strArr.Length);

        namesList.AddRange(strArr);
        foreach (var s in namesList)
        {

            //  if (s.ToLower().ToString() == "a" || s.ToLower().ToString() == "that" || s.ToLower().ToString() == "the" || s.ToLower().ToString() == "to" || s.ToLower().ToString() == "an" || s.ToLower().ToString() == "for" || s.ToLower().ToString() == "on" || s.ToLower().ToString() == "was" || s.ToLower().ToString() == "has" || s.ToLower().ToString() == "are" || s.ToLower().ToString() == "by" || s.ToLower().ToString() == "it" || s.ToLower().ToString() == "of" || s.ToLower().ToString() == "and")
            if (ListBox1.Items.IndexOf(ListBox1.Items.FindByValue(s.ToLower().ToString())) > -1)
            {

            }
            else
            {
                TextBox2.Text += " " + s.ToLower().ToString();
            }
        }
        fun1();
        fun3();


        try
        {
            SqlCommand cmdselect = new SqlCommand("select verbs from verbstbl v join score s on v.id=s.opid", cn);
            SqlDataReader dr12 = cmdselect.ExecuteReader();
            if (dr12.Read())
            {
                TextBox4.Text = dr12[0].ToString();
            }
            else
            {
                TextBox4.Text = "None";
            }
            dr12.Close();
            TextBox2.Text = "";
            TextBox3.Text = ""; 
        }
        catch (Exception er)
        {
        }
    }
    public void fun3()
    {
        if (cn.State == ConnectionState.Closed) cn.Open();
        SqlCommand cmddel1 = new SqlCommand("delete from score", cn);

        cmddel1.ExecuteNonQuery();
        if (cn.State == ConnectionState.Closed) cn.Open();
        DataSet ds1 = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter("select a.*,b.* from tbl_stemwords a left join Verbstbl b on a.stemwords like '%'+b.Objectives+'%' ", cn);
        da.Fill(ds1);
        //GridView1.DataSource = ds1.Tables[0];
        foreach (DataRow drappname in ds1.Tables[0].Rows)
        {
            if (drappname[2].ToString() == null || drappname[2].ToString().Equals("")) drappname[2] = 0;
            if (drappname[4].ToString() == null || drappname[4].ToString().Equals("")) drappname[4] = 0;


            SqlCommand cmdins = new SqlCommand("insert into score values('" + drappname[0].ToString() + "','" + drappname[1].ToString() + "','" + drappname[2].ToString() + "','" + drappname[4].ToString() + "')", cn);
            cmdins.ExecuteNonQuery();

        }

    }
}
