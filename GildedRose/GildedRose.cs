using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    private readonly ItemFactory _itemFactory;
    
    public GildedRose(IList<Item> Items)
    {
        _itemFactory = new ItemFactory();
        
        this.Items = Items;

    }

    public void UpdateQuality()
    {
        foreach (var item in Items)
        {
            _itemFactory.GetItem(item.Name).UpdateQuality(item);
        }
    }
}