using UnityEngine;

public class ItemWord : MonoBehaviour
{
    private Item item;


    public static ItemWord SpawnItemWordl(Vector3 position,Item item)
    {
        Transform transform=Instantiate(ItemsAssets.Instance.itemWorldPrefab, position,Quaternion.identity);
        ItemWord itemWord=transform.GetComponent<ItemWord>();
        itemWord.SetItem(item);
        return itemWord;
    }

    public void SetItem(Item item)
    {
        this.item = item;
        spriteRenderer.sprite=item.GetSprite();
    }

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Item getItem()
    {
        return this.item;
    }

    // Update is called once per frame
    public void DestroySelf()
    {
        Destroy(this.gameObject);
    }
}
