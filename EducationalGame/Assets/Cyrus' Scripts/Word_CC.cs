using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word_CC
{
    public string word;
    private int typeIndex;

    public Word_CC(string _word)
    {
        word = _word;
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
    }
}
