namespace Singular.Products.Sales.Application.Dtos
{
    public class ProductSalesSummaryDto
    {
        public int ProductId { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal TotalSalesAmount { get; set; }
        public int TotalSalesQuantity { get; set; }
    }
}
