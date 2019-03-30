using Microsoft.AspNetCore.Mvc;

namespace ADSApi.Controllers.Recursive
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmountOfLowerNumbersController : ControllerBase
    {
        private int[] generateArray(int size)
        {
            int[] arrayToReturn = new int[size];
            int val;
            for(int i = 0; i < size; i++)
            {
                val = i * 10;
                if (i % 2 == 0) val += 5;
                arrayToReturn[i] = val;
            }
            return arrayToReturn;
        }

        [HttpGet("array/{size}")]
        public int[] getArray(int size)
        {
            return generateArray(size);
        }

        [HttpGet("amount/{size}/{number}")]
        public int GetAmountLowerNumbers(int size, int number)
        {
            int[] array = generateArray(size);
            return GetAmountOfLowerNumbers(array, number, 0, array.Length - 1);
        }
    
        private int GetAmountOfLowerNumbers(int[] array, int number, int first, int last)
        {
            if (last < first) return first;
            else
            {
                int midle = (first + last) / 2;
                if (array[midle] < number)
                    first = midle + 1;
                else
                    last = midle - 1;
                return GetAmountOfLowerNumbers(array, number, first, last);
            }
        }
    }
}