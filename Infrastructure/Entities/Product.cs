using System;

namespace Infrastructure.Entities
{
    [Serializable]
    public class Product
    {
        public string Code { get; set; }
        public string ProductName { get; set; }
        public string Details { get; set; }
        public double Price { get; set; }
        public double BuyPrice { get; set; }
    }
}
