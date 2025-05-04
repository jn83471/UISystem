using System;
using UnityEngine;
using UnityEngine.UI;

public class UiInventory : MonoBehaviour
{
    [SerializeField]
    private Transform itemsContainer;
    [SerializeField]
    private GameObject itemsTemplate;

    private Inventory inventory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        inventory.OnItemListChanged += InventorChanged;
        RefreshInventory();
    }

    private void InventorChanged(object sender, EventArgs e)
    {
        RefreshInventory();
    }

    public void RefreshInventory()
    {
        foreach(Transform child in itemsContainer)
        {
            if (child == itemsTemplate) continue;
            Destroy(child.gameObject);
        }
        foreach(Item i in inventory.GetItems())
        {
            RectTransform newUiItem = Instantiate(itemsTemplate, itemsContainer).GetComponent<RectTransform>();
            newUiItem.name=i.itemType.ToString();

            Image img=newUiItem.Find("Border/Image").GetComponent<Image>();
            img.sprite=i.GetSprite();
        }
    }
}
