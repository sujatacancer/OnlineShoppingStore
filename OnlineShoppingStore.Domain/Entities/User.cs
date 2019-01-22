using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Entities
{
    public class User
    {
        
        public string UserId { get; set; }
        [Required(ErrorMessage ="Enter User Name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Enter Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Enter User Name")]
        public string Address1 { get; set; }

        public string Address2 { get; set; }
    }
}
