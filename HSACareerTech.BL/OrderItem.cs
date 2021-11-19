using System;
using System.Collections.Generic;
using System.Text;

namespace HSACareerTech.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
            
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        public bool Validate()
        {
            return !(PurchasePrice == null || Quantity <= 0 || ProductId <= 0);
        }
        
        public void SaveOrderItem()
        {

        }

        public OrderItem RetrieveOrderItem()
        {
            return new OrderItem();
        }

        public OrderItem RetrieveOrderItem(int id)
        {
            return new OrderItem();
        }
    }
}
