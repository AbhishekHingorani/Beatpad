using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Sockets;
using System.Net.Mail;

/// <summary>
/// Summary description for Mail
/// </summary>
public class SendMail
{
    
    String mailReciever;
    String mailBody;
    String mailSubject;

	public SendMail(String receiverId, String subject, String body)
	{
        mailReciever = receiverId;
        mailSubject = subject;
        mailBody = body;
	}
    
    public bool send()
    {
        bool status;
        MailMessage mail = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

        mail.From = new MailAddress("thebeatpad@gmail.com");
        mail.To.Add(mailReciever);
        mail.Subject = mailSubject;
        mail.IsBodyHtml = true;

        String htmlContent = "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'><html xmlns='http://www.w3.org/1999/xhtml'><head><meta http-equiv='Content-Type' content='text/html; charset=UTF-8' /><title>Beatpad</title>  <meta name='viewport' content='width=device-width, initial-scale=1.0'/></head><body style='margin: 0; padding: 0; background: linear-gradient(to right, rgba(192,110,255,1) 0%, rgba(192,110,255,1) 24%, rgba(255,0,0,1) 100%);'><table border='0' cellpadding='0' cellspacing='0' width='100%'><tr><td align='center' style='padding: 40px 0 30px 0;'><img src='https://s15.postimg.org/foat0rt6z/mail.png' alt='beatpad logo' width='500' height='130' style='display: block;' /></td></tr><tr><td align='center' style='padding: 40px 0 30px 0;'><font size='4' face='Rockwell' color='lightgray'>"+ mailBody +"</font></td></tr></table></body></html>";
        mail.Body = htmlContent;

        System.Net.Mail.Attachment attachment;
        attachment = new System.Net.Mail.Attachment(System.Web.HttpContext.Current.Server.MapPath("~") + "\\Beats\\recMain.wav");  //Add audio file
        mail.Attachments.Add(attachment);


        SmtpServer.UseDefaultCredentials = false;
        SmtpServer.Port = 587;
        SmtpServer.Credentials = new System.Net.NetworkCredential("thebeatpad@gmail.com", "nomusicnolife");
        SmtpServer.EnableSsl = true;

        try
        {
            SmtpServer.Send(mail);
            status = true;
        }
        catch (SmtpFailedRecipientException ex)
        {
            // ex.FailedRecipient and ex.GetBaseException() should give you enough info.
            status = false;
        }

        return status;
    }    
}