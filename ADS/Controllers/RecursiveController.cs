using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ADSApi.Controllers
{
    [Route("api/[controller]")]
    public class RecursiveController : ControllerBase
    {
        [HttpPost]
        public ActionResult<string> Post(Data data)
        {
            return data.Num;
        }

        private int CalcPow(int n, int pow)
        {
            if (pow == 0)
                return 1;
            else
                return CalcPow(n, pow - 1) * n;
        }
    }
}