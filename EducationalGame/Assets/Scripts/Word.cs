using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Word 
{
    public string word;
    private int typeIndex;

    WordDisplay display;

    public Word(string _word, WordDisplay _display) //Constructor Allows you to set a variable to setup stuff
    {
        word = _word;
        typeIndex = 0;
        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++; // Remove the letter on screen
        display.RemoveLetter();
    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            display.RemoveWord();//Remove the word on the screen
        }
        return wordTyped;
    }
}
