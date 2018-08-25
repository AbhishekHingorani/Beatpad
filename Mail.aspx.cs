using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Mail : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataReader dr;

    string name;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            openConnection();
            cmd.CommandText = "select firstname,lastname from UserInfo where userid=" + Session["UserId"];
            dr = cmd.ExecuteReader();
            dr.Read();
            name = dr[0].ToString() + " " + dr[1].ToString();
            con.Close();

            TextBox2.Text = name + "'s Beatpad track.";
            TextBox3.Text = "Hey, Listen to this awsome track that I created using the 'Beatpad'!";
        }
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
        SendMail mail = new SendMail(TextBox1.Text, TextBox2.Text, TextBox3.Text);
        bool sent = mail.send();

        if (sent)
        {
            Label1.Text = "&#10003; Sent Successfully...";
        }
        else
        {
            Label1.Text = "&#9888; Cannot Send...";
        }
    }
}