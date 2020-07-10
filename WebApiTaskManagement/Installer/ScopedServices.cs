
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using WebApiTaskManagemenk.Repository.Base.EntitiesRepository;
using WebApiTaskManagement.Repository;
using WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository;
using WebApiTaskManagement.Repository.Base.EntitiesRepository;
using WebApiTaskManagement.Repository.Concrete;

namespace WebApiTaskManagement.Installer
{
    public class ScopedServices : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddTransient<MachinesRepository>();
            services.AddTransient<MachineReportingRepository>();
            services.AddTransient<sp_tbl_TABLE_CATEGORY_Repository>();
            services.AddTransient<sp_tbl_TABLE_Repository>();
            services.AddTransient<sp_tbl_TABLE_TYPE_INFO_Repository>();
            services.AddTransient<sp_tbl_TABLE_TYPE_INFO_CH_Repository>();
            services.AddTransient<sp_tbl_TABLE_TYPE_Repository>();
            services.AddTransient<sp_tbl_TABLE_INFO_Repository>();
            services.AddScoped<sp_tbl_INTER_TABLE_TABLE_Repository>();
            services.AddTransient<tbl_ENTITIES_Repository>();
            services.AddTransient<Login_Repository>();
            services.AddTransient<tbl_MENU_Repository>();
            services.AddTransient<spi_getTree_Repository>();
            services.AddSingleton<HttpClient>();

        }
    }
}
