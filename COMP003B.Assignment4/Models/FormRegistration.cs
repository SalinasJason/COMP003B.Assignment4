using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
    public class FormRegistration
    {
        [Required]
        [MinLength(3)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(1, 10)]
        public int Quantity { get; set; }

        public string DiscountCode { get; set; }
    }
}
