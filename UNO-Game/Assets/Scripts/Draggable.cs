using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// Mostly used for the animation of dragging a card over your hand.
/// </summary>
/// <remarks>
/// Has a "placeholder" card, that is invisible, that goes in-between the cards in your hand while the user is dragging a card around.
/// The placeholder card gets deleted after the user lets go of the mouse.
/// </remarks>
public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parentToReturnTo = null;
    public Transform placeholderParent = null;
    GameObject placeholder = null;
    public static GameObject MainCard;

    public enum Slot { TableCard, HandCard };
    public Slot typeOfItem = Slot.TableCard;
    /// <summary>
    /// When you start dragging it makes a new "placeholder card" which is then used for animation purposes.
    /// Sets the parent which the object was taken from and moves it from one place to another.
    /// </summary>
    /// <param name="eventData"></param>
    /// 
    private void Start()
    {
        //Table = GameObject.FindGameObjectWithTag("Table");
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        //HandPosition = Input.mousePosition;
        MainCard = eventData.pointerDrag;
        placeholder = new GameObject();
        placeholder.transform.SetParent(transform.parent);
        LayoutElement layoutElement = placeholder.AddComponent<LayoutElement>();
        layoutElement.preferredWidth = GetComponent<LayoutElement>().preferredWidth;
        layoutElement.preferredHeight = GetComponent<LayoutElement>().preferredHeight;
        layoutElement.flexibleWidth = 0;
        layoutElement.flexibleHeight = 0;

        placeholder.transform.SetSiblingIndex(transform.GetSiblingIndex());

        parentToReturnTo = transform.parent;
        placeholderParent = parentToReturnTo;
        transform.SetParent(transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    /// <summary>
    /// Does the animation while moving the card.
    /// </summary>
    /// <param name="eventData"></param>
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;

        if (placeholder.transform.parent != placeholderParent)
        {
            placeholder.transform.SetParent(placeholderParent);
        }

        int NewSiblingIndex = placeholderParent.childCount;

        for (int i = 0; i < placeholderParent.childCount; i++)
        {
            if (transform.position.x < placeholderParent.GetChild(i).position.x)
            {
                NewSiblingIndex = i;

                if (placeholder.transform.GetSiblingIndex() < NewSiblingIndex)
                {
                    NewSiblingIndex--;
                }

                break;
            }
        }
        placeholder.transform.SetSiblingIndex(NewSiblingIndex);
    }
    /// <summary>
    /// Sets the parent after ending the drag and destroys the "placeholder card" after it's no longer needed.ss
    /// </summary>
    /// <param name="eventData"></param>
    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentToReturnTo);
        transform.SetSiblingIndex(placeholder.transform.GetSiblingIndex());
        GetComponent<CanvasGroup>().blocksRaycasts = true;

        Destroy(placeholder);

        Card_deck c = new Card_deck();
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
    }
}
