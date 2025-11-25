using Data.SmartAppt.SQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.SmartAppt.SQL.Services.Implementation
{
    public class BusinessRepositoryV2 : BusinessRepository
    {
        public override Task<int?> CreateAsync(BusinessEntity data)
        {
            return base.CreateAsync(data);
        }
    }
}
