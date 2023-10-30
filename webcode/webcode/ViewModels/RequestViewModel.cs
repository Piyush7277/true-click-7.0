using System.ComponentModel.DataAnnotations;

namespace webcode.ViewModels
{
    public class RequestViewModel
    {
    }

    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
