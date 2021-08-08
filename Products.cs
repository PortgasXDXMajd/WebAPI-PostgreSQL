using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI
{
    public class Products
    {
        [Key]
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrise { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;

        public Products()
        {

        }
    }
}
