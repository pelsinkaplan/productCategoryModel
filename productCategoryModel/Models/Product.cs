using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace productCategoryModel.Models
{
    class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Price { get; set; }

        public string Contents { get; set; }

        //foreign key
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
