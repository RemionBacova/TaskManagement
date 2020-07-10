using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTaskManagement;

namespace WebApiTaskManagement.Installer { 
    public static class InstallerExtensions
    {
        //Calls all scoped services
        public static void InstallServicesInAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            var scopedServices = typeof(Startup).Assembly.ExportedTypes
                .Where(o => typeof(IInstaller).IsAssignableFrom(o) && !o.IsInterface
                && !o.IsAbstract).Select(Activator.CreateInstance).Cast<IInstaller>().ToList();

            scopedServices.ForEach(o => o.InstallServices(services, configuration));
        }
    }
}
