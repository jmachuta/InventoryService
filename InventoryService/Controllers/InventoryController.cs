using InventoryService.Contracts;
using InventoryService.Services;
using Microsoft.AspNetCore.Mvc;

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

        // GET: api/inventory
        [HttpGet]
        public string Get()
        {
            return "App is running";
        }

        // GET api/inventory/load
        [HttpGet("load")]
        public IActionResult LoadInventory()
        
        {
            try
            {
                var response = new LoadInventoryResponse
                {
                    Success = true,
                    Items = itemService.LoadAll()
                };

                return new JsonResult(response);
            }
            catch (Exception)
            {
                // Potentially log exception in future
                return new JsonResult(new LoadInventoryResponse { Success = false, Error = "Error occurred while adding item" });
            }
        }

        // POST api/inventory/add
        [HttpPost("add")]
        public IActionResult AddItem([FromBody] AddItemRequest request)
        {
            try
            {
                itemService.AddItem(request);
                return new JsonResult(new AddItemResponse { Success = true });
            }
            catch (Exception)
            {
                // Potentially log exception in future
                return new JsonResult(new AddItemResponse { Success = false, Error = "Error occurred while adding item" });
            }
        }

        // GET api/inventory/update
        [HttpGet("update")]
        public string UpdateItem()
        {
            return "updated";
        }

        // GET api/inventory/delete
        [HttpGet("delete")]
        public string Delete()
        {
            return "deleted";
        }
    }
}
