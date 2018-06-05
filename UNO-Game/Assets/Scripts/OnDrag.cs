using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class OnDrag : DropZone, IBeginDragHandler
{
    public GameObject OnBeginDrag(PointerEventData eventData)
    {
        MainCard = eventData.pointerDrag;
        Debug.Log(MainCard + "asdasasdasd");

        return MainCard;
    }
}
