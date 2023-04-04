using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct Card
{
    [SerializeField] private Sprite card;
    enum Location { Hand , Trash};
    enum Symbol {Red,Blue,Green,Black };

    enum Number {two,three,four, five, six,seven, eight, nine, ten, Jack , Queen, King, As};

    [SerializeField]private Location location;
    [SerializeField] private Symbol symbol;
    [SerializeField] private Number number;
}
