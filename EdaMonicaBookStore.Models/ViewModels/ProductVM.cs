using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdaMonicaBookStore.Models.ViewModels
{
   public class ProductVM
    {
        public Product Product { get; set; } //Dispaly all the product details
        public IEnumerable<SelectListItem> CategoryList{ get; set; } //install package 'Microsoft.AspNetCore.Mvc.ViewFeatures
        public IEnumerable<SelectListItem> CoverTypeList { get; set; } //Dispaly all the product details

    }
}
