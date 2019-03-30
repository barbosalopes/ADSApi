using Microsoft.AspNetCore.Mvc;
using ADSApi.List;

namespace ADSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathExpressionController : ControllerBase
    {
        [HttpGet("convert/{expression}")]
        public ActionResult<string[]> Get(string expression)
        {
            return PosFixedConverter.Convert(expression).ToArray();
        }

    }
}