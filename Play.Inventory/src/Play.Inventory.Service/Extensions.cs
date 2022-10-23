using Play.Inventory.Service.Models;
using Play.Inventory.Service.Dtos;

namespace Play.Inventory.Service
{
    public static class Extentions
    {
        public static InventoryItemDto AsDto(this InventoryItem item, string name, string description)
        {
            return new InventoryItemDto(item.CatalogItemId, name, description, item.Quantity, item.AcquiredDate);
        }
    }
}