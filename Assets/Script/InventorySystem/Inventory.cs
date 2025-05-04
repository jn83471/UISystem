

using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public event EventHandler OnItemListChanged;

    public List<Item> itemList;

    public Inventory()
    {
        itemList=new List<Item>();
        Debug.Log("Inventory");
        AddItem(new Item() { itemType = Item.ItemType.HealthPotion, amounth = 1 });
        AddItem(new Item() { itemType = Item.ItemType.ManaPotion, amounth = 1 });
        AddItem(new Item() { itemType = Item.ItemType.Sword, amounth = 1 });
        Debug.Log(itemList.Count);
    }
    public void AddItem(Item item)
    {
        itemList.Add(item);
        OnItemListChanged?.Invoke(this, new EventArgs());
    }
    public List<Item> GetItems() {
        return itemList;
    }
}
