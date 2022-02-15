using Core.Entities;

namespace Core.Specification
{
    public class ProductWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductWithFiltersForCountSpecification(ProductSpecPrams productPrams)
                        : base(x =>
                (string.IsNullOrEmpty(productPrams.Search) || x.Name.ToLower().Contains(productPrams.Search)) &&
                (!productPrams.TypeId.HasValue || x.ProductTypeId == productPrams.TypeId) &&
                (!productPrams.BrandId.HasValue || x.ProductBrandId == productPrams.BrandId)
            )
        {
        }
    }
}