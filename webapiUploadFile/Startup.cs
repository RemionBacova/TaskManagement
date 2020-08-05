using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using webapiUploadFile.Repository;
using webapiUploadFile.Services;

namespace webapiUploadFile
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<tbl_FilesRepository>();
            services.AddTransient<tbl_FileTypeRepository>();
            services.AddTransient<FileService>();


            services.AddMvc();
            //Added Smagger service and also different metadata
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("webapiUploadFiles",
                    new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Title = "WebApiUploadFiles",
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

            app.UseHttpsRedirection();

            //added Swagger middleware
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/webapiUploadFiles/swagger.json", "WebApiUploadFiles");
                options.RoutePrefix = "";
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
