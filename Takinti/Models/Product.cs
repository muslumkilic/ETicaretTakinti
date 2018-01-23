using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Takinti.Models
{
    public class Product
    {

        // varsayılan değerler
        public Product()

        {
            IsInStock = true;
            Quantity = 10;
            Rating = 5;
            RatingCount = 0;
            IsPublished = true;
            OldPrice = 0;
            Price = 0;
            CreateDate = DateTime.Now;
            Updateate = DateTime.Now;
            ViewCount = 0;
            Tax = 0.18M;
            
            Categories = new HashSet<Category>();

        }
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        [Required]
        [StringLength(200)]
        public string Slug { get; set; }
        [StringLength(200)]
        public string Photo { get; set; }
        [StringLength(4000)]

        public string Description { get; set; }
        public bool IsInStock { get; set; }
        public int Quantity { get; set; }

        // ????
        public int SeleCount { get; }

        [StringLength(200)]
        public string Details { get; set; }
        public string Features { get; set; }
        public string DayaSheet { get; set; }
        public float Rating { get; set; }
        public float RatingCount { get; set; }
        public bool IsPublished { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public int ViewCount { get; set; }
        public decimal Tax { get; set; }
        

        public DateTime CreateDate { get; set; }
        public DateTime Updateate { get; set; }

        public virtual ICollection<Category> Categories { get; set; }




    }
}