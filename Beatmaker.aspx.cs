using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

public partial class Beatmaker : System.Web.UI.Page
{
    List<Button> btnList = new List<Button>();
    Recorder recMain;

    protected void Page_Load(object sender, EventArgs e)
    {
        recMain = new Recorder("recMain");
        generateDynamicbtns();
        refreshBtnList();
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
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        
        int currentBeat = int.Parse(Session["Counter"].ToString());
        int prevBeat = currentBeat - 1;

        if(currentBeat == btnList.Count)
        {
            Session["Counter"] = "0";
            currentBeat = 0;
        }

        if(currentBeat == 0)
            prevBeat = btnList.Count - 1;

        String arr = "";
        for (int i = 0; i < btnList.Count; i++)
        {
            arr += ((Button)btnList[i]).ID + ",  ";
        }

        Button btn = (Button)(btnList[prevBeat]);
        if (btn.Text == " ")
        {
            btn.Attributes.CssStyle.Add("background-color", "rgba(128, 128, 128, 0.5)");
        }
        else
        {
            btn.Attributes.CssStyle.Add("background-color", "firebrick");
            btn.Attributes.CssStyle.Add("color", "white");
        }

        btn = (Button)(btnList[currentBeat]);
        btn.Attributes.CssStyle.Add("background-color", "white");
        btn.Attributes.CssStyle.Add("color", "black");

        if (!btn.Text.Equals(" ") || !btn.Text.Equals(""))
            ScriptManager.RegisterStartupScript(this,GetType(), "infunc", "javascript:PlaySound('"+btn.Text+".wav'); ", true);

        Session["Counter"] = (currentBeat + 1) + "";
    }

    void refreshBtnList()
    {
        btnList = new List<Button>();

        foreach (Control c in DivBeatmaker.Controls)
        {
            if (c.GetType() == typeof(Button))
            {
                ((Button)c).Click += (sd, ev) =>
                {
                    // Do whatever you want to be done on click here.
                    Button me = (Button)sd; // This creates a self-reference to this button, so you can get info like button ID, caption... and use, like this:
                    if (me.Text.Equals("") || me.Text.Equals(" "))
                    {
                        if (Session["currentSelectedBtn"] != null)
                        {
                            me.Text = Session["currentSelectedBtn"].ToString();
                            me.Attributes.CssStyle.Add("background-color", "firebrick");
                            me.Attributes.CssStyle.Add("color", "white");
                        }
                    }
                    else
                    {
                        me.Text = " ";
                        me.Attributes.CssStyle.Add("background-color", "rgba(128, 128, 128, 0.5)");
                        me.Attributes.CssStyle.Add("color", "black");
                    }

                    //Timer1.Enabled = false;
                };

                btnList.Add((((Button)c)));
            }
        }
    }

    protected void play_Click(object sender, EventArgs e)
    {
        Timer1.Enabled = true;
    }

    protected void pause_Click(object sender, EventArgs e)
    {
        Timer1.Enabled = false;
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        Timer1.Interval = int.Parse(TextBox1.Text);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);

    }
    protected void ButtonW_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonE_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonR_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonT_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonY_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonU_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonA_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonS_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonD_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonF_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonG_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonH_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonJ_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonZ_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonX_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonC_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonV_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonB_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonN_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }
    protected void ButtonM_Click(object sender, EventArgs e)
    {
        changeBtnColor((Button)sender);
    }

    void changeBtnColor(Button btn)
    {
        Timer1.Enabled = false;
        Session["currentSelectedBtn"] = btn.ID.Substring(6);

        foreach (Control c in tableBtns.Controls)
        {
            if (c.GetType() == typeof(Button))
                ((Button)c).Attributes.CssStyle.Add("background-color", "#555555");
        }

        btn.Attributes.CssStyle.Add("background-color", "#008CBA;");
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["Counter"] = "0";
        /*
        ScriptManager.RegisterStartupScript(this, GetType(), "infunc", "javascript:alert('" + btnList.Count + "    " + int.Parse(DropDownList2.SelectedItem.ToString()) + "'); ", true);
        generateDynamicbtns();
        refreshBtnList();
         */ 
    }

    void generateDynamicbtns()
    {
        int num=0;

        if (Page.IsPostBack)
            num = btnList.Count;

        for (int i = num + 1; i <= int.Parse(DropDownList2.SelectedItem.ToString()); i++)
        {
           // ScriptManager.RegisterStartupScript(this, GetType(), "infunc", "javascript:alert('" + i + "'); ", true);
            Button btn = new Button();
            btn.ID = "bm-" + Convert.ToString(i);
            btn.Text = " ";
            btn.Attributes["class"] = "btnBeat";
            DivBeatmaker.Controls.Add(btn);

            if (i == 15 || i == 30 || i == 45 || i == 60 || i == 75)
            {
                DivBeatmaker.Controls.Add(new LiteralControl("<br />"));
            }
        }
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        Response.Redirect("~/Home.aspx");
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
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Clear();
        Response.ContentType = "application/octet-stream";
        Response.AddHeader("Content-Disposition", "attachment; filename='MyBeatpadTrack.wav'");
        Response.WriteFile(Server.MapPath(@"~/Beats/recMain.wav"));
        Response.End();
    }
}