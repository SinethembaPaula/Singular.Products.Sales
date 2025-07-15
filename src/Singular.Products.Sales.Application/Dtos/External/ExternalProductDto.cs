namespace Singular.Products.Sales.Application.Dtos.External
{
    public class ExternalProductDto
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal SalePrice { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
    }
}
