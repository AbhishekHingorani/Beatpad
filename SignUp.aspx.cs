using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class SignUp : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    void openConnection()
    {
        String conStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + Server.MapPath("~") + "\\App_Data\\UserData.mdf;Integrated Security=True;Connect Timeout=30";
        con = new SqlConnection(conStr);
        con.Open();
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox5.Text.Equals(TextBox4.Text) == false)
        {
            Label1.Text = "&#9888; Passwords don't match...";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox4.Focus();
            return;
        }

        if (checkEmailAvailability() == false)
        {
            Label1.Text = "&#9888; E-mail already taken...";
            TextBox3.Text = "";
            TextBox3.Focus();
            return;
        }

        openConnection();

        cmd.CommandText = "INSERT into UserInfo (FirstName,LastName,email,password) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
        if (cmd.ExecuteNonQuery() >= 1)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Your account has been created.');window.location ='Login.aspx';", true);
            //Response.Redirect("Login.aspx");
        }
        else
            Label1.Text = "&#9888; Cannot Signup";

        con.Close();
    }

    bool checkEmailAvailability()
    {
        openConnection();
        bool available=true;

        cmd.CommandText = "SELECT email FROM  UserInfo";

        dr = cmd.ExecuteReader();

        while(dr.Read())
        {
            if (dr[0].ToString().Equals(TextBox3.Text))
            {
                available = false;
            }
        }
        con.Close();
        return available;
    }
}