using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSCore;
using CSCore.SoundIn;
using CSCore.Codecs.WAV;

/// <summary>
/// Summary description for Recorder
/// </summary>
public class Recorder
{
    private WasapiCapture capture = null;
    private WaveWriter w = null;

    private String wc;
    private String ww;
    private String flag;
    private String path;

	public Recorder(String BtnName)
	{
        wc = BtnName + "wc";
        ww = BtnName + "ww";
        flag = BtnName + "flag";
        path = System.Web.HttpContext.Current.Server.MapPath("~") + "/Beats/" + BtnName + ".wav";
    }
    
    public String toggleRecording()
    {
        String btnColor = "";

        if (stopRecording()) //isStopped
        {
            startRecording();
            btnColor = "#008CBA"; //blue
        }
        else
        {
            stopRecording();
            btnColor = "#f44336"; //red
        }
        increaseFlag();

        return btnColor;
    }

    public bool stopRecording()
    {
        bool isStopped = false;

        if (System.Web.HttpContext.Current.Session[ww] != null && System.Web.HttpContext.Current.Session[wc] != null)
        {
            capture = (WasapiCapture)System.Web.HttpContext.Current.Session[wc];
            w = (WaveWriter)System.Web.HttpContext.Current.Session[ww];
            //stop recording
            capture.Stop();
            w.Dispose();
            w = null;
            capture.Dispose();
            capture = null;

            System.Web.HttpContext.Current.Session[ww] = null;
            System.Web.HttpContext.Current.Session[wc] = null;
            //Label1.Text = "Stopped";
        }
        else
            isStopped = true;

        return isStopped;
    }

    public void startRecording()
    {
        capture = new WasapiLoopbackCapture();
        capture.Initialize();
        //create a wavewriter to write the data to
        w = new WaveWriter(path, capture.WaveFormat);

        System.Web.HttpContext.Current.Session[wc] = capture;
        System.Web.HttpContext.Current.Session[ww] = w;

        //setup an eventhandler to receive the recorded data
        capture.DataAvailable += (s, capData) =>
        {
            //save the recorded audio
            w.Write(capData.Data, capData.Offset, capData.ByteCount);
        };
        //start recording
        capture.Start();
        //Label1.Text = "Started";
    }

    public bool IsRecorded
    {
        get
        {
            if(int.Parse(System.Web.HttpContext.Current.Session[flag].ToString()) >= 2)
                return true;
            else
                return false;
        }
    }

    void increaseFlag()
    {
        System.Web.HttpContext.Current.Session[flag] = (int.Parse(System.Web.HttpContext.Current.Session[flag].ToString()) + 1) + ""; 
    }
}