using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    Card_Struct[] trashDeck = new Card_Struct[52];
    Card_Struct trashCard;
     int currentCard = 0;
    [SerializeField]GameUI ui;
    public void addCard(Card_Struct add)
    
    {
        trashDeck[currentCard] = add;
        currentCard++;
        ui.Trashtext(currentCard);
        //Debug.Log("number " + trashDeck[currentCard].GetNumber() + "  Symbol " + trashDeck[currentCard].GetSymbol());
    }

    public void SeeCard() 
    {
        Debug.Log("SeeCard");
    }

    public void ResetGame() 
    {
        trashDeck = new Card_Struct[52];
        currentCard = 0;
        ui.Trashtext(currentCard);
    }
}
