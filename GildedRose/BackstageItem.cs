namespace GildedRoseKata;

public class BackstageItem : IUpdateItem
{
    public void UpdateQuality(Item item)
    {
        if (item.IsUnderMaxQuality())
        {
            item.Quality++;

            if (item.IsUnderSellInLimit(11))
            {
                if (item.IsUnderMaxQuality())
                {
                    item.Quality++;
                }
            }

            if (item.IsUnderSellInLimit(6))
            {
                if (item.IsUnderMaxQuality())
                {
                    item.Quality++;
                }
            }
        }

        item.SellIn--;

        if (item.IsExpired())
        {
            item.ResetQuality();
        }
    }
}