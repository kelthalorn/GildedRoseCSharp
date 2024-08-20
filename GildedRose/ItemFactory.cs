using System.Collections.Generic;

namespace GildedRoseKata;

public class ItemFactory
{
    private readonly Dictionary<ItemName, IUpdateItem> _strategies = new()
    {
        [ItemName.Backstage] = new BackstageItem(),
        [ItemName.AgedBrie] = new AgedBrieItem(),
        [ItemName.Sulfuras] = new SulfurasItem(),
        [ItemName.Default] = new DefaultItem(),
    };
    
    public IUpdateItem GetItem(ItemName itemName)
    {
        return _strategies[itemName];
    }
}