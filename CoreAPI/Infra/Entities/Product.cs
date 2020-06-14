using Infra;
using Infra.Entities;

namespace Infra
{
    public class Product:BaseEntity
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PictureUrl { get; set; }

        public ProductType  ProductType { get; set; }
        public ProductCategories ProductCategories { get; set; }
        public int ProductTypeId { get; set; }

        public ProductBand ProductBand { get; set; }

        public int ProductBrandId { get; set; }

        public int ProductCategoriesId { get; set; }

        public bool productFlag { get; set; }

        
    }
}