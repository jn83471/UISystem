using UnityEngine;

public class ItemsAssets : MonoBehaviour
{
    public static ItemsAssets Instance {  get; private set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        Instance = this;
    }

    public Transform itemWorldPrefab;

    public Sprite healthPotionSprite;
    public Sprite manaPotionSprite;
    public Sprite swordSprite;
    public Sprite coinSprite;
    public Sprite stoneSprite;
    public Sprite ringSprite;
}
