using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingStoreWebApi.Models
{
    public class ProductDetailModels
    {
        public int PId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Catagory { get; set; }

    }
}