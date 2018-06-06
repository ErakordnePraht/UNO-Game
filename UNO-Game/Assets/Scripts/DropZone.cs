using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Draggable.Slot typeOfItem = Draggable.Slot.TableCard;
    /// <summary>
    /// Sets where the card goes when you drop it somewhere on the playtable.
    /// </summary>
    /// <param name="eventData"></param>
    public GameObject Hand;
    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log(eventData.pointerDrag.name + " Was dropped on " + gameObject.name);
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            if (typeOfItem == d.typeOfItem)
            {
                d.parentToReturnTo = transform;
                Debug.Log("Ayyyy");
                CardCompatabilityValues legal = new CardCompatabilityValues();
                if (legal.Check(Draggable.MainCard))
                {
                    Debug.Log("true");
                    return;
                }
                else
                {
                    Debug.Log("false");

                    Draggable.MainCard.transform.position = Hand.transform.position;
                }
            }
        }
    }
    /// <summary>
    /// Moves the "placeholder card" to the canvas where your mouse is currently at, so that the animation works.
    /// </summary>
    /// <param name="eventData"></param>
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
    /// <summary>
    /// Checks if the "placeholder card" was moved to a canvas and if not then it leaves the "placeholder card" on the last canvas and does the animation there.
    /// </summary>
    /// <param name="eventData"></param>
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
