using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ADSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactorialController : ControllerBase
    {
        /// <summary>
        /// Calculates a factorial in iterative way.
        /// </summary>
        /// <complexity>
        ///     <principal_process>Multiplication.</principal_process>
        ///     <cost>N+1</cost>
        ///     <class>O(N)</class>
        /// </complexity>
        /// <param name="num">Number to calculate the factorial.</param>
        /// <returns>
        /// The factorial of the given number.
        /// </returns>
        [HttpGet("iterative/{num}")]
        public uint GetIterative(uint num)
        {
            uint res = 1;
            for(uint i = num; i > 0; i--)
            {
                res *= i;
            }
            return res;
        }

        /// <summary>
        /// Calculates a factorial in recursive way.
        /// </summary>
        /// <complexity>
        ///     <principal_process>Multiplication.</principal_process>
        ///     <cost>N+1</cost>
        ///     <class>O(N)</class>
        /// </complexity>
        /// <param name="num">Number to calculate the factorial.</param>
        /// <returns>
        /// The factorial of the given number.
        /// </returns>
        [HttpGet("recursive/{num}")]
        public uint RecursiveFactorial(uint num)
        {
            if (num == 1)
                return 1;
            else
                return num * RecursiveFactorial(num - 1);
        }
    }
}