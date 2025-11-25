using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartAppt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        [Route("CreateBusiness")]
        [HttpPost]
        public async Task<bool> CreateBusiness(BusinessEntity business)
        {
            BusinessRepository businessRepository = new BusinessRepository();
            int? Id = await businessRepository.CreateAsync(business);

            return Id.HasValue;
        }
    }
}
