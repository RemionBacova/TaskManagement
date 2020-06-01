using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApiTaskManagemenk.Repository.Base.EntitiesRepository;
using WebApiTaskManagement.Repository;
using WebApiTaskManagement.Repository.Abstract.Base.EntitiesRepository;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace WebApiTaskManagement
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
           
            
            services.AddScoped<MachinesRepository>();
            services.AddScoped<MachineReportingRepository>();
            services.AddScoped<sp_tbl_TABLE_CATEGORY_Repository>();
            services.AddScoped<sp_tbl_TABLE_Repository>();
            services.AddScoped<sp_tbl_TABLE_TYPE_INFO_Repository>();




            services.AddMvc();
            //Added Smagger service and also different metadata
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("WebApiTaskManagement",
                    new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Title = "WebApiTaskManagement",
                        Version = "1",
                        Contact = new Microsoft.OpenApi.Models.OpenApiContact()
                        {
                            Email = "info@sitel.al",
                            Name = "Internship Team",
                            Url = new Uri("http://www.sitel.com.al/")
                        }
                    });
            });

            services.AddControllers();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
         
        

   //added Swagger middleware
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/WebApiTaskManagement/swagger.json", "WebApiTaskManagement");
                options.RoutePrefix = "";
            });

            app.UseRouting();

           // app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
