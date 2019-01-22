using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Entities
{
    public class Categ
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Enter category name")]
        [StringLength(50,ErrorMessage ="Minimum is 3 and maximum is 50")]
        [System.Web.Mvc.Remote("CheckCategoryExists","Category",ErrorMessage ="Category already exists")]
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }
}
