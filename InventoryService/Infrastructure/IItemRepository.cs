using InventoryService.Contracts;

namespace InventoryService.Infrastructure
{
    public interface IItemRepository
    {
        List<Item> LoadAll();
        void AddItem(AddItemRequest request);
    }
}
