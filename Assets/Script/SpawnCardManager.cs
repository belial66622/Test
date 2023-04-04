using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class SpawnCardManager : ScriptableObject
{
    public string prefabName;

    public Card_Struct[] card = new Card_Struct[52];
}


