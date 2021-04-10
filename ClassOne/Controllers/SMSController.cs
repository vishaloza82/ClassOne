using ClassOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClassOne.Controllers
{
    public class SMSController : ApiController
    {
        ClassOneEntities db = new ClassOneEntities();
        // GET api/<controller>
        [NonAction]
        public static void SendVerificationLinkEmail(string emailID, string activationCode)
        {
            var verifyUrl = "/User/VerifyAccount/" + activationCode;
            //var link = Request.RequestUri.AbsoluteUri.Replace(Request.RequestUri.PathAndQuery, verifyUrl);//
            var link = "https://localhost:44315/" + verifyUrl;

            string body = "<br/><br/>We are excited to tell you that your ClassOne account is" +
                " successfully created. Please click on the below link to verify your account" +
                " <br/><br/><a href='" + link + "'>" + link + "</a> ";

            SendEmailVM model = new SendEmailVM();
            model.Subject = "Account Verification!";
            model.EmailId = emailID;
            model.HtmlContent = body;

            var uri = "http://connect.school-store.in/home/SendEmail";
            System.Net.Http.Formatting.MediaTypeFormatter jsonFormatter = new System.Net.Http.Formatting.JsonMediaTypeFormatter();

            System.Net.Http.HttpContent content = new System.Net.Http.ObjectContent<SendEmailVM>(model, jsonFormatter);
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.PostAsync(uri, content).Result;

        }

        [HttpGet]
        public string SendOrderConfirmationEmail(int OrderId)
        {
            SendEmailVM model = db.Database.SqlQuery<SendEmailVM>("Exec usp_GetOrderEmail {0}", OrderId).FirstOrDefault();

            if (model.SendFlag)
            {
                var uri = "http://connect.school-store.in/home/SendEmail";
                System.Net.Http.Formatting.MediaTypeFormatter jsonFormatter = new System.Net.Http.Formatting.JsonMediaTypeFormatter();

                System.Net.Http.HttpContent content = new System.Net.Http.ObjectContent<SendEmailVM>(model, jsonFormatter);
                HttpClient client = new HttpClient();
                HttpResponseMessage response = client.PostAsync(uri, content).Result;

            }

            return "Success";
        }

        public class SendEmailVM
        {
            public bool SendFlag { get; set; }
            public string Subject { get; set; }
            public string CustomerName { get; set; }
            public string EmailId { get; set; }
            public string HtmlContent { get; set; }

        }
    }
}