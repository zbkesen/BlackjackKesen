using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParent
{
    private int handValue;
    private int numOfCards;

    public int NumOfCards
    {
        get
        {
            return numOfCards;
        }
    }

    public int HandValue
    {
        get
        {
            return handValue;
        }
        set
        {
            handValue = value;
        }
    }
    public void Draw()
    {
        numOfCards = 2;
    }

    public void Hit()
    {
        numOfCards++;
    }
}
