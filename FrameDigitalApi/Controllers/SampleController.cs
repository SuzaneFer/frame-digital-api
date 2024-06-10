using FrameDigitalApi.Business.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FrameDigitalApi.Controllers
{
    [ApiController]
    [Route("")]
    public class SampleController : ControllerBase
    {
        private readonly ISampleBusiness _business;

        public SampleController(ISampleBusiness business)
        {
            _business = business;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var dto = _business.GetSample();
            return Ok(dto);
        }
    }
}
