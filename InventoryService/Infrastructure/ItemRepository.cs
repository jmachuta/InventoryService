using InventoryService.Contracts;
using InventoryService.Infrastructure.Extensions;
using System.Data;
using System.Data.SqlClient;

namespace InventoryService.Infrastructure
{
    public class ItemRepository : IItemRepository
    {
        public ItemRepository()
        {
        }

        public List<Item> LoadAll()
        {
            var items = new List<Item>();

            var connection = new SqlConnection(DatabaseConnectionString.ConnectionString);
            connection.Open();

            var command = new SqlCommand("[dbo].[usp_GetAllItems]", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var item = new Item
                {
                    Id = reader["ItemID"].ToInt32(),
                    Name = reader["Name"].ToString(),
                    Quantity = reader["Quantity"].ToInt32(),
                    CategoryID = reader["CategoryID"].ToInt32(),
                    LocationID = reader["LocationID"].ToInt32()
                };

                items.Add(item);
            }

            reader.Close();
            connection.Close();

            return items;
        }

        public void AddItem(AddItemRequest request)
        {
            var connection = new SqlConnection(DatabaseConnectionString.ConnectionString);
            connection.Open();

            var command = new SqlCommand("[dbo].[usp_AddItem]", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = request.Name;
            command.Parameters.Add("@Quantity", SqlDbType.Int).Value = request.Quantity;
            command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = request.CategoryID;
            command.Parameters.Add("@LocationID", SqlDbType.Int).Value = request.LocationID;

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
