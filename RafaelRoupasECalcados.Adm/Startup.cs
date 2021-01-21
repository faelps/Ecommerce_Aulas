using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RafaelRoupasECalcados.Adm.Models.Contexto;
using RafaelRoupasECalcados.Adm.Repositorio;
using RafaelRoupasECalcados.Adm.Repositorio.Interface;
using RafaelRoupasECalcados.Adm.Servicos;
using RafaelRoupasECalcados.Adm.Servicos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RafaelRoupasECalcados.Adm
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
            DependencyInjection(services);
            services.AddControllersWithViews();
            services.AddMvc();
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
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void DependencyInjection(IServiceCollection services)
        {
            services.AddDbContext<LojaContexto>();

            services.AddScoped<ICatagoriaServico, CategoriaServico>();
            services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();

            services.AddScoped<IProdutoServico, ProdutoServico>();
            services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
        }
    }
}
