using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public enum Suit
    {
        Clubs,
        Spades,
        Diamonds,
        Hearts
    }

    public enum Value
    {
        Ace = 11,
        King = 10,
        Queen = 10,
        Jack = 10,
        Ten = 10,
        Nine = 9,
        Eight = 8,
        Seven = 7,
        Six = 6,
        Five = 5,
        Four = 4,
        Three = 3,
        Two = 2
    }

    public Suit cardSuit
    {
        get;
        set;
    }

    public Value cardValue
    {
        get;
        set;
    }
}
