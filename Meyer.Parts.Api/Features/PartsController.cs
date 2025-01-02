using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Meyer.Parts.Api.Features;

[Route("Parts")]
[ApiController]
public class PartsController(IPartsService service) : ControllerBase
{
    [HttpPost("quantity")]
    public async Task<List<ItemQuantity>> GetItemQuantities([FromBody]List<ItemLocationRequest> items)
    {
        return await service.GetItemQuantities(items);
    }
}
