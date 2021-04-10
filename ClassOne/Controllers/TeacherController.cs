using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ClassOne.Models;
using System.Net.Mail;
using System.Net;
using System.Net.Sockets;
using System.Net.Http;

namespace ClassOne.Controllers
{
    public class TeacherController : Controller
    {
        ClassOneEntities db = new ClassOneEntities();
        //Registration Action
        public ActionResult Teacher()
        {
            //var model = new TeacherVM();
            return View();
        }
        [HttpGet]
        public ActionResult TeacherRegistration()
        {
            // Instead of Line 20 - 30 Call the API to get school list
            var Schools = db.Schools.Where(x => x.DeleteStatus == 0).ToList();

            List<Salutation> lstSalutation = new List<Salutation>();
            Salutation objTitleMr = new Salutation();
            objTitleMr.Id = 1;
            objTitleMr.Title = "Mr";
            lstSalutation.Add(objTitleMr);

            Salutation objTitleMrs = new Salutation();
            objTitleMrs.Id = 2;
            objTitleMrs.Title = "Mrs";
            lstSalutation.Add(objTitleMrs);
            Salutation objTitleMiss = new Salutation();
            objTitleMiss.Id = 3;
            objTitleMiss.Title = "Miss";
            lstSalutation.Add(objTitleMiss);

            TeacherRegistration objTeacher = new TeacherRegistration(Schools,lstSalutation);
                        
            return View(objTeacher);
        }
        //Registration POST action 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TeacherRegistration([Bind(Exclude = "IsEmailVerified,ActivationCode")] TeacherRegistration teacher)
        {
            bool Status = false;
            string message = "";
            //
            // Model Validation 
            if (ModelState.IsValid)
            {

                #region //Email is already Exist 
                var isExist = IsEmailExist(teacher.Email);
                if (isExist)
                {
                    ModelState.AddModelError("EmailExist", "Email already exist");
                    return View(teacher);
                }
                #endregion

                #region Generate Activation Code 
                teacher.ActivationCode = Guid.NewGuid();
                #endregion

                #region  Password Hashing 
                teacher.Password = Crypto.Hash(teacher.Password);
                teacher.ConfirmPassword = Crypto.Hash(teacher.ConfirmPassword); //
                #endregion
                teacher.IsEmailVerified = false;

                // Logic API Call To save the Teacher's details in the Database. Pass the teacher object to API
                #region Registration
                LoginVM result = new LoginVM();
                #region CHECK EXISTING USER
                Teacher _existingTeacher = db.Teachers.Where(
                                                t => t.EmailId == teacher.Email
                                                    || t.MobileNumber == teacher.MobileNumber.ToString()).FirstOrDefault();
                if (_existingTeacher != null)
                {
                    if (_existingTeacher.MobileNumber == teacher.MobileNumber.ToString())
                    {
                        result.MobileNumber_Message = "Already Registered Mobile Number, please login";
                    }
                    if (_existingTeacher.EmailId == teacher.Email)
                    {
                        result.EmailId_Message = "Already Registered Email Id, please login";
                    }
                }
                #endregion
                #region INSERT TEACHER DETAILS IF NOT EXISTS
                else
                {
                    #region CUSTOMER
                    Teacher c = new Teacher();
                    c.RoleId = 1;
                    c.SchoolId = teacher.SchoolId;
                    c.Salutation = teacher.SalutationId.ToString();
                    c.FirstName = teacher.FirstName;
                    c.LastName = teacher.LastName;
                    c.EmailId = teacher.Email;
                    c.MobileNumber = teacher.MobileNumber.ToString();
                    c.Password = teacher.Password;
                    //c.GradeId = teacher.GradeId;
                    //c.SubjectId = teacher.SubjectId;
                    c.CreatedDate = DateTime.Now;
                    c.UpdatedDate = DateTime.Now;
                    c.DeleteStatus = 0;
                    c.IsEmailVerified = false;
                    db.Teachers.Add(c);
                    db.SaveChanges();

                    FormsAuthentication.SetAuthCookie(c.EmailId, true);
                    #endregion

                    #region LOGIN USER
                    FormsAuthentication.SignOut();

                    Teachers_Login _teacher_login = new Teachers_Login();
                    _teacher_login.TeacherId = c.TeacherId;
                    _teacher_login.LastLoginDate = DateTime.Now;
                    _teacher_login.LastLoginIp = GetLocalIPAddress();
                    _teacher_login.LogoutTime = null;
                    _teacher_login.CreatedDate = DateTime.Now;
                    _teacher_login.UpdatedDate = DateTime.Now;
                    _teacher_login.DeleteStatus = 0;

                    db.Teachers_Login.Add(_teacher_login);
                    db.SaveChanges();

                    FormsAuthentication.SetAuthCookie(c.EmailId, true);
                    #endregion
                }
                #endregion
                #endregion

                //Send Email to User after record saved to DB
                SendVerificationLinkEmail(teacher.Email, teacher.ActivationCode.ToString());
                message = "Registration successfully done. Account activation link " +
                    " has been sent to your email id:" + teacher.Email;
                Status = true;
            }
            else
            {
                message = "Invalid Request";
            }

            ViewBag.Message = message;
            ViewBag.Status = Status;
            return View(teacher);
        }
        //Verify Account  

        [HttpGet]
        public ActionResult VerifyAccount(string id)
        {
            bool Status = false;
            //Put Get API Call below line 86 for VerifyUser
            var getUser = new  TeacherRegistration();
            //Add API Call below 
            //getUser = 
            if (getUser != null)
            {
                getUser.IsEmailVerified = true;
                // Put Post API Call to confirm User and save the Teacher in DB
                Status = true;
            }
            else
            {
                ViewBag.Message = "Invalid Request";
            }
            ViewBag.Status = Status;
            return View();
        }

        //Login 
        [HttpGet]
        public ActionResult TeacherLogin()
        {
            //var model = new TeacherLoginVM();
            return View();
        }

        //Login POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TeacherLogin(TeacherLoginVM login, string ReturnUrl = "")
        {
            string message = "";
            var v = new TeacherRegistration();
            // Insert Line of Code to make API Call to fetch the teahcers details.

            #region Fetch Teacher Detail
            Teacher _teacher = db.Teachers.Where(t => (t.EmailId == login.UserName || t.MobileNumber == login.UserName) && (t.DeleteStatus == 0)).FirstOrDefault();
            v.SchoolId = (int)_teacher.SchoolId;
            v.FirstName = _teacher.FirstName;
            v.LastName = _teacher.LastName;
            v.MobileNumber = _teacher.MobileNumber;
            v.Email = _teacher.EmailId;
            v.Password = _teacher.Password;
            v.IsEmailVerified = _teacher.IsEmailVerified; 
            #endregion
            if (v != null)
            {
                if (!v.IsEmailVerified)
                {
                    ViewBag.Message = "Please verify your email first";
                    return View();
                }

                if (string.Compare(Crypto.Hash(login.Password), v.Password) == 0)
                {
                    //int timeout = login.RememberMe ? 525600 : 20; // 525600 min = 1 year
                    var ticket = new FormsAuthenticationTicket(v.Email, true, 300);
                    string encrypted = FormsAuthentication.Encrypt(ticket);
                    var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encrypted);
                    cookie.Expires = DateTime.Now.AddMinutes(300);
                    cookie.HttpOnly = true;
                    FormsAuthentication.SetAuthCookie(v.Email, true);
                    Response.Cookies.Add(cookie);

                    if (Url.IsLocalUrl(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    message = "Invalid credential provided";
                }
            }
            else
            {
                message = "Invalid credential provided";
            }
            
            ViewBag.Message = message;
            return View();
        }

        //Logout
        [Authorize]
        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "User");
        }


        [NonAction]
        public bool IsEmailExist(string emailID)
        {
            //TeacherRegistration objteacher = new TeacherRegistration();
            var objteacher = db.Teachers.Where(x => x.EmailId == emailID && x.DeleteStatus == 0).FirstOrDefault();
            //objteacher =  Get API Call to get the Teacher Details based on Email ID
            if (objteacher == null)
                return false;
            return true;
        }

        //[NonAction]
        //public void SendVerificationLinkEmail(string emailID, string activationCode)
        //{
        //    var verifyUrl = "/User/VerifyAccount/" + activationCode;
        //    var link = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, verifyUrl);

        //    var fromEmail = new MailAddress("dotnetawesome@gmail.com", "Dotnet Awesome");
        //    var toEmail = new MailAddress(emailID);
        //    var fromEmailPassword = "********"; // Replace with actual password
        //    string subject = "Your account is successfully created!";

        //    string body = "<br/><br/>We are excited to tell you that your Dotnet Awesome account is" +
        //        " successfully created. Please click on the below link to verify your account" +
        //        " <br/><br/><a href='" + link + "'>" + link + "</a> ";

        //    var smtp = new SmtpClient
        //    {
        //        Host = "smtp.gmail.com",
        //        Port = 587,
        //        EnableSsl = true,
        //        DeliveryMethod = SmtpDeliveryMethod.Network,
        //        UseDefaultCredentials = false,
        //        Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
        //    };

        //    using (var message = new MailMessage(fromEmail, toEmail)
        //    {
        //        Subject = subject,
        //        Body = body,
        //        IsBodyHtml = true
        //    })
        //        smtp.Send(message);
        //}

        public JsonResult SendVerificationLinkEmail(string emailID, string activationCode)
        {
            var verifyUrl = "/Teacher/VerifyAccount/" + activationCode;
            var link = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, verifyUrl);

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

            return Json("success", JsonRequestBehavior.AllowGet);
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("CANNOT ACCESS");
        }

        #region View Model
        public class SendEmailVM
        {
            public bool SendFlag { get; set; }
            public string Subject { get; set; }
            public string CustomerName { get; set; }
            public string EmailId { get; set; }
            public string HtmlContent { get; set; }

        }
        #endregion
    }
}