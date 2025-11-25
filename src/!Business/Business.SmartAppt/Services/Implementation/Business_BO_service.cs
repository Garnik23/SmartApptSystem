using Data.SmartAppt.SQL.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.SmartAppt.SQL.Models;
using Data.SmartAppt.SQL.Services;

namespace Business.SmartAppt.Services.Implementation
{
    public class Business_BO_service
    {
        protected readonly IBusinessRepository _BusinessRepository;


        public Business_BO_service(IBusinessRepository businessRepository)
        {
            //_BusinessRepository = new BusinessRepositoryV2();
            _BusinessRepository = businessRepository;
        }

        public async Task<bool> CreateBusiness(Business business)
        {
            int? Id = await _BusinessRepository.CreateAsync(business);

            return Id.HasValue;
        }
    }
}
