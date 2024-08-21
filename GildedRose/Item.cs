using System.Collections.Generic;

namespace GildedRoseKata;

public record Item
{
    public ItemName Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public Dictionary<ItemName, string> ItemNames { get; } = new ()
    {
        [ItemName.Sulfuras] = "Sulfuras, Hand of Ragnaros",
        [ItemName.AgedBrie] = "Aged Brie",
        [ItemName.Backstage] = "Backstage passes to a TAFKAL80ETC concert",
        [ItemName.Default] = "Default"
        
    };
}

public enum ItemName
{
    Sulfuras,
    AgedBrie,
    Backstage,
    Default,
    Conjured
}