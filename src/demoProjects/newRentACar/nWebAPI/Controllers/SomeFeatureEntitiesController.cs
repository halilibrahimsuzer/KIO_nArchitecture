using nApplication.Features.someFeature.Commands.CreateSomeFeature;
using nApplication.Features.someFeature.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace nWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SomeFeatureEntitiesController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSomeFeatureEntityCommand createSomeFeatureEntityCommand)
        {
            //CreatedSomeFeatureEntityDto result = await Mediator.Send(createSomeFeatureEntityCommand);
            return Created("", "");
        }       
    }
}
