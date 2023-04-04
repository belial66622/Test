using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI Deck , Trash;
    [SerializeField] private Button button;
    [SerializeField] private CardManager manager;
    // Start is called before the first frame update
    void Start()
    {
        OnClickReset();   
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
        button.onClick.AddListener(ResetGame);
    }

    private void ResetGame()
    {
        manager.Onstart();
    }
}
