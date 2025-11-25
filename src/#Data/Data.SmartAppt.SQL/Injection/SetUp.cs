using Data.SmartAppt.SQL.Services;
using Data.SmartAppt.SQL.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.SmartAppt.SQL.Injection
{
    public static class SetUp
    {
        public static void AddDataLayer(this IServiceCollection services)
        {
            services.AddScoped<IBusinessRepository, BusinessRepository>();
        }
    }
}
