using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDeanShoppingApp.Models.codeFirst
{
    public class CartItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Count { get; set; }
        public DateTime CreationDate { get; set; }
        public string CustomerId { get; set; } //ForeignKey

        public virtual Item Item { get; set; } //truncated version of Foreign Key
        public virtual ApplicationUser Customer { get; set; } //specificy who customer is, 1:1 relationship

        public decimal unittotal
        {
            get
            {
                return Count * Item.Price;
            }
        }

    }
   
}

//one on one relationship with Item
//GUID Global User Identififier = string