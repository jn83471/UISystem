using System;
using UnityEngine;

[Serializable]
public class Item
{
    public enum ItemType{
        HealthPotion,
        ManaPotion,
        Sword,
        Coin,
        STone,
        Ring
    }
    public ItemType itemType;
    public int amounth;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default: return ItemsAssets.Instance.healthPotionSprite;
            case ItemType.HealthPotion: return ItemsAssets.Instance.healthPotionSprite;
            case ItemType.ManaPotion: return ItemsAssets.Instance.manaPotionSprite;
            case ItemType.Sword: return ItemsAssets.Instance.swordSprite;
            case ItemType.Coin: return ItemsAssets.Instance.coinSprite;
            case ItemType.STone: return ItemsAssets.Instance.stoneSprite;
            case ItemType.Ring: return ItemsAssets.Instance.ringSprite;
        }
    }
}
