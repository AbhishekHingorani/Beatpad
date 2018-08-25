using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        Session["UserId"] = "0";
    }

    void openConnection()
    {
        String conStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename="+Server.MapPath("~")+"\\App_Data\\UserData.mdf;Integrated Security=True;Connect Timeout=30";
        con = new SqlConnection(conStr);
        
        con.Open();
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        openConnection();
        cmd.CommandText = "SELECT * FROM  UserInfo WHERE email = '" + TextBox1.Text + "';";

        dr = cmd.ExecuteReader();

        if (dr.HasRows)
        {
            dr.Read();
            if (TextBox1.Text.Equals(dr[3].ToString()) && TextBox2.Text.Equals(dr[4].ToString()))
            {
                Session["UserId"] = dr[0].ToString();

                con.Close();

                Response.Redirect("HOME.aspx");
            }
            else
            {
                Label1.Text = "&#9888; Incorrect Password...";
                clear();
            }
        }
        else
        {
            Label1.Text = "&#9888; Email Unavailable...";
            clear();
        }
        con.Close();
    }

    void clear()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
    }
}