namespace InventoryService.Contracts
{
    public class AddItemRequest
    {
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public int CategoryID { get; set; }
        public int LocationID { get; set; }
    }
}
