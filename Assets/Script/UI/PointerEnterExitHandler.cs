using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PointerEnterExitHandler : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    private Image _img;

    private Color originalColor=Color.white;
    private Color darkColor;
    private void Start()
    {
        _img = GetComponent<Image>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("El puntero ha entrado en el àrea del Raycaster");
        darkColor = _img.color;
        _img.color = originalColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("El puntero ha salido en el àrea del Raycaster");
        _img.color = darkColor;
    }
}
