using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropHandle : MonoBehaviour,IInitializePotentialDragHandler,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    private RectTransform _rectTransform;
    private Canvas _canvas;
    private CanvasGroup _canvasGroup;
    private Vector2 originalPosition;

    

    private void Awake()
    {
       _rectTransform = GetComponent<RectTransform>();
        _canvas = GetComponent<Canvas>();
        _canvasGroup = GetComponent<CanvasGroup>();
        
    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
        Debug.Log("potencial arrastrable initialized on " + gameObject.name);
        originalPosition = _rectTransform.anchoredPosition;

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("potencial arrastrable started on " + gameObject.name);
        _canvasGroup.alpha = 0.6f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging " + gameObject.name);
        _rectTransform.anchoredPosition += eventData.delta / _canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("potencial arrastrable end " + gameObject.name);
    }
}
