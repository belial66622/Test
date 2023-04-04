using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Card_Data", menuName = "ScriptableObjects/SpawnCardManager", order = 1)]
public class SpawnManagerScriptableObject : ScriptableObject
{
    public string prefabName;

    public Card[] card = new Card[52];
}
