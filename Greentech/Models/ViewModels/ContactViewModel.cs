using Greentech.Validation;
using System.ComponentModel.DataAnnotations;

namespace Greentech.Models.ViewModels
{
    public class ContactViewModel
    {
        [Display(Name = "Namn")]
        [Required(ErrorMessage ="Du måste ange ditt namn ")]
        public string? Name { get; set; }
        [Display(Name = "E-post adress")]
        [EmailAddress(ErrorMessage ="You must enter a valid email address")]
        [Required(ErrorMessage = "Du måste ange en giltig e-postadress")]
        public string? Email { get; set; }
        [Display(Name = "Telefonnummer")]
        public string? Phone { get; set; }
        [Display(Name = "Meddelande")]
        [Required(ErrorMessage = "Du måste ange meddelande ")]

        public string? Message { get; set; }
        [Display(Name = "Yes, I give permission to store and process my data ")]
        [Required(ErrorMessage = "Du måste godkänna vår Policy innan du kan skicka ett meddelande")]
        [MustBeTrue(ErrorMessage = "Du måste godkänna vår Policy innan du kan skicka ett meddelande")]
        public bool Consent { get; set; }
    }
}
