using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDeanShoppingApp.Models.codeFirst
{
    public class Item
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; } //more precise than double
        public string MediaURL { get; set; }
        public string Description { get; set; }

    }


}

//normalization: pointing at data in another tab