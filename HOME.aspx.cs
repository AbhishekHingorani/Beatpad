using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;


public partial class _Default : System.Web.UI.Page
{
    Recorder recMain, rec1, rec2, rec3, rec4, rec5, rec6, rec7;
    int userId;

    protected void Page_Load(object sender, EventArgs e)
    {
        rec1 = new Recorder("1");
        rec2 = new Recorder("2");
        rec3 = new Recorder("3");
        rec4 = new Recorder("4");
        rec5 = new Recorder("5");
        rec6 = new Recorder("6");
        rec7 = new Recorder("7");
        recMain = new Recorder("recMain");

        if (Session["UserId"].ToString().Equals("0"))
        {
            CheckBox1.Enabled = false;
            enableRecBtns(false);
            HyperLink1.Text = "Login";
            HyperLink1.NavigateUrl = "~/Login.aspx";
        }
        else
        {
            CheckBox1.Enabled = true;
            userId = int.Parse(Session["UserId"].ToString());
            enableRecBtns(true);
            HyperLink1.Text = "Logout";
            HyperLink1.NavigateUrl = "~/Login.aspx";
        }
    }

    void enableRecBtns(bool val)
    {
        btn_Rec1.Enabled = val;
        btn_Rec2.Enabled = val;
        btn_Rec3.Enabled = val;
        btn_Rec4.Enabled = val;
        btn_Rec5.Enabled = val;
        btn_Rec6.Enabled = val;
        btn_Rec7.Enabled = val;
        BtnRecMain.Enabled = val;

        if (val == false)
        {
            btn_Rec1.Attributes.CssStyle.Add("background-color", "gray");
            btn_Rec2.Attributes.CssStyle.Add("background-color", "gray");
            btn_Rec3.Attributes.CssStyle.Add("background-color", "gray");
            btn_Rec4.Attributes.CssStyle.Add("background-color", "gray");
            btn_Rec5.Attributes.CssStyle.Add("background-color", "gray");
            btn_Rec6.Attributes.CssStyle.Add("background-color", "gray");
            btn_Rec7.Attributes.CssStyle.Add("background-color", "gray");
            BtnRecMain.Attributes.CssStyle.Add("background-color", "gray");
        }
    }

    protected void btn_Rec1_Click(object sender, EventArgs e)
    {
        if (rec1.IsRecorded)
            togglePlayPause(1);
        else
        {
            String btnColor = rec1.toggleRecording();
            btn_Rec1.Attributes.CssStyle.Add("background-color", btnColor);
        }
    }
    protected void btn_Rec2_Click(object sender, EventArgs e)
    {
        if (rec2.IsRecorded)
            togglePlayPause(2);
        else
        {
            String btnColor = rec2.toggleRecording();
            btn_Rec2.Attributes.CssStyle.Add("background-color", btnColor);
        }
    }
    protected void btn_Rec3_Click(object sender, EventArgs e)
    {
        if (rec3.IsRecorded)
            togglePlayPause(3);
        else
        {
            String btnColor = rec3.toggleRecording();
            btn_Rec3.Attributes.CssStyle.Add("background-color", btnColor);
        }
    }
    protected void btn_Rec4_Click(object sender, EventArgs e)
    {
        if (rec4.IsRecorded)
            togglePlayPause(4);
        else
        {
            String btnColor = rec4.toggleRecording();
            btn_Rec4.Attributes.CssStyle.Add("background-color", btnColor);
        }
    }
    protected void btn_Rec5_Click(object sender, EventArgs e)
    {
        if (rec5.IsRecorded)
            togglePlayPause(5);
        else
        {
            String btnColor = rec5.toggleRecording();
            btn_Rec5.Attributes.CssStyle.Add("background-color", btnColor);
        }
    }
    protected void btn_Rec6_Click(object sender, EventArgs e)
    {
        if (rec6.IsRecorded)
            togglePlayPause(6);
        else
        {
            String btnColor = rec6.toggleRecording();
            btn_Rec6.Attributes.CssStyle.Add("background-color", btnColor);
        }
    }
    protected void btn_Rec7_Click(object sender, EventArgs e)
    {
        if (rec7.IsRecorded)
            togglePlayPause(7);
        else
        {
            String btnColor = rec7.toggleRecording();
            btn_Rec7.Attributes.CssStyle.Add("background-color", btnColor);
        }
    }
    
    protected void BtnRecMain_Click(object sender, EventArgs e)
    {
        if (recMain.IsRecorded)
        {
            dropdown.Attributes["class"] = "dropdown";
        }
        else
        {
            String btnColor = recMain.toggleRecording();
            BtnRecMain.Attributes.CssStyle.Add("background-color", btnColor);
        }
    }

    void togglePlayPause(int val)
    {
        var myAudio = new System.Web.UI.HtmlControls.HtmlAudio();
        myAudio.Attributes.Add("autoplay", "autoplay");
        myAudio.Attributes.Add("controls", "controls");
        myAudio.Attributes.Add("loop", "loop");
        myAudio.Attributes.Add("id", "audio");
        myAudio.Src = "Beats/" + val + ".wav";
        myDivTag.Controls.Add(myAudio);
        UpdatePanel2.Update();
        ScriptManager.RegisterStartupScript(this, GetType(), "infunc", "javascript:dispatchEvent(new Event('load')); ", true);
        /*
        HtmlGenericControl myAudio = new HtmlGenericControl("audio");
        myAudio.Attributes.Add("autoplay", "true");
        myAudio.Attributes.Add("hidden", "true");
        myAudio.Attributes.Add("src","~/Beats/" + val + ".wav"); //Server.MapPath("~/Beats/") + val + ".wav";
        myDivTag.Controls.Add(myAudio);
        */

        //Literal1.Mode = LiteralMode.PassThrough;
        //Literal1.Text = "<audio autoplay controls><source src='Beats/1.wav' type='audio/mpeg'>Your browser does not support the audio tag.</audio>";
    }

    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        String str = DropDownList1.SelectedValue;
        switch (str)
        {
            case "Beats": Image1.ImageUrl = "~/icons/Beats.png"; break;
            case "Piano": Image1.ImageUrl = "~/icons/Piano.png"; break;
            case "Guitar": Image1.ImageUrl = "~/icons/Guitar.png"; break;

        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Clear();
        Response.ContentType = "application/octet-stream";
        Response.AddHeader("Content-Disposition", "attachment; filename='MyBeatpadTrack.wav'");
        Response.WriteFile(Server.MapPath(@"~/Beats/recMain.wav"));
        Response.End();
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        Response.Redirect("~/beatmaker.aspx");
    }
}