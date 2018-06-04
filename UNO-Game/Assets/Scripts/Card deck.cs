using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Card[] Deck = new Card[] { };
	}
}

public class Card
{
    public string Number { get; set; }
    public string Color { get; set;}
}

public class SpecialCard : Card
{
    public string SpecialFunction { get; set; }
}
