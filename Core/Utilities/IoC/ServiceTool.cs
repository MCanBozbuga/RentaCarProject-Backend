using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    /// <summary>
    ///  .NET 'in service collection yani servislerini kullnarak servislerini al ve onları build et bu kod bizim web api de veya autofact'de oluşturduğumuz injectionları oluşturabilmemizi yarıyor
    /// </summary>
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
