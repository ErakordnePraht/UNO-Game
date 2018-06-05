using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public string HandColor;
    public string StackColor;
    public Draggable.Slot typeOfItem = Draggable.Slot.TableCard;
    public GameObject MainCard;

    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log(eventData.pointerDrag.name + " Was dropped on " + gameObject.name);
        Card_deck c = new Card_deck();
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            if (typeOfItem == d.typeOfItem)
            {
                d.parentToReturnTo = transform;
            }
            HandColor = MainCard.GetComponent<CardValues>().Color;
            if (HandColor != StackColor)
            {
                d.parentToReturnTo = transform;
            }
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        MainCard = eventData.pointerDrag;
        Debug.Log(MainCard + "asdasasdasd");
    }

    //public void OnPointerDown(PointerEventData eventData)
    //{
    //    Debug.Log("REEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
    //    MainCard = eventData.pointerCurrentRaycast.gameObject;
    //}

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null)
        {
            return;
        }

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.placeholderParent = transform;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null)
        {
            return;
        }

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null && d.placeholderParent == transform)
        {
            d.placeholderParent = d.parentToReturnTo;
        }
    }
}
