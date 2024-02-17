namespace InventoryService.Contracts
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public string? Error { get; set; }
    }
}
