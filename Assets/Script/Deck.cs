using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Deck : MonoBehaviour
{
    int numberCard;
    Card_Struct[] newDeckCard , CurrentCard = new Card_Struct[52];
    Card_Struct card;
    [SerializeField]Card showCard;
    Card_Struct.ELocation location;
    [SerializeField]Trash trash;
    [SerializeField] GameUI ui;
    [SerializeField] GameObject cardleft;
    public void StartCard(Card_Struct[] deckCard)

    {
        numberCard = 0;
        newDeckCard = new Card_Struct[52];
        int a;
        Card_Struct temp;
        for (int i = 0; i<deckCard.Length; i++) 
        {
            a = UnityEngine.Random.Range(0, deckCard.Length);
            temp = deckCard [i];
            deckCard[i] = deckCard[a];
            deckCard[a] = temp;
            numberCard++;
            deckCard[i].SetCardPosition(numberCard);
        }

        newDeckCard = deckCard;
        ui.DeckText(numberCard);
        ui.Trashtext(0);
    }

    void CheckDeck() 
    
    {
        int curCard= 0;
        for (int i = 0; i < newDeckCard.Length; i++)
        {
            location = newDeckCard[i].GetLocation();
            if (location == Card_Struct.ELocation.Trash)
            {
                trash.addCard(newDeckCard[i]);
                Debug.Log("number " + newDeckCard[i].GetNumber() + "  Symbol " + newDeckCard[i].GetSymbol());
                continue; }
            CurrentCard[curCard] = newDeckCard[i];
            curCard++;
        }
        newDeckCard = CurrentCard; 
    }



    public void TakeTopCard()
    {
        newDeckCard[numberCard - 1].SetLocation(Card_Struct.ELocation.Trash);
        showCard.SetCardData(newDeckCard[numberCard - 1]);
        numberCard--;
        ui.DeckText(numberCard);
        CheckDeck();
    }

    public int NumberCard()
    {
        return numberCard;
    }

    public void SeeCard()
    {
        for (int i = 0; i < newDeckCard.Length; i++)
        {
                float x = -4 + (i%10) * 1f;
                float y = 3 - (math.floor(i/10)) * 1.2f;
                GameObject temp;
                temp = Instantiate(cardleft,transform);
                temp.transform.position = new Vector2(x, y);
                temp.transform.GetComponentInChildren<SpriteRenderer>().sprite = newDeckCard[i].Card();
            temp.transform.localScale= new Vector2 (0.5f,0.5f);
//pake interface belom               IClicked _clicked = _tile[col, row].GetComponent<IClicked>();
//pake interface belom               _clicked.Onclick += Onclick;
    }
}

}
