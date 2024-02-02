using Microsoft.AspNetCore.Mvc;

namespace InventoryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
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
            return "inventory";
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
