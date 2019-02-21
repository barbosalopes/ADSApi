using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ADSApi.Controllers
{
    [Route("api/[controller]")]
    public class QueueController : ControllerBase
    {
        private List<SimpleItem> queue;
        private int nextId;

        private IMemoryCache _cache;
        private const string QUEUE_KEY = "queue";

        public QueueController(IMemoryCache memoryCache)
        {
            _cache = memoryCache;
            if (_cache.Get(QUEUE_KEY) == null)
            {
                queue = new List<SimpleItem>();
                _cache.Set(QUEUE_KEY, queue);
            }
            else
            {
                queue = (List<SimpleItem>)_cache.Get(QUEUE_KEY);
            }
        }

        [HttpGet]
        public ActionResult<List<SimpleItem>> Get()
        {
            return queue;
        }

        [HttpPost]
        public ActionResult<int> Post(SimpleItem item)
        {
            int id = queue.Count();
            SimpleItem itemToAdd = new SimpleItem(id.ToString(), item.Value);
            queue.Add(itemToAdd);
            return id;
        }

        [HttpDelete]
        public ActionResult<SimpleItem> Delete()
        {
            int pos = 0;

            SimpleItem removedItem = queue[pos];
            queue.RemoveAt(pos);
            return removedItem;
        }
    }
}