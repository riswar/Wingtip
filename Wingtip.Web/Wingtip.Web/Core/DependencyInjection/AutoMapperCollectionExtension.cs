using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Wingtip.ViewModels;

namespace Wingtip.Web.Core.DependencyInjection
{
    public static class AutoMapperCollectionExtension
    {
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
          
            services.AddAutoMapper(typeof(ProductMapping));
            return services;
        }
    }
}
