using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// A class that contains all the necessary values to check for legal moves.
/// </summary>
class CardCompatabilityValues : MonoBehaviour
{
    public static string StackColor;
    public static string StackNumber;
    public static int FistTime = -1;
    public Draggable.Slot typeOfItem = Draggable.Slot.TableCard;
    /// <summary>
    /// Checks if played move is legal or not.
    /// </summary>
    /// <param name="MainCard"></param>
    /// <param name="eventData"></param>
    public bool Check(GameObject MainCard/*, PointerEventData eventData*/)
    {
        FistTime += 1;
        string HandColor = MainCard.GetComponent<CardValues>().Color;
        string HandNumber = MainCard.GetComponent<CardValues>().Number;
        string SpecialFunction = MainCard.GetComponent<CardValues>().SpecialFunction;
        if (SpecialFunction == "PlusFour" || SpecialFunction == "ChooseColour" || FistTime == 0)
        {
            Debug.Log("Special card inserted");
            StackColor = "Black";
        }
        if (true)
        {
            if ((SpecialFunction != null && StackColor == HandColor) || ((StackColor == HandColor || StackNumber == HandNumber) && SpecialFunction == null) || StackColor == "Black")
            {
                Debug.Log(StackColor);
                Debug.Log("legal");
                StackColor = HandColor;
                StackNumber = HandNumber;
                return true;
            }
            else
            {
                Draggable d = MainCard.GetComponent<Draggable>();
                if (d != null)
                {
                    if (typeOfItem == d.typeOfItem)
                    {
                        d.parentToReturnTo = GameObject.Find("Hand").transform;
                    }
                }
                //MainCard.transform.SetParent();
                Debug.Log("illegal");
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}

