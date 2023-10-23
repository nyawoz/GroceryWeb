using System.ComponentModel.DataAnnotations;

namespace GroceryWeb.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string EmailConfirmed { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;  //set value to default


    }
}
