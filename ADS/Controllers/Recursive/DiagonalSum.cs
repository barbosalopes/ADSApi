using ADSApi.Controllers.Util;
using Microsoft.AspNetCore.Mvc;

namespace ADSApi.Controllers.Recursive
{
    [Route("api/[controller]")]
    public class DiagonalSum : ControllerBase
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

        // List to be delivered 2
        /*
         * 5 – Escreva um método recursivo para calcular o valor da série 
         * representada por 1/2 + 3/4 + 5/6 + 7/8 + ..... + n/(n+1)
         */
         public int Calculate(int n)
        {
            if (n == 1) return (n / n + 1);
            else return (n / n + 1) + Calculate(n - 1);
        }
    }
}
 