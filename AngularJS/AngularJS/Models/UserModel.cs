using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace AngularJS.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "phone number is not in valid format")]
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<DateTime> CreatedOn { get; set; }
        public Nullable<DateTime> ModifiedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> Modifiedby { get; set; }

        public List<UserModel> AllUsersList { get; set; }
        public string Company { get; set; }
       
        public IEnumerable<SelectListItem> AllCompanies { get; set; }
        public int GrowerID { get; set; }
        public IEnumerable<SelectListItem> values { get; set; }
        public bool SelectedValue { get; set; }
        public IEnumerable<SelectListItem> Activestatus { get; set; }
        public string CheckUsernameUnique { get; set; }
    }
}