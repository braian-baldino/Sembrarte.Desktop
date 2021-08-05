using System;

namespace Models.Entities
{
    [Serializable]
    public class Product
    {
        public string Code { get; set; }
        public string ProductName { get; set; }
        public string Details { get; set; }
        public double Price { get; set; }
    }
}
