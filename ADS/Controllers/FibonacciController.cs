using Microsoft.AspNetCore.Mvc;
using System;

namespace ADSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        /// <summary>
        /// Calculate the fibonacci value on the passed position.
        /// </summary>
        /// <complexity>
        ///     <principal_process>Sum.</principal_process>
        ///     <cost>2N</cost>
        ///     <class>O(N)</class>
        /// </complexity>
        /// <param name="pos">Possition to calculate the fibonacci.</param>
        /// <returns>
        /// The fibonacci value.
        /// </returns>
        [HttpGet("iterative/{pos}")]
        public uint IterativeFibonacci(uint pos)
        {
            uint[] values = new uint[pos + 1];
            for(uint i = 0; i <= pos; i++)
            {
                // +1 
                if(i >= 2)
                    // +1
                    values[i] = values[i - 2] + values[i - 1];
                else
                    values[i] = 1;
            }
            return values[pos];
        }

        /// <summary>
        /// Calculate the fibonacci on recursive way.
        /// </summary>
        /// <complexity>
        ///     <principal_process>Sum.</principal_process>
        ///     <cost>2N</cost>
        ///     <class>O(N)</class>
        /// </complexity>
        /// <param name="pos"></param>
        /// <returns></returns>
        [HttpGet("recursive/{pos}")]
        public uint RecursiveFibonacci(uint pos)
        {
            if (pos < 2)
                return 1;
            else
                return RecursiveFibonacci(pos - 2) + RecursiveFibonacci(pos - 1);
        }

    }
}