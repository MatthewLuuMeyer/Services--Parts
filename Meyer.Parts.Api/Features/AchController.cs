using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Meyer.Parts.Api.Features;

[Route("Parts")]
[ApiController]
public class PartsController(IPartsService service) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult> Example()
    {
        await service.PlaceHolder();

        return Ok();
    }
}
