namespace ADSApi.Controllers.Util
{
    public class SimpleItem
    {
        public SimpleItem(string id, string value)
        {
            Id = id;
            Value = value;
        }
        
        public string Id { get; set; }
        public string Value { get; set; }
    }
}
