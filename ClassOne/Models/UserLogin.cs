using System.ComponentModel.DataAnnotations;

namespace ClassOne.Models
{

    public class UserLogin
    {
        [Display(Name = "Email ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email ID required")]
        public string EmailID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }

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
        public string StudentId_Message { get; set; }
    }

    public class TeacherLoginVM
    {
        [Display(Name = "User Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "User Name Required")]
        public string UserName { get; set; }
        public int RoleId { get; set; }
        public string EmailId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SchoolId { get; set; }
        //public int SubjectId { get; set; }
        public string Salutation { get; set; }
        //public int GradeId { get; set; }
    }

}