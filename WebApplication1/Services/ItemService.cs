using System.Collections.Generic;
using System.Threading.Tasks;

public class ItemService : IItemService
{
    private readonly IItemRepository _itemRepository;

    public ItemService(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }

    public async Task<List<Item>> GetAllItems()
    {
        return await _itemRepository.GetAllItems();
    }

    public async Task<Item> GetItemById(int id)
    {
        return await _itemRepository.GetItemById(id);
    }

    public async Task AddItem(Item item)
    {
        await _itemRepository.AddItem(item);
    }

    public async Task UpdateItem(Item item)
    {
        await _itemRepository.UpdateItem(item);
    }

    public async Task DeleteItem(int id)
    {
        await _itemRepository.DeleteItem(id);
    }
}
