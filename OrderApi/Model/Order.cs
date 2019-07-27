using System;

namespace OrderApi.Model
{
    public class Order
    {
        public Order(string id, decimal amount)
        {
            Id = id;
            Amount = amount;
        }

        public string Id { get; set; }
        public decimal Amount { get; set; }
    }
}
