using AppServices.Profiles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppServices
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection service)
        {
            service.AddAutoMapper(typeof(AlbumsProfile));
            return service;
        }
    }
}
