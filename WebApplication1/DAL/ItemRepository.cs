using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ItemRepository : IItemRepository
{
    private readonly YourDbContext _context;

    public ItemRepository(YourDbContext context)
    {
        _context = context;
    }

    public async Task<List<Item>> GetAllItems()
    {
        return await _context.Items.ToListAsync();
    }

    public async Task<Item> GetItemById(int id)
    {
        return await _context.Items.FindAsync(id);
    }

    public async Task AddItem(Item item)
    {
        _context.Items.Add(item);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateItem(Item item)
    {
        _context.Entry(item).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteItem(int id)
    {
        var itemToDelete = await _context.Items.FindAsync(id);
        _context.Items.Remove(itemToDelete);
        await _context.SaveChangesAsync();
    }
}
