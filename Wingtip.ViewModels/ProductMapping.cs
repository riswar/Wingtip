using AutoMapper;
using Wingtip.Domain;

namespace Wingtip.ViewModels
{
    public class ProductMapping : Profile
    {
        public ProductMapping()

        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
