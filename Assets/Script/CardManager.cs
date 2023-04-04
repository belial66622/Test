using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] private Card_Struct[] startcard = new Card_Struct[52];
    [SerializeField] private SpawnCardManager cardHolder;
    [SerializeField] private Trash trash;
    [SerializeField] private Deck deck;

    private void Start()
    {
        Onstart();
    }


    public void Onstart()
    {
        startcard = new Card_Struct[52];
        startcard = cardHolder.card;
        resetcard();
        deck.StartCard(startcard);
        trash.ResetGame();
    }  

    private void resetcard()
    {
        for (int i = 0; i < startcard.Length; i++)
        {
            startcard[i].SetLocation(Card_Struct.ELocation.Deck);
        }
    }


    public void SeeCard()
    {
        deck.SeeCard();
    }
}
