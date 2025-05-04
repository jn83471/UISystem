using UnityEngine;

public class ItemWorldSpawner : MonoBehaviour
{
    public Item item;
    private void Start()
    {
        ItemWord.SpawnItemWordl(transform.position, item);
        Destroy(gameObject);
    }
}
