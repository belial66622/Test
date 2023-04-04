using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct Card_Struct
{
    [SerializeField] private Sprite card;
    public enum ELocation { Deck, Hand , Trash };
    public enum ESymbol {Red,Blue,Green,Black };

    public enum ENumber {two,three,four, five, six,seven, eight, nine, ten, Jack , Queen, King, As};

    [SerializeField]private ELocation location;
    [SerializeField] private ESymbol symbol;
    [SerializeField] private ENumber number;
    private int cardPositon;
    

    public ELocation GetLocation()
    { 
        
        return location; 
    
    }

    public ELocation SetLocation(ELocation elocation)
    {
        location = elocation;
        return location;

    }

    public string GetSymbol()
    {

        return symbol.ToString();

    }

    public ESymbol SetSymbol(ESymbol esymbol)
    {
        symbol = esymbol;
        return symbol;

    }

    public string GetNumber()
    {

        return number.ToString();

    }

    public ENumber SetNumber(ENumber enumber)
    {
        number = enumber;
        return number;

    }

    public Sprite Card()
    {
        return card;
    }
    public int SetCardPosition(int a)
    {
        cardPositon = a;
        return cardPositon;
    }

    public int GetCardPosition()
    {
        return cardPositon;
    }
}
