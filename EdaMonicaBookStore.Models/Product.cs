﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdaMonicaBookStore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public int Author { get; set; }

        [Required]
        [Range(1, 10000)]

        public double ListPrice { get; set; }
        public string ImageUrl { get; set; }

        [Required]
        public int CategoryId { get; set; } //Foreign key reference
        [ForeignKey("CategoryId")]

        public Category Category { get; set; }

        [Required]

        public int CoverTypeId {get; set; }  //Foreign key reference
        [ForeignKey("CategoryId")]
        public CoverType CoverType { get; set; }





    }
}
