using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSApi.Controllers
{
    public class SimpleItem
    {

        public SimpleItem(string id, string value)
        {
            this.Id = id;
            this.Value = value;
        }
        
        public string Id { get; set; }
        public string Value { get; set; }
    }
}
