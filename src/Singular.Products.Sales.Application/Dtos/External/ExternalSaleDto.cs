namespace Singular.Products.Sales.Application.Dtos.External
{
    public class ExternalSaleDto
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public decimal SalePrice { get; set; }
        public int SaleQty { get; set; }
        public string SaleDate { get; set; } = string.Empty; // Use string to match API, convert to DateTime in domain
    }
}
