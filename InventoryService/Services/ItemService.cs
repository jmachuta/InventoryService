using InventoryService.Contracts;
using InventoryService.Infrastructure;

namespace InventoryService.Services
{
    public class ItemService : IItemService
    {
        readonly IItemRepository repository;

        public ItemService(IItemRepository repository)
        {
            this.repository = repository;
        }

        public List<Item> LoadAll()
        {
            return repository.LoadAll();
        }

        public void AddItem(AddItemRequest request)
        {
            repository.AddItem(request);
        }
    }
}
