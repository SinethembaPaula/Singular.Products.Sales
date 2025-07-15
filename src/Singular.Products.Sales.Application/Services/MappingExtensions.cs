using Singular.Products.Sales.Application.Dtos;
using Singular.Products.Sales.Application.Dtos.External;
using Singular.Products.Sales.Domain.Entities;
using System.Globalization;

namespace Singular.Products.Sales.Application.Services
{
    public static class MappingExtensions
    {
        // ExternalProductDto -> Domain Product
        public static Product ToDomain(this ExternalProductDto dto)
        {
            return new Product
            {
                Id = dto.Id,
                Description = dto.Description,
                SalePrice = dto.SalePrice,
                Category = dto.Category,
                Image = dto.Image
            };
        }

        // Domain Product -> ProductDto
        public static ProductDto ToDto(this Product domain)
        {
            return new ProductDto
            {
                Id = domain.Id,
                Description = domain.Description,
                SalePrice = domain.SalePrice,
                Category = domain.Category,
                Image = domain.Image
            };
        }

        public static Sale ToDomain(this ExternalSaleDto dto)
        {
            return new Sale
            {
                SaleId = dto.SaleId,
                ProductId = dto.ProductId,
                SalePrice = dto.SalePrice,
                SaleQty = dto.SaleQty,
                SaleDate = DateTime.Parse(dto.SaleDate, CultureInfo.InvariantCulture)
            };
        }

        public static SaleDto ToDto(this Sale domain)
        {
            return new SaleDto
            {
                SaleId = domain.SaleId,
                ProductId = domain.ProductId,
                SalePrice = domain.SalePrice,
                SaleQty = domain.SaleQty,
                SaleDate = domain.SaleDate
            };
        }

        public static ProductSalesSummaryDto ToSummaryDto(this Product product, IEnumerable<Sale> sales)
        {
            return new ProductSalesSummaryDto
            {
                ProductId = product.Id,
                Description = product.Description,
                TotalSalesAmount = sales.Sum(s => s.SalePrice * s.SaleQty),
                TotalSalesQuantity = sales.Sum(s => s.SaleQty)
            };
        }
    }
}
