using System.Collections.Generic;
using System.Threading.Tasks;

public interface IItemService
{
    Task<List<Item>> GetAllItems();
    Task<Item> GetItemById(int id);
    Task AddItem(Item item);
    Task UpdateItem(Item item);
    Task DeleteItem(int id);
}
