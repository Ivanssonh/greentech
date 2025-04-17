using Greentech.Validation;
using System.ComponentModel.DataAnnotations;

namespace Greentech.Models.ViewModels
{
    public class ContactViewModel
    {
        [Display(Name = "Full name")]
        [Required(ErrorMessage ="You must enter your name ")]
        public string? Name { get; set; }
        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage ="You must enter a valid email address")]
        [Required(ErrorMessage = "You must enter your email adress ")]
        public string? Email { get; set; }
        [Display(Name = "Phone number")]
        public string? Phone { get; set; }
        [Display(Name = "Message")]
        [Required(ErrorMessage = "You must enter your message ")]


        public string? Message { get; set; }
        [Display(Name = "Yes, I give permission to store and process my data ")]
        [Required(ErrorMessage = "You must give concent to us storing your details before you send a message")]
        [MustBeTrue(ErrorMessage = "You must give concent to us storing your details before you send a message")]
        public bool Consent { get; set; }
    }
}
