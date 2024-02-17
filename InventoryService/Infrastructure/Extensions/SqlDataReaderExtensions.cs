namespace InventoryService.Infrastructure.Extensions
{
    public static class SqlDataReaderExtensions
    {
        public static int ToInt32(this object obj)
        {
            return int.TryParse(obj.ToString(), out int result) ? result : 0;
        }
    }
}
