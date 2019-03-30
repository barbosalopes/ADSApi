using System;

namespace ADSApi.List.Hospital.Exceptions
{
    public class InvalidLocation : Exception
    {
        public InvalidLocation(string location) : base("The location " + location + " does not exists") { }
    }
}
