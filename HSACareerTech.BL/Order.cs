using System;
using System.Collections.Generic;
using System.Text;

namespace HSACareerTech.BL
{
    public class Order
    {
        public Order()
        {
            
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public bool Validate()
        {
            return !(OrderDate == null);
        }

        public void SaveOrder(Order order)
        {

        }

        public Order RetrieveOrder()
        {
            return new Order();
        }

        public Order RetrieveOrder(int id)
        {
            return new Order();
        }
    }
}
