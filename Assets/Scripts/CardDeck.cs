using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDeck
{
    private string suit;
    private int value;

    public string Suit(int suitNum)
    {
        switch (suitNum)
        {
            case 0: return "Spades";
                break;
            case 1: return "Clubs";
                break;
            case 2: return "Hearts";
                break;
            case 3: return "Diamonds";
                break;
            default: return "Error";
                break;
        }
    }
}
