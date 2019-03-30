using ADSApi.List.Util;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ADSApi.Controllers.Queue
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonGeneratorController : ControllerBase
    {
        [HttpGet("person")]
        public async Task<ActionResult<Person>> GetPersonAsync()
        {
            Task<Person> getPersonTask = PersonGenerator.GetPersonAsync();
            Person p = await getPersonTask;
            return p;
        }
    }
}