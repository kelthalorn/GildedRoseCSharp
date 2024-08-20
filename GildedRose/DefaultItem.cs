namespace GildedRoseKata;

public class DefaultItem : IUpdateItem
{
    public void UpdateQuality(Item item)
    {
        if (item.IsOverMinQuality())
        {
            item.Quality--;
        }

        item.SellIn--;
        if (item.IsOverMinQuality())
        {
            item.Quality--;
        }
    }
}