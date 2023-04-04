using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Card : MonoBehaviour
{
    private Card_Struct card;
    [SerializeField]private GameObject seeCard;
    private Sprite spritecard;
    private void Start()
    {
        

    }

    public void SetCardData(Card_Struct newCard)
    {
        card = newCard;
        spritecard = card.Card();
        if (this.transform.childCount == 0)
        {
            Instantiate(seeCard, transform);
        seeCard.GetComponentInChildren<SpriteRenderer>().sprite = spritecard; 
        }
        else
        {
            seeCard.GetComponentInChildren<SpriteRenderer>().sprite = spritecard;
        }
    }
}
