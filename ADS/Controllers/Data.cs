using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSApi.Controllers
{
    public class Data
    {
        public Data(string num, string pow)
        {
            this.Num = num;
            this.Pow = pow;
        }

        public string Num { set; get; }
        public string Pow { set; get; }
    }

}
