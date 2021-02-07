using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Piranha;
using Piranha.AspNetCore.Identity.SQLite;
using Piranha.AttributeBuilder;
using Piranha.Data.EF.SQLite;
using Piranha.Local;

namespace PiranhaTest
{
   public class Startup
   {
      // This method gets called by the runtime. Use this method to add services to the container.
      // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
      public void ConfigureServices(IServiceCollection services)
      {
         services.AddPiranha(options =>
         {
            options.AddRazorRuntimeCompilation = true;
            options.UseFileStorage(naming: FileStorageNaming.UniqueFolderNames);
            options.UseImageSharp();
            options.UseManager();
            options.UseTinyMCE();
            options.UseMemoryCache();
            //options.UseAliasRouting = true;
            //options.UsePageRouting = true;
            options.UseEF<SQLiteDb>(db =>
                db.UseSqlite("Filename=./piranha.db"));
            options.UseIdentityWithSeed<IdentitySQLiteDb>(db =>
                db.UseSqlite("Filename=./piranha.db"));
         });
         //services.AddRazorPages()
         //   .AddRazorPagesOptions(options =>
         //   {
         //      //options.RootDirectory = "/Pages";
         //      options.Conventions.AddPageRoute("/Pages/MySimplePage", "");
         //   });
      }

      // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
      public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApi api)
      {
         if (env.IsDevelopment())
         {
            app.UseDeveloperExceptionPage();
         }

         App.Init(api);

         // Build content types
         new ContentTypeBuilder(api)
            .AddAssembly(typeof(Startup).Assembly)
            .Build()
            .DeleteOrphans();

         app.UsePiranha(options =>
         {
            options.UseManager();
            options.UseSummernote();
            options.UseTinyMCE();
            options.UseIdentity();
         });

         //app.UseRouting();

         //app.UseEndpoints(endpoints =>
         //{
         //   endpoints.MapRazorPages();
         //});

         //app.UseEndpoints(endpoints =>
         //{
         //   endpoints.MapGet("/MySimplePage", async context =>
         //      {
         //         Page = "/MySimplePage";  
         //      });
         //});
      }
   }
}
