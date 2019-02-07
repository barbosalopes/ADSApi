using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ADSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StackController : ControllerBase
    {
        private List<SimpleItem> stack;
        private string valor;

        private IMemoryCache _cache;
        private const string STACK_KEY = "stack";

        public StackController(IMemoryCache memoryCache)
        {
            _cache = memoryCache;
            if(_cache.Get(STACK_KEY) == null)
            {
                stack = new List<SimpleItem>();
                _cache.Set(STACK_KEY, stack);
            } else {
                stack = (List<SimpleItem>)_cache.Get(STACK_KEY); 
            }

        }

        [HttpGet]
        public ActionResult<List<SimpleItem>> Get()
        {
            return (List<SimpleItem>)_cache.Get(STACK_KEY);
        }

        [HttpPost("{value}")]
        public ActionResult<string> Post(string value)
        {
            string id = stack.Count.ToString();
            SimpleItem item = new SimpleItem(id, value);
            stack.Add(item);
            return id;
        }

        [HttpDelete]
        public ActionResult<SimpleItem> Delete()
        {
            int pos = stack.Count - 1;
            
            SimpleItem removedItem = stack[pos];
            stack.RemoveAt(pos);
            return removedItem;
        }
    }
}