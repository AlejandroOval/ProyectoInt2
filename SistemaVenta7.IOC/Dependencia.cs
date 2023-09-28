﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVenta7.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SistemaVenta7.DAL.Interfaces;
using SistemaVenta7.DAL.Implementacion;
using SistemaVenta7.Entity;
using SIstemaVenta7.BLL.Interfaces;
using SIstemaVenta7.BLL.Implementacion;

namespace SistemaVenta7.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DBVENTAContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CadenaSQL"));
            });

            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IVentaRepository, VentaRepository>();

            services.AddScoped<ICorreoService, CorreoService>();
            services.AddScoped<IFireBaseService, FireBaseService>();

            services.AddScoped<IUtilidadesService, UtilidadesService>();
            services.AddScoped<IRolService, RolService>();
        }
    }
}
