using Data.SmartAppt.SQL.Services.Implementation;
using Data.SmartAppt.SQL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.SmartAppt.Services.Implementation;
using Data.SmartAppt.SQL.Injection;

namespace Business.SmartAppt.Injection
{
    public static class SetUp
    {
        public static void AddBusinessLayer(this IServiceCollection services)
        {

            services.AddDataLayer();


            services.AddTransient<IBusiness_BO_service, Business_BO_service>();
        }
    }
}
