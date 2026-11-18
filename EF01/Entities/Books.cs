using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Entities
{
    public class Books
    {
        public int Id { get; set; } // PK
        public string? title { get; set; }
        public string? ISBN { get; set; }
        public decimal price { get; set; }
        public int numOfPages { get; set; }
        public int yearOfPublication { get; set; }
        public bool inStock { get; set; }

        public int CategoryId { get; set; } // FK
        public Category category { get; set; } // Navigation property

    }
}
