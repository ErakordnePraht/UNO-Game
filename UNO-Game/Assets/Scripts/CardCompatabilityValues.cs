using UnityEngine;

/// <summary>
/// A class that contains all the necessary values to check for legal moves.
/// </summary>
class CardCompatabilityValues : MonoBehaviour
{
    public static string StackColor;
    public static string StackNumber;
    public static string StackFunction;

    public static int FirstTime = -1;
    public Draggable.Slot typeOfItem = Draggable.Slot.TableCard;
    /// <summary>
    /// Checks if played move is legal or not.
    /// </summary>
    /// <param name="MainCard"></param>
    /// <param name="eventData"></param>
    public bool Check(GameObject MainCard)
    {
        FirstTime += 1;
        string HandColor = MainCard.GetComponent<CardValues>().Color;
        string HandNumber = MainCard.GetComponent<CardValues>().Number;
        string SpecialFunction = MainCard.GetComponent<CardValues>().SpecialFunction;
        if (SpecialFunction == "PlusFour" || SpecialFunction == "ChooseColour" || FirstTime == 0)
        {
            StackColor = "Black";
        }
        if (true)
        {
            if (((StackColor == HandColor || (StackNumber == HandNumber && SpecialFunction == null) || (SpecialFunction == StackFunction && SpecialFunction != null)) && (SpecialFunction != "PlusFour" && SpecialFunction != "ChooseColour")) || //If card is compatible with last card it is allowed
               StackColor == "Black") //If stack color is black all cards are allowed
            {
                StackColor = HandColor;
                StackNumber = HandNumber;
                StackFunction = SpecialFunction;
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
                return false;
            }
        }
    }
}

