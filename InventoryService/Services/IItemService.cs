using InventoryService.Contracts;

namespace InventoryService.Services
{
    public interface IItemService
    {
        List<Item> LoadAll();
        void AddItem(AddItemRequest request);
    }
}
