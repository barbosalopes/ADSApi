using Microsoft.AspNetCore.Mvc;

namespace ADSApi.Controllers.Recursive
{
    [Route("api/[controller]")]
    [ApiController]
    public class VowelRemoverController : ControllerBase
    {
        private string VOWELS = "aeiouAEIOU";

        [HttpGet("recursive/")]
        public string RecursiveController()
        {
            string phrase = "This phrase has no vowels!";
            return RecursiveVowelRemover(phrase);
        }

        /// <summary>
        /// Remove the vowels of the string on a recursive way.
        /// </summary>
        /// 
        /// <param name="phrase"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        private string RecursiveVowelRemover(string phrase, int pos = 0)
        {
            if (pos == phrase.Length - 1)
                return phrase;
            else
            {
                if(VOWELS.IndexOf(phrase[pos]) > 0)
                {
                    phrase = phrase.Remove(pos);
                    return RecursiveVowelRemover(phrase, pos);
                }
                else 
                    return RecursiveVowelRemover(phrase, pos + 1);
            }
        }
    }
}