using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.CleanupApp.Business.Interfaces
{
    public interface IEmailSender
    {
        EmailResult SendEmail(EmailDTO email);
    }

    public class EmailResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
    
    public class EmailDTO
    {
        public string To { get; set; }
        public string SMTP { get; set; }
        //TODO: complete send email parameters.
    }
}
