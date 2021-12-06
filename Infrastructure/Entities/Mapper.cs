namespace Infrastructure.Entities
{
    public static class Mapper
    {
        public static ProductInfo ToProductInfo(this Product product)
        {
            return new ProductInfo
            {
                ProductName = product.ProductName,
                Details = product.Details,
                Price = product.Price
            };
        }
    }
}
