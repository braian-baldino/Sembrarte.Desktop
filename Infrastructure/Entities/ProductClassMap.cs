using CsvHelper.Configuration;

namespace Infrastructure.Entities
{
    public class ProductClassMap : ClassMap<ProductInfo>
    {
        public ProductClassMap()
        {
            Map(x => x.ProductName).Name("Producto");
            Map(x => x.Details).Name("Detalle");
            Map(x => x.Price).Name("Precio final");
        }
    }
}
