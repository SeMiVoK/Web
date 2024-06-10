using Xunit;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ItemServiceTests
{
    [Fact]
    public async Task GetAllItems_ShouldReturnAllItems()
    {
        var mockRepository = new Mock<IItemRepository>();
        var items = new List<Item>
        {
            new Item { Id = 1, Name = "Item 1" },
            new Item { Id = 2, Name = "Item 2" }
        };
        mockRepository.Setup(repo => repo.GetAllItems()).ReturnsAsync(items);

        var itemService = new ItemService(mockRepository.Object);


        var result = await itemService.GetAllItems();

        Assert.Equal(items.Count, result.Count);
    }

}
