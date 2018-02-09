using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Articulate.Models
{
    public class AttendeeModel
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
    }

    
}
