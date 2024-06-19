using FrameDigitalApi.Business.Interface;
using FrameDigitalApi.Dto;
using Microsoft.AspNetCore.Mvc;

namespace FrameDigitalApi.Controllers;

[ApiController]
[Route("")]
public class SampleController : ControllerBase
{
    private readonly ISampleBusiness _business;

    public SampleController(ISampleBusiness business)
    {
        _business = business;
    }

    [HttpPost]
    [Route("teste")]
    [ProducesResponseType(200, Type = typeof(SampleDto))]
    [ProducesResponseType(404)]
    public IActionResult Get()
    {
        var dto = _business.GetSample();
        return Ok(dto);
    }
}
