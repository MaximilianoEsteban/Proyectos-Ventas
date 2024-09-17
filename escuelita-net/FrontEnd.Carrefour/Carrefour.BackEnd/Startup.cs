using Carrefour.BackEnd.Helpers;
using Carrefour.BackEnd.Interfaces;
using Carrefour.BackEnd.Repository;
using Carrefour.BackEnd.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Carrefour.BackEnd
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
            services.AddControllers();
            services.AddScoped<SqlConnection>(x => {
                string conString = this.Configuration.GetValue<string>("ConnectionStrings:default");
                return new SqlConnection(conString);
                }
            );
            services.AddScoped<ComprobanteRepository>();
            services.AddScoped<FormaPagoRepository>();
            services.AddScoped<ProductoRepository>();
            services.AddScoped<MarcaRepository>();
            services.AddScoped<LineaRepository>();
            services.AddScoped<SubLineaRepository>();
            services.AddScoped<TipoRepository>();
            services.AddScoped<UnidadRepository>();
            services.AddScoped<PerfilRepository>();
            services.AddScoped<UsuarioRepository>();
            services.AddScoped<VentasRepository>();
            services.AddScoped<ComprobanteService>();
            services.AddScoped<FormaPagoService>();
            services.AddScoped<ProductoService>();
            services.AddScoped<MarcaService>();
            services.AddScoped<LineaService>();
            services.AddScoped<SubLineaService>();
            services.AddScoped<TipoService>();
            services.AddScoped<UnidadService>();
            services.AddScoped<PerfilService>();
            services.AddScoped<UsuarioService>();
           

            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<EmailSenderOptions>(Configuration.GetSection("EmailSenderOptions"));

            services.AddScoped<AESEncrypter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
