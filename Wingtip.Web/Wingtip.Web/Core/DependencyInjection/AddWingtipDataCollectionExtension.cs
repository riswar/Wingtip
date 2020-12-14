using Microsoft.Extensions.DependencyInjection;
using Wingtip.Data;

namespace Wingtip.Web.Core.DependencyInjection
{
    public static class AddWingtipDataCollectionExtension
    {
        public static IServiceCollection AddWingtipData(this IServiceCollection services)
        {

            services.AddSingleton<IWingtopContext, WingtopContext>();
            services.AddScoped<IProductData, ProductData>();
            return services;
        }
    }
}
