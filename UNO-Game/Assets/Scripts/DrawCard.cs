using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DrawCard : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("REEEEEEE");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("AAAAAAAAAAAH");
    }
    private void OnMouseDown()
    {
        Debug.Log("AFHGUIAEGiuyguygs");
    }
}
