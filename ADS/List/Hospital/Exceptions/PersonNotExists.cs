using ADSApi.List.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSApi.List.Hospital.Exceptions
{
    public class PersonNotExists : Exception
    {
        public PersonNotExists(Person p) : base(p.name + " is not on the Hospital.") { }
    }
}
