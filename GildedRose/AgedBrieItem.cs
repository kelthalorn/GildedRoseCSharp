namespace GildedRoseKata;

public class AgedBrieItem : IUpdateItem
{
    public void UpdateQuality(Item item)
    {
        if (item.IsUnderMaxQuality())
        {
            item.Quality++;
        }
                    
        item.SellIn--;

        if (item.IsExpired())
        {
            if (item.IsUnderMaxQuality())
            {
                item.Quality++;
            }
        }
    }
}