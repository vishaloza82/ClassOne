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

    public class Salutation
    {
        public int Id { get; set; }

        public string Title { get; set; }
    }


    public class TeacherRegistration
    {

        private readonly List<School> _schoolList;
        private readonly List<Salutation> _titles;

        public TeacherRegistration()
        {

        }
        public TeacherRegistration(List<School> schoolList,List<Salutation> lstTitles)
        {
            _schoolList = schoolList;
            _titles = lstTitles;

        }



        //[Display(Name = "School")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "School Required")]

        public School School { get; set; }

        [Display(Name = "School Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "School Required")]
        public int SchoolId { get; set; }


        public IEnumerable<SelectListItem> SchoolList { get; set; }
        //public IEnumerable<SelectListItem> SchoolList
        //{
        //    get
        //    {
        //        try
        //        {
        //            var allSchools = _schoolList.Select(f => new SelectListItem
        //            {
        //                Value = f.SchoolId.ToString(),
        //                Text = f.SchoolName,
        //            });
        //            return DefaultSchool.Concat(allSchools);
        //        }
        //        catch(Exception)
        //        {
        //            return null;
        //        }

        //    }
        //}

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

        public int SalutationId { get; set; }

        public IEnumerable<SelectListItem> Salutation { get; set; }
        //public IEnumerable<SelectListItem> Salutation
        //{
        //    get
        //    {
        //        var allTitles = _titles.Select(f => new SelectListItem
        //        {
        //            Value = f.Id.ToString(),
        //            Text = f.Title,
        //        });
        //        return DefaultTitle.Concat(allTitles);
        //    }
        //}


        public IEnumerable<SelectListItem> DefaultTitle
        {
            get
            {
                return Enumerable.Repeat(new SelectListItem
                {
                    Value = "-1",
                    Text = "Select Title"
                }, count: 1);
            }
        }

       

        
        
        
        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name required")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name required")]
        public string LastName { get; set; }

        [Display(Name = "Mobile Number")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mobile Number is Required")]
        //[RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Please Enter Valid Mobile Number.")]
        [DataType(DataType.PhoneNumber)]
        public string MobileNumber { get; set; }

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
    
    public class TeacherVM
    {
        public TeacherRegistration TeacherRegistration { get; set; }
        public TeacherLoginVM TeacherLoginVM { get; set; }
    }
}