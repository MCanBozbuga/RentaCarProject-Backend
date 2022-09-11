using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extension
{
    public static class ServiceCollectionExtensions
    {
        //Neyi genişletmek istiyorsan " this " kullanmalısın. Extensions kullanmak için static yapmalısın.
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }
            return ServiceTool.Create(serviceCollection);
            //Ekleyeceğimiz bütün injectionları toplayabilceğimiz bir yapı.
        }
    }
}
