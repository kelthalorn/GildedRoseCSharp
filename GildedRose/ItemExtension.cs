namespace GildedRoseKata;

public static class ItemExtension
{
    public static bool IsExpired(this Item item)
    {
        return item.SellIn < 0;
    }

    public static bool IsUnderMaxQuality(this Item item)
    {
        return item.Quality < 50;
    }

    public static bool IsOverMinQuality(this Item item)
    {
        return item.Quality > 0;
    }

    public static bool IsUnderSellInLimit(this Item item, int limit)
    {
        return item.SellIn < limit;
    }
    
    public static void ResetQuality(this Item item)
    {
        item.Quality = 0;
    }
}