using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class User
    {
        public int ID { get; set; }
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Display(Name ="Date of Birth")]
        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy}", ApplyFormatInEditMode =true)]
        public DateTime DOB { get; set; }
        [Display(Name ="Email")]
        public string Email { get; set; }
    }
}
