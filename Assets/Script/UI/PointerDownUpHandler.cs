using UnityEngine;
using UnityEngine.EventSystems;

public class PointerDownUpHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler,IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button==PointerEventData.InputButton.Right)
        {
            Debug.Log("Click en " + eventData.pointerCurrentRaycast.gameObject.name);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("El puntero ha hecho click en " + eventData.pointerCurrentRaycast.gameObject.name);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("El puntero ha soltado el click en " + eventData.pointerCurrentRaycast.gameObject.name);
    }
}
