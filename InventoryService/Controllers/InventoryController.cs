using InventoryService.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace InventoryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IItemService itemService;

        public InventoryController(IItemService itemService)
        {
            this.itemService = itemService;
        }

        // GET: api/<InventoryController>
        [HttpGet]
        public string Get()
        {
            return "App is running";
        }

        // GET api/<InventoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return id.ToString();
        }

        // POST api/<InventoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // GET api/<InventoryController>/load
        [HttpGet("load")]
        public string LoadInventory()
        
        {
            var items = itemService.LoadAll();
            return JsonSerializer.Serialize(items);
        }

        // GET api/<InventoryController>/add
        [HttpGet("add")]
        public string AddItem()
        {
            return "added";
        }

        // GET api/<InventoryController>/update
        [HttpGet("update")]
        public string UpdateItem()
        {
            return "updated";
        }

        // GET api/<InventoryController>/delete
        [HttpGet("delete")]
        public string Delete()
        {
            return "deleted";
        }
    }
}
