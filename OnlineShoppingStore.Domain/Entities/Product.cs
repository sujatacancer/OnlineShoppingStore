using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OnlineShoppingStore.Domain.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Enter Product Naem")]
        [StringLength(50,ErrorMessage ="Minumum is 3 and maximum is 50")]
        public string ProductName { get; set; }

        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        [Required(ErrorMessage = "Enter Product Description")]
        [StringLength(50, ErrorMessage = "Minumum is 3 and maximum is 500")]

        public string Description { get; set; }
        public string ProductImage { get; set; }

        [Required(ErrorMessage = "Enter Product Price")]
        public decimal Price { get; set; }
        public Nullable<bool> IsFeatured { get; set; }
//        public SelectList Categories { get; set; }
    }
}
