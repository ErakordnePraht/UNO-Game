using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;
using System.Threading;

public class Card_deck : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private GameObject MainCard;
    public List<Card> Deck;
    public GameObject Copy;
    public Canvas canvas;
    public GameObject Hand;
    public int CardsPlayed = -1;

    void Start()
    {
        #region Array containing all cards
        Deck = new List<Card> {
new Card() { Sprite = num_0_Y, Color = "Yellow", Number = "0" },
new Card() { Sprite = num_1_Y, Color = "Yellow", Number = "1" },
new Card() { Sprite = num_2_Y, Color = "Yellow", Number = "2" },
new Card() { Sprite = num_3_Y, Color = "Yellow", Number = "3" },
new Card() { Sprite = num_4_Y, Color = "Yellow", Number = "4" },
new Card() { Sprite = num_5_Y, Color = "Yellow", Number = "5" },
new Card() { Sprite = num_6_Y, Color = "Yellow", Number = "6" },
new Card() { Sprite = num_7_Y, Color = "Yellow", Number = "7" },
new Card() { Sprite = num_8_Y, Color = "Yellow", Number = "8" },
new Card() { Sprite = num_9_Y, Color = "Yellow", Number = "9" },
new Card() { Sprite = num_1_Y, Color = "Yellow", Number = "1" },
new Card() { Sprite = num_2_Y, Color = "Yellow", Number = "2" },
new Card() { Sprite = num_3_Y, Color = "Yellow", Number = "3" },
new Card() { Sprite = num_4_Y, Color = "Yellow", Number = "4" },
new Card() { Sprite = num_5_Y, Color = "Yellow", Number = "5" },
new Card() { Sprite = num_6_Y, Color = "Yellow", Number = "6" },
new Card() { Sprite = num_7_Y, Color = "Yellow", Number = "7" },
new Card() { Sprite = num_8_Y, Color = "Yellow", Number = "8" },
new Card() { Sprite = num_9_Y, Color = "Yellow", Number = "9" },
new Card() { Sprite = num_0_G, Color = "Green", Number = "0" },
new Card() { Sprite = num_1_G, Color = "Green", Number = "1" },
new Card() { Sprite = num_2_G, Color = "Green", Number = "2" },
new Card() { Sprite = num_3_G, Color = "Green", Number = "3" },
new Card() { Sprite = num_4_G, Color = "Green", Number = "4" },
new Card() { Sprite = num_5_G, Color = "Green", Number = "5" },
new Card() { Sprite = num_6_G, Color = "Green", Number = "6" },
new Card() { Sprite = num_7_G, Color = "Green", Number = "7" },
new Card() { Sprite = num_8_G, Color = "Green", Number = "8" },
new Card() { Sprite = num_9_G, Color = "Green", Number = "9" },
new Card() { Sprite = num_1_G, Color = "Green", Number = "1" },
new Card() { Sprite = num_2_G, Color = "Green", Number = "2" },
new Card() { Sprite = num_3_G, Color = "Green", Number = "3" },
new Card() { Sprite = num_4_G, Color = "Green", Number = "4" },
new Card() { Sprite = num_5_G, Color = "Green", Number = "5" },
new Card() { Sprite = num_6_G, Color = "Green", Number = "6" },
new Card() { Sprite = num_7_G, Color = "Green", Number = "7" },
new Card() { Sprite = num_8_G, Color = "Green", Number = "8" },
new Card() { Sprite = num_9_G, Color = "Green", Number = "9" },
new Card() { Sprite = num_0_Red, Color = "Red", Number = "0" },
new Card() { Sprite = num_1_Red, Color = "Red", Number = "1" },
new Card() { Sprite = num_2_Red, Color = "Red", Number = "2" },
new Card() { Sprite = num_3_Red, Color = "Red", Number = "3" },
new Card() { Sprite = num_4_Red, Color = "Red", Number = "4" },
new Card() { Sprite = num_5_Red, Color = "Red", Number = "5" },
new Card() { Sprite = num_6_Red, Color = "Red", Number = "6" },
new Card() { Sprite = num_7_Red, Color = "Red", Number = "7" },
new Card() { Sprite = num_8_Red, Color = "Red", Number = "8" },
new Card() { Sprite = num_9_Red, Color = "Red", Number = "9" },
new Card() { Sprite = num_1_Red, Color = "Red", Number = "1" },
new Card() { Sprite = num_2_Red, Color = "Red", Number = "2" },
new Card() { Sprite = num_3_Red, Color = "Red", Number = "3" },
new Card() { Sprite = num_4_Red, Color = "Red", Number = "4" },
new Card() { Sprite = num_5_Red, Color = "Red", Number = "5" },
new Card() { Sprite = num_6_Red, Color = "Red", Number = "6" },
new Card() { Sprite = num_7_Red, Color = "Red", Number = "7" },
new Card() { Sprite = num_8_Red, Color = "Red", Number = "8" },
new Card() { Sprite = num_9_Red, Color = "Red", Number = "9" },
new Card() { Sprite = num_0_Blue, Color = "Blue", Number = "0" },
new Card() { Sprite = num_1_Blue, Color = "Blue", Number = "1" },
new Card() { Sprite = num_2_Blue, Color = "Blue", Number = "2" },
new Card() { Sprite = num_3_Blue, Color = "Blue", Number = "3" },
new Card() { Sprite = num_4_Blue, Color = "Blue", Number = "4" },
new Card() { Sprite = num_5_Blue, Color = "Blue", Number = "5" },
new Card() { Sprite = num_6_Blue, Color = "Blue", Number = "6" },
new Card() { Sprite = num_7_Blue, Color = "Blue", Number = "7" },
new Card() { Sprite = num_8_Blue, Color = "Blue", Number = "8" },
new Card() { Sprite = num_9_Blue, Color = "Blue", Number = "9" },
new Card() { Sprite = num_1_Blue, Color = "Blue", Number = "1" },
new Card() { Sprite = num_2_Blue, Color = "Blue", Number = "2" },
new Card() { Sprite = num_3_Blue, Color = "Blue", Number = "3" },
new Card() { Sprite = num_4_Blue, Color = "Blue", Number = "4" },
new Card() { Sprite = num_5_Blue, Color = "Blue", Number = "5" },
new Card() { Sprite = num_6_Blue, Color = "Blue", Number = "6" },
new Card() { Sprite = num_7_Blue, Color = "Blue", Number = "7" },
new Card() { Sprite = num_8_Blue, Color = "Blue", Number = "8" },
new Card() { Sprite = num_9_Blue, Color = "Blue", Number = "9" },
new Card() { Sprite = special_plusTwo_G, Color = "Green", SpecialFunction = "PlusTwo" },
new Card() { Sprite = special_plusTwo_G, Color = "Green", SpecialFunction = "PlusTwo" },
new Card() { Sprite = special_Skip_G, Color = "Green", SpecialFunction = "Skip" },
new Card() { Sprite = special_Skip_G, Color = "Green", SpecialFunction = "Skip" },
new Card() { Sprite = special_Reverse_G, Color = "Green", SpecialFunction = "Reverse" },
new Card() { Sprite = special_Reverse_G, Color = "Green", SpecialFunction = "Reverse" },
new Card() { Sprite = special_plusTwo_Y, Color = "Yellow", SpecialFunction = "PlusTwo" },
new Card() { Sprite = special_plusTwo_Y, Color = "Yellow", SpecialFunction = "PlusTwo" },
new Card() { Sprite = special_Skip_Y, Color = "Yellow", SpecialFunction = "Skip" },
new Card() { Sprite = special_Skip_Y, Color = "Yellow", SpecialFunction = "Skip" },
new Card() { Sprite = special_Reverse_Y, Color = "Yellow", SpecialFunction = "Reverse" },
new Card() { Sprite = special_Reverse_Y, Color = "Yellow", SpecialFunction = "Reverse" },
new Card() { Sprite = special_plusTwo_Blue, Color = "Blue", SpecialFunction = "PlusTwo" },
new Card() { Sprite = special_plusTwo_Blue, Color = "Blue", SpecialFunction = "PlusTwo" },
new Card() { Sprite = special_Skip_Blue, Color = "Blue", SpecialFunction = "Skip" },
new Card() { Sprite = special_Skip_Blue, Color = "Blue", SpecialFunction = "Skip" },
new Card() { Sprite = special_Reverse_Blue, Color = "Blue", SpecialFunction = "Reverse" },
new Card() { Sprite = special_Reverse_Blue, Color = "Blue", SpecialFunction = "Reverse" },
new Card() { Sprite = special_plusTwo_Red, Color = "Red", SpecialFunction = "PlusTwo" },
new Card() { Sprite = special_plusTwo_Red, Color = "Red", SpecialFunction = "PlusTwo" },
new Card() { Sprite = special_Skip_Red, Color = "Red", SpecialFunction = "Skip" },
new Card() { Sprite = special_Skip_Red, Color = "Red", SpecialFunction = "Skip" },
new Card() { Sprite = special_Reverse_Red, Color = "Red", SpecialFunction = "Reverse" },
new Card() { Sprite = special_Reverse_Red, Color = "Red", SpecialFunction = "Reverse" },
new Card() { Sprite = special_chooseColour, Color = "Black", SpecialFunction = "ChooseColour" },
new Card() { Sprite = special_plusFour, Color = "Black", SpecialFunction = "PlusFour" },
new Card() { Sprite = special_chooseColour, Color = "Black", SpecialFunction = "ChooseColour" },
new Card() { Sprite = special_plusFour, Color = "Black", SpecialFunction = "PlusFour" },
new Card() { Sprite = special_chooseColour, Color = "Black", SpecialFunction = "ChooseColour" },
new Card() { Sprite = special_plusFour, Color = "Black", SpecialFunction = "PlusFour" },
new Card() { Sprite = special_chooseColour, Color = "Black", SpecialFunction = "ChooseColour" },
new Card() { Sprite = special_plusFour, Color = "Black", SpecialFunction = "PlusFour" } };
        #endregion

        Deck.Shuffle();

        //Deals cards to player
        for (int i = 0; i < 7; i++)
        {
            CardsPlayed++;
            Copy = Instantiate(MainCard);
            Copy.transform.SetParent(canvas.transform);
            Copy.GetComponent<Image>().sprite = Deck[CardsPlayed].Sprite;
            Copy.GetComponent<CardValues>().Color = Deck[CardsPlayed].Color;
            Copy.GetComponent<CardValues>().Number = Deck[CardsPlayed].Number;
            Copy.GetComponent<CardValues>().SpecialFunction = Deck[CardsPlayed].SpecialFunction;
            Copy.transform.SetParent(Hand.transform);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        CardsPlayed++;
        if (CardsPlayed < 108)
        {
            Copy = Instantiate(MainCard);
            Copy.transform.SetParent(canvas.transform);
            Copy.GetComponent<Image>().sprite = Deck[CardsPlayed].Sprite;
            Copy.GetComponent<CardValues>().Color = Deck[CardsPlayed].Color;
            Copy.GetComponent<CardValues>().Number = Deck[CardsPlayed].Number;
            Copy.GetComponent<CardValues>().SpecialFunction = Deck[CardsPlayed].SpecialFunction;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (CardsPlayed < 108)
        {
            Copy.transform.position = eventData.position; //Keeps card under mouse 
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (CardsPlayed < 108)
        {
            Copy.transform.SetParent(Hand.transform); //Sends card to hand 
        }
    }

    #region Long list of sprites
    public Sprite num_0_Y;
    public Sprite num_1_Y;
    public Sprite num_2_Y;
    public Sprite num_3_Y;
    public Sprite num_4_Y;
    public Sprite num_5_Y;
    public Sprite num_6_Y;
    public Sprite num_7_Y;
    public Sprite num_8_Y;
    public Sprite num_9_Y;
    public Sprite num_0_G;
    public Sprite num_1_G;
    public Sprite num_2_G;
    public Sprite num_3_G;
    public Sprite num_4_G;
    public Sprite num_5_G;
    public Sprite num_6_G;
    public Sprite num_7_G;
    public Sprite num_8_G;
    public Sprite num_9_G;
    public Sprite num_0_Blue;
    public Sprite num_1_Blue;
    public Sprite num_2_Blue;
    public Sprite num_3_Blue;
    public Sprite num_4_Blue;
    public Sprite num_5_Blue;
    public Sprite num_6_Blue;
    public Sprite num_7_Blue;
    public Sprite num_8_Blue;
    public Sprite num_9_Blue;
    public Sprite num_0_Red;
    public Sprite num_1_Red;
    public Sprite num_2_Red;
    public Sprite num_3_Red;
    public Sprite num_4_Red;
    public Sprite num_5_Red;
    public Sprite num_6_Red;
    public Sprite num_7_Red;
    public Sprite num_8_Red;
    public Sprite num_9_Red;
    public Sprite special_Skip_Y;
    public Sprite special_Reverse_Y;
    public Sprite special_plusTwo_Y;
    public Sprite special_Skip_G;
    public Sprite special_Reverse_G;
    public Sprite special_plusTwo_G;
    public Sprite special_Skip_Red;
    public Sprite special_Reverse_Red;
    public Sprite special_plusTwo_Red;
    public Sprite special_Skip_Blue;
    public Sprite special_Reverse_Blue;
    public Sprite special_plusTwo_Blue;
    public Sprite special_chooseColour;
    public Sprite special_plusFour;
    #endregion
}
/// <summary>
/// public Card class, used to set values, such as a number and the color, to specific cards.
/// </summary>
public class Card
{
    public Sprite Sprite { get; set; }
    public string Number { get; set; }
    public string Color { get; set; }
    public string SpecialFunction { get; set; }
}
/// <summary>
/// Inherits from the Card class, adds a "SpecialFunction" string, used to identify if a card can do anything special.
/// </summary>

static class MyExtensions
{
    /// <summary>
    /// Shuffles a list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list"></param>
    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}

public static class ThreadSafeRandom
{
    [ThreadStatic] private static System.Random Local;

    public static System.Random ThisThreadsRandom
    {
        get { return Local ?? (Local = new System.Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
    }
}


