namespace GildedRoseKata;

internal class ConjuredItem : IUpdateItem
{
    public void UpdateQuality(Item item)
    {
        if (item.IsOverMinQuality())
        {
            item.Quality--;
            item.Quality--;
        }

        item.SellIn--;

        if (item.IsOverMinQuality())
        {
            item.Quality--;
            item.Quality--;
        }
    }
}