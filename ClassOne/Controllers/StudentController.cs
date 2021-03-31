using ClassOne.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ClassOne.Controllers
{
    public class StudentController : Controller
    {
        ClassOneEntities db = new ClassOneEntities();
        // GET: Student
        public ActionResult Student()
        {
            return View();
        }

        public JsonResult GetCurrentUser()
        {
            using (ClassOneEntities db = new ClassOneEntities())
            {
                string name = User.Identity.Name;
                usp_GetStudentDetails_Result resp = db.usp_GetStudentDetails(name).FirstOrDefault();
                return Json(resp, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public dynamic GetSchoolType()
        {
            int CustomerId = db.Customers.Where(c => c.MobileNumber == User.Identity.Name || c.EmailId == User.Identity.Name).Select(c => (int)c.CustomerId).FirstOrDefault();
            int SchoolId = db.Customers.Where(c => c.MobileNumber == User.Identity.Name || c.EmailId == User.Identity.Name).Select(c => (int)c.SchoolId).FirstOrDefault();
            int SchoolTypeId = db.Schools.Where(t => t.SchoolId == SchoolId).Select(t => (int)t.SchoolModelId).FirstOrDefault();

            List<usp_GetCustomerSchoolStandards_Result> schoolStandards = db.usp_GetCustomerSchoolStandards(CustomerId, SchoolId, SchoolTypeId).ToList();
            return Json(new { SchoolModelId = SchoolTypeId, SchoolStandards = schoolStandards }, JsonRequestBehavior.AllowGet);
            //return (new
            //{
            //    SchoolModelId = SchoolTypeId,
            //    SchoolStandards = schoolStandards
            //});
        }
        public dynamic GetSchoolStandardList(int SchoolId = 0)
        {
            List<usp_GetModelWiseSchoolListWithVendor_Result> data = db.usp_GetModelWiseSchoolListWithVendor(SchoolId).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
            //return data;
        }
        [HttpPost]
        public dynamic StudentLogin(StudentVM model)
        {
            LoginVM result = new LoginVM();
            using (ClassOneEntities db = new ClassOneEntities())
            {
                //  CHECK EXISTING MOBILE NUMBER OR EMAIL ID
                Student _student = db.Students.Where(x => x.MobileNumber == model.StMobNo || x.EmailId == model.EmailId || x.Username == model.Username && (x.DeleteStatus == 0)).FirstOrDefault();
                if (_student != null)
                {
                    //  CHECK PASSWORD
                    if (_student.Password == model.Password)
                    {

                        FormsAuthentication.SignOut();
                        result.Login = true;
                        //  LOG USER LOGIN HISTORY
                        Students_Login _student_login = new Students_Login();
                        _student_login.CreatedDate = DateTime.Now;
                        _student_login.StudentId = _student.StudentId;
                        _student_login.DeleteStatus = 0;
                        _student_login.LastLoginDate = DateTime.Now;
                        _student_login.LastLoginIp = GetLocalIPAddress();
                        _student_login.LogoutTime = null;
                        _student_login.UpdatedDate = DateTime.Now;

                        db.Students_Login.Add(_student_login);
                        db.SaveChanges();

                        FormsAuthentication.SetAuthCookie(_student.EmailId, true);

                    }
                    else
                    {
                        result.Login = false;
                        result.Password_Message = "* Invalid Password";
                    }
                }
                else
                {
                    result.Login = false;
                    result.Username_Message = "* Invalid Mobile No / Email Id";

                }
            }
            //return result;
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult StudentRegister(StudentVM model)
        {
            ClassOneEntities db = new ClassOneEntities();
            LoginVM result = new LoginVM();
            #region CHECK EXISTING USER
            Student _existingCustomer = db.Students.Where(
                                            t => t.EmailId == model.EmailId
                                                || t.MobileNumber == model.StMobNo
                                                || t.Username == model.Username).FirstOrDefault();
            if (_existingCustomer != null)
            {
                if (_existingCustomer.MobileNumber == model.StMobNo)
                {
                    result.MobileNumber_Message = "Already Registered Mobile Number, please login";
                }
                if (_existingCustomer.EmailId == model.EmailId)
                {
                    result.EmailId_Message = "Already Registered Email Id, please login";
                }
                if (_existingCustomer.Username == model.Username)
                {
                    result.EmailId_Message = "Username Already Registered, please login";
                }
            }
            #endregion

            #region INSERT CUSTOMER DETAILS IF NOT EXISTS
            else
            {
                #region STUDENT
                Student s = new Student();
                s.StudentName = model.StudentName;
                s.Username = model.Username;
                s.DivisionId = 0;
                s.Division = model.Division;
                s.StandardId = model.StandardId;
                s.SchoolId = model.SchoolId;
                s.EmailId = model.EmailId;
                s.MobileNumber = model.StMobNo;
                s.Password = model.Password;
                s.OrderNumber = model.OrderNumber;
                s.CreatedDate = DateTime.Now;
                s.UpdatedDate = DateTime.Now;
                s.DeleteStatus = 0;
                db.Students.Add(s);
                db.SaveChanges();

                #endregion

                #region Customer Mapping Student
                //CustomerMappingStudent _CMS = new CustomerMappingStudent();
                //_CMS.CreatedDate = DateTime.Now;
                //_CMS.CustomerId = c.CustomerId;
                //_CMS.DeleteStatus = 0;
                //_CMS.Division = "-";
                //_CMS.FirstName = model.ChildName;
                //_CMS.LastName = model.LastName;
                //_CMS.MiddleName = model.FirstName;
                //_CMS.RollNo = "-";
                //_CMS.SchoolId = model.SchoolId;
                //_CMS.StandardId = model.StandardId;
                //_CMS.UpdatedDate = DateTime.Now;
                //_CMS.StudentId = model.StudentId;

                //db.CustomerMappingStudents.Add(_CMS);
                //db.SaveChanges();
                #endregion

                #region SEND REGISTRATION SMS

                string SMSText = "Thankyou for registering with SchoolStore. Please login with your registered email OR mobile number, your password is " + s.Password + ". Team SchoolStore ClassOne";

                var data = sendSMS(s.MobileNumber, SMSText);
                #endregion

                #region SCHOLARSHIP POINT
                //Customer_Mapping_Scholarshippoints cms = new Customer_Mapping_Scholarshippoints();
                //cms.CreatedDate = DateTime.Now;
                //cms.CustomerId = c.CustomerId;
                //cms.DeleteStatus = 0;
                //cms.TotalPoints = 0;
                //cms.UpdatedDate = DateTime.Now;
                //db.Customer_Mapping_Scholarshippoints.Add(cms);
                //db.SaveChanges();
                #endregion

                result.Login = true;

                #region LOGIN USER
                FormsAuthentication.SignOut();

                Students_Login _student_login = new Students_Login();
                _student_login.CreatedDate = DateTime.Now;
                _student_login.StudentId = s.StudentId;
                _student_login.DeleteStatus = 0;
                _student_login.LastLoginDate = DateTime.Now;
                _student_login.LastLoginIp = GetLocalIPAddress();
                _student_login.LogoutTime = null;
                _student_login.UpdatedDate = DateTime.Now;

                db.Students_Login.Add(_student_login);
                db.SaveChanges();

                FormsAuthentication.SetAuthCookie(s.EmailId, true);
                #endregion

            }
            #endregion

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public bool SignOut(int CustomerId = 0)
        {
            try
            {
                using (ClassOneEntities db = new ClassOneEntities())
                {
                    var _customers_login_Id = db.Students_Login.Where(x => x.StudentId == CustomerId && x.DeleteStatus == 0).Select(x => x.StudentLoginId).DefaultIfEmpty().Max();
                    var _customers_login = db.Students_Login.Where(x => x.StudentLoginId == _customers_login_Id && x.StudentId == CustomerId && x.DeleteStatus == 0).FirstOrDefault();
                    _customers_login.LogoutTime = DateTime.Now;
                    db.Entry(_customers_login).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                FormsAuthentication.SignOut();
                return true;
            }
            catch(Exception)
            {
                FormsAuthentication.SignOut();
                return true;
            }
        }
        #region Mobile OTP Genrate/Verification
        public static string otp = "";
        [HttpPost]
        public string GenerateOTP(string OrderNumber)//
        {
            try
            {
                var MobileNumber = db.Orders.Where(x => x.OrderNumber == OrderNumber.Trim() && x.DeleteStatus == 0).Select(x => x.MobileNumber).FirstOrDefault();
                if (MobileNumber != null)
                {
                    Random r = new Random();
                    otp = r.Next(1000, 9999).ToString();
                    //string SMSUrl = db.BaseDatas.Select(t => t.SmsApiPath).FirstOrDefault();
                    //HttpWebRequest request = WebRequest.Create(SMSUrl + MobileNumber + "&message=" + "Thank you for registering on SchoolStore - ClassOne, please enter your OTP to validate your account. Your OTP is " + otp) as HttpWebRequest;
                    //HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    //Stream dataStream = response.GetResponseStream();
                    //StreamReader reader = new StreamReader(dataStream);
                    //string sResponse = reader.ReadToEnd();
                    ////return sResponse;
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
            return otp;
        }


        [HttpPost]
        public dynamic OTPverifyCode(OTPVerifyVM model)
        {
            string sessionotp = otp;  //Session["MobileOtp"].ToString();

            StudentVM student = new StudentVM();
            if (model.MobileOtp != null)
            {
                if (model.MobileOtp == sessionotp)
                {
                    var OrderDetail = db.Orders.Where(x => x.OrderNumber == model.OrderNumber.Trim() && x.DeleteStatus == 0).FirstOrDefault();
                    CustomerMappingStudent StudentData = db.CustomerMappingStudents.Where(x => x.CustomerMappingStudentId == OrderDetail.CustomerMappingStudentId).FirstOrDefault();

                    student.StudentName = StudentData.FirstName + " " + StudentData.LastName;
                    student.OrderNumber = OrderDetail.OrderNumber;
                    student.StMobNo = OrderDetail.MobileNumber;
                    student.SchoolId = (int)StudentData.SchoolId;
                    student.StandardId = (int)StudentData.StandardId;
                    student.status = true;

                    return Json(student);
                }
                else
                {
                    return Json(new { status = false, message = "Otp does not Matched" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Please enter otp." });
            }
        }
        #endregion
        //public string SMSUrl = "http://panel.adcomsolution.in/http-api.php?username=ibtions_schoolstuff&password=ibtions&senderid=SCHSTR&route=1&number=";
        [HttpGet]
        public dynamic sendSMS(string MobileNumber, string Message)
        {
            ClassOneEntities db = new ClassOneEntities();
            string SMSUrl = db.BaseDatas.Select(t => t.SmsApiPath).FirstOrDefault();
            HttpWebRequest request = WebRequest.Create(SMSUrl + MobileNumber + "&message=" + Message) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string sResponse = reader.ReadToEnd();
            return sResponse;
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
        #region StudentVM
        public class LoginVM
        {
            public bool Login { get; set; }
            public string Email_Message { get; set; }
            public string Password_Message { get; set; }
            public string Username_Message { get; set; }
            public string FirstName_Message { get; set; }
            public string LastName_Message { get; set; }
            public string EmailId_Message { get; set; }
            public string MobileNumber_Message { get; set; }
            //public string StudentId_Message { get; set; }//

        }
        public class StudentVM
        {
            public string OrderNumber { get; set; }
            public string Username { get; set; }
            public string StudentName { get; set; }
            public string StMobNo { get; set; }
            public string EmailId { get; set; }
            public int SchoolId { get; set; }
            public int StandardId { get; set; }
            public string Password { get; set; }
            //public string StudentId { get; set; }
            public string Division { get; set; }
            public int DivisionId { get; set; }
            public bool status { get; set; }
        }

        public class OTPVerifyVM
        {
            public string MobileOtp { get; set; }
            public string OrderNumber { get; set; }
        }

        public class StudentFetchVM
        {
            public string OrderNumber { get; set; }
            public string StudentName { get; set; }
            public string StMobNo { get; set; }
            public string EmailId { get; set; }
            public int SchoolId { get; set; }
            public int StandardId { get; set; }
            public string SchoolName { get; set; }
            public string StandardName { get; set; }

        }
        public class UpdateAddressDetail
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MobileNumber { get; set; }
            public string EmailId { get; set; }
            public string StreetAddress { get; set; }
            public string Landmark { get; set; }
            public string Pincode { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
            public int CustomerAddressId { get; set; }
            public bool IsDefault { get; set; }
            public int CityId { get; set; }

        }
        public class Result
        {
            public string Status { get; set; }
        }
        #endregion
    }
}