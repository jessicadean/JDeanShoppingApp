using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDeanShoppingApp.Models.codeFirst
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string OrderId { get; set; } // 1:1 relationship
        public string ItemId { get; set; } //ForeignKey
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }

   
}

//no relationship needed