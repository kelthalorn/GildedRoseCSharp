using System.Collections.Generic;
using NFluent;
using NUnit.Framework;

namespace GildedRoseKata;

public class GildedRoseShould
{
    [Test]
    public void quality_and_sellin_never_change()
    {
        List<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", Quality = 0, SellIn = 0 } };
        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        Check.That(items[0].Name).IsEqualTo("Sulfuras, Hand of Ragnaros");
        Check.That(items[0].Quality).IsEqualTo(0);
        Check.That(items[0].SellIn).IsEqualTo(0);
    }

    [Test]
    public void aged_brie_increases_in_quality_with_depreciated_date()
    {
        var item = new Item { Name = "Aged Brie", Quality = 0, SellIn = 0 };
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();

        Check.That(items[0].Quality).IsEqualTo(2);
        Check.That(items[0].SellIn).IsEqualTo(-1);
    }
    
    [Test]
    public void aged_brie_increases_in_quality_from_sellIn_1()
    {
        var item = new Item { Name = "Aged Brie", Quality = 0, SellIn = 1 };
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();

        Check.That(items[0].Quality).IsEqualTo(1);
        Check.That(items[0].SellIn).IsEqualTo(0);
    }

    [Test]
    public void backstage_ticket_increase_quality_of_2_when_10_days_before_concert_date()
    {
        var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 6, SellIn = 10 };
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();

        Check.That(items[0].Quality).IsEqualTo(8);
        Check.That(items[0].SellIn).IsEqualTo(9);
    }

    [Test]
    public void backstage_ticket_increase_quality_of_3_when_6_days_before_concert_date()
    {
        var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 6, SellIn = 5 };
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();

        Check.That(items[0].Quality).IsEqualTo(9);
        Check.That(items[0].SellIn).IsEqualTo(4);
    }

    [Test]
    public void backstage_ticket_quality_passed_to_0_when_concert_date_is_passed()
    {
        var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 6, SellIn = -1 };
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();

        Check.That(items[0].Quality).IsEqualTo(0);
        Check.That(items[0].SellIn).IsEqualTo(-2);
    }

    [Test]
    public void quality_decrease_when_other_items_sellIn_passed_negative()
    {
        var item = new Item { Name = "default", Quality = 6, SellIn = -1 };
        var items = new List<Item> { item };
        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();

        Check.That(items[0].Quality).IsEqualTo(4);
        Check.That(items[0].SellIn).IsEqualTo(-2);
    }
}