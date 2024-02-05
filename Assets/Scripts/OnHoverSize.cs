using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnHoverSize : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Vector3 startFontSize;
    public void Start()
    {
        startFontSize = transform.localScale;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale *= 1.1f;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = startFontSize;
    }
}
