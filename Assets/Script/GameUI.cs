using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI Deck , Trash;
    [SerializeField] private Button resetButton;
    [SerializeField] private Button seeCardButton;
    [SerializeField] private CardManager manager;
    // Start is called before the first frame update
    void Start()
    {
        OnClickReset();
        OnClickSeeCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeckText(int a)
    { 
        Deck.text = "Card : " + a;
    }

    public void Trashtext(int b)
    { 
        Trash.text= "Card Left : " +b;
    }

    private void OnClickReset()
    {
        resetButton.onClick.AddListener(ResetGame);
    }

    private void ResetGame()
    {
        manager.Onstart();
    }

    private void OnClickSeeCard()
    { 
        seeCardButton.onClick.AddListener(SeeCard);
    }

    private void SeeCard()
    {
        manager.SeeCard();
    }


}
