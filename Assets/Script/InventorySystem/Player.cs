using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private UiInventory uiInventory;
    private Inventory inventory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inventory = new Inventory();   
        uiInventory.SetInventory(inventory);

        /*ItemWord.SpawnItemWordl(new Vector3(-.4f, -2.82f), new Item { itemType = Item.ItemType.HealthPotion, amounth = 1 });
        ItemWord.SpawnItemWordl(new Vector3(-.6f, -2.82f), new Item { itemType = Item.ItemType.ManaPotion, amounth = 1 });
        ItemWord.SpawnItemWordl(new Vector3(-.8f, -2.82f), new Item { itemType = Item.ItemType.Sword, amounth = 1 });*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ItemWord itemWord=collision.GetComponent<ItemWord>();
        if (itemWord != null)
        {
            inventory.AddItem(itemWord.getItem());
            itemWord.DestroySelf();
        }
    }
}
