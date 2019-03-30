using Microsoft.AspNetCore.Mvc;

namespace ADSApi.Controllers.Recursive
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatrixController : ControllerBase
    {
        [HttpGet("recursive/")]
        public int RecursiveController()
        {
            int[,] matrix = new int[,] { { 2, 2 }, { 3, 3 } };
            return RecursiveDiagonalSum(matrix);        
        }


        /// <summary>
        /// Calculates the sum of the array diagonal on a recursive way.
        /// </summary>
        /// <complexity>
        ///     <principal_process>Sum.</principal_process>
        ///     <cost>2N</cost>
        ///     <class>O(N)</class>
        /// </complexity>
        /// </summary>
        /// <param name="matrix">Matrix to be sum.</param>
        /// <param name="xAxis">Actual position being sum.</param>
        /// <returns>Result of the sum.</returns>
        public int RecursiveDiagonalSum(int[,] matrix, int xAxis = 0)
        {
            if (xAxis == matrix.GetLength(1) - 1)
                return matrix[xAxis, xAxis];
            else
                return matrix[xAxis, xAxis] + RecursiveDiagonalSum(matrix, xAxis + 1);
        }

        [HttpGet("iterative/")]
        public int IterativeController()
        {
            int[,] matrix = new int[,] { { 2, 2 }, { 3, 3 } };
            return IterativeDiagonalSum(matrix);
        }

        /// <summary>
        /// Calculates the sum of the array diagonal on a iterative way.
        /// </summary>
        /// <complexity>
        ///     <principal_process>Sum.</principal_process>
        ///     <cost>2N</cost>
        ///     <class>O(N)</class>
        /// </complexity>
        /// </summary>
        /// <param name="matrix">Matrix to be sum.</param>
        /// <returns>Result of the sum.</returns>
        public int IterativeDiagonalSum(int[,] matrix)
        {
            int sum = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }
    }
}