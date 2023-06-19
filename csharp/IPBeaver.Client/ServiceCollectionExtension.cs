using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IPFox.Client
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddIPFoxClient(this IServiceCollection services, string serviceUrl)
        {
            services.AddTransient<IIPLookupService, IPLookupService>();
            var setting = new ServiceSetting();
            setting.ServiceUrl = serviceUrl;
            services.AddSingleton<ServiceSetting>(setting);
            services.AddHttpClient();
            return services;
        }
    }
}
