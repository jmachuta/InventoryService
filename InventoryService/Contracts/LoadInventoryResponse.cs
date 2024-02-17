namespace InventoryService.Contracts
{
    public class LoadInventoryResponse : BaseResponse
    {
        public List<Item>? Items { get; set; }
    }
}
