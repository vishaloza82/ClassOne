using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ClassOne.Models
{
    [MetadataType(typeof(TeacherRegistration))]
    public partial class User
    {
        public string ConfirmPassword { get; set; }
    }


    public class TeacherRegistration
    {

        private readonly List<School> _schoolList;

        public TeacherRegistration()
        {

        }
        public TeacherRegistration(List<School> schoolList)
        {
            _schoolList = schoolList;

        }

        [Display(Name = "School")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "School Required")]

        public School School { get; set; }

        [Display(Name = "School Name")]
        public int SchoolId { get; set; }


        public IEnumerable<SelectListItem> SchoolList
        {
            get 
            {
               
                    var allSchools = _schoolList.Select(f => new SelectListItem
                    {
                        Value = f.Id.ToString(),
                        Text = f.Name
                    });
                    return DefaultSchool.Concat(allSchools);
            }
        }

        public IEnumerable<SelectListItem> DefaultSchool
        {
            get
            {
                return Enumerable.Repeat(new SelectListItem
                {
                    Value = "-1",
                    Text = "Select a School"
                }, count: 1);
            }
        }

        public List<string> Salutation { get; set; }

        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name required")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name required")]
        public string LastName { get; set; }

        [Display(Name = "Mobile Number")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        public int MobileNumber { get; set; }

        [Display(Name = "Email ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email ID required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Minimum 8 characters required")]
        public string Password { get; set; }


        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Confirm password and password do not match")]
        public string ConfirmPassword { get; set; }

        public bool IsEmailVerified { get; set; }

        public Guid ActivationCode { get; set; }


    }
}