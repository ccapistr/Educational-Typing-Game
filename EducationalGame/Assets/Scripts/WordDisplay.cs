using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{

    public Text text;

    public void SetWord (string word)
    {
        text.text = word; 
    }


    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1); //removes a single letter
        text.color = Color.red; //when removing a letter, the word being focused on is red.
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

}
