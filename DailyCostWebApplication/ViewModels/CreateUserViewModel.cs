using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DailyCostWebApplication.ViewModels
{
    public class CreateUserViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        [Compare("Password", ErrorMessage = "The Confirm Password Does Not Match With Password")]
        public string ConfirmPassword { get; set; }
    }
}
