using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace OVERS.Models
{
    public class Custometb
    {
         [Key]
        
        [Display(Name ="Customer ID")]
        [Required(ErrorMessage = "please enter customer id")]
        public int cid { get; set; }
        [Display(Name ="First Name")]
        [Required(ErrorMessage = "please enter first name")]
        public string fname { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "please enter last name")]
        public string lname { get; set; }
        


    }
}
