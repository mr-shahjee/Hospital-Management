using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PracticeCrud.Models
{
    public class Products
    {
        [Key]
           public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Condition { get; set; }
        public int Price { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}