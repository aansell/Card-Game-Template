using UnityEngine;
using UnityEngine.EventSystems;
public class DraggableUI : MonoBehaviour,
IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    
    {   
        // Called once when the drag starts
        Debug.Log("Started dragging " + gameObject.name);
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        // Called every frame while dragging
        rectTransform.anchoredPosition += eventData.delta /
        canvas.scaleFactor;
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        // Called once when the drag ends
        Debug.Log("Finished dragging " + gameObject.name);
    }
}