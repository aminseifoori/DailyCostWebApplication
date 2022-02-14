using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.FileProviders;
using System.IO;
using DailyCostWebApplication.Models;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace DailyCostWebApplication
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<WebAppDBContext>
                (options=> options.UseSqlServer(Configuration.GetConnectionString("CostDBConnectionSQLServer")));
            //services.AddControllersWithViews().AddXmlSerializerFormatters();
            services.AddControllersWithViews();
            services.AddSingleton<ICostRepository, StaticCostRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {

                app.UseDeveloperExceptionPage(new DeveloperExceptionPageOptions { SourceCodeLineCount = 10 });
            }
            var cultureInfo = new CultureInfo("en-UK");
            cultureInfo.NumberFormat.CurrencySymbol = "£";
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            app.UseStaticFiles();
            app.UseRouting();
            

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllers();
                endpoints.MapDefaultControllerRoute();
                //endpoints.MapControllerRoute(
                //        name: "default",
                //        pattern: "{Controller=home}/{Action=index}/{id?}/{name?}"
                //    );
            });



            //FileServerOptions fileServerOptions = new FileServerOptions();
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("myhtml.html");
            //app.UseFileServer(fileServerOptions);

            //FileServerOptions fileServerOptions1 = new FileServerOptions
            //{
            //    FileProvider = new PhysicalFileProvider
            //    (
            //        Path.Combine(env.ContentRootPath, "StaticFiles")
            //    ),
            //    RequestPath = "/MyStaticFiles"
            //};
            //app.UseFileServer(fileServerOptions1);

            //StaticFileOptions staticFileOptions = new StaticFileOptions
            //{
            //    FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, "StaticFiles")),
            //    RequestPath = "/StaticFiles"
            //};

            //app.UseStaticFiles(staticFileOptions);

            //DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            //defaultFilesOptions.DefaultFileNames.Clear();
            //defaultFilesOptions.DefaultFileNames.Add("myhtml.html");
            //app.UseDefaultFiles(defaultFilesOptions);
            //app.UseStaticFiles();

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("MW1 Income \n");
            //    await next();
            //    await context.Response.WriteAsync("MW1 OutCome \n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("MW2 Income \n");
            //    await next();
            //    await context.Response.WriteAsync("MW2 OutCome \n");
            //});

            //endpoints.MapGet("/", async context =>
            //{
            //    //await context.Response.WriteAsync(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
            //    //await context.Response.WriteAsync(env.EnvironmentName);
            //    //await context.Response.WriteAsync("Hello From Use EndPoints Middleware! \n");
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
