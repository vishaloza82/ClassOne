using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ClassOne.Models;
using System.Net.Mail;
using System.Net;

namespace ClassOne.Controllers
{
    public class TeacherController : Controller
    {
        //Registration Action
        [HttpGet]
        public ActionResult TeacherRegistration()
        {
            
            School objSchool = new School();
            objSchool.Id = "1";
            objSchool.Name = "Dhirubhai Ambani";
            List<School> objSchoolList = new List<School>();
            objSchoolList.Add(objSchool);

            School objSchool1 = new School();
            objSchool1.Id = "2";
            objSchool1.Name = "Singhania";
            objSchoolList.Add(objSchool1);
            TeacherRegistration objTeacher = new TeacherRegistration(objSchoolList);
            // Instead of Line 20 - 30 Call the API to get school list
            
            objTeacher.Salutation = new List<string>();
            objTeacher.Salutation.Add("Mr");
            objTeacher.Salutation.Add("Mrs");
            objTeacher.Salutation.Add("Miss");
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
            return View();
        }

        //Login POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TeacherLogin(UserLogin login, string ReturnUrl = "")
        {
            string message = "";
            var v = new TeacherRegistration();
            // Insert Line of Code to make API Call to fetch the teahcers details.
            if (v != null)
            {
                if (!v.IsEmailVerified)
                {
                    ViewBag.Message = "Please verify your email first";
                    return View();
                }

                if (string.Compare(Crypto.Hash(login.Password), v.Password) == 0)
                {
                    int timeout = login.RememberMe ? 525600 : 20; // 525600 min = 1 year
                    var ticket = new FormsAuthenticationTicket(login.EmailID, login.RememberMe, timeout);
                    string encrypted = FormsAuthentication.Encrypt(ticket);
                    var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encrypted);
                    cookie.Expires = DateTime.Now.AddMinutes(timeout);
                    cookie.HttpOnly = true;
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
            TeacherRegistration objteacher = new TeacherRegistration();
            //objteacher =  Get API Call to get the Teacher Details based on Email ID
            if (objteacher == null)
                return false;
            return true;
        }

        [NonAction]
        public void SendVerificationLinkEmail(string emailID, string activationCode)
        {
            var verifyUrl = "/User/VerifyAccount/" + activationCode;
            var link = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, verifyUrl);

            var fromEmail = new MailAddress("dotnetawesome@gmail.com", "Dotnet Awesome");
            var toEmail = new MailAddress(emailID);
            var fromEmailPassword = "********"; // Replace with actual password
            string subject = "Your account is successfully created!";

            string body = "<br/><br/>We are excited to tell you that your Dotnet Awesome account is" +
                " successfully created. Please click on the below link to verify your account" +
                " <br/><br/><a href='" + link + "'>" + link + "</a> ";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
            };

            using (var message = new MailMessage(fromEmail, toEmail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
                smtp.Send(message);
        }

    }
}