using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager_CC : MonoBehaviour
{

    public List<Word_CC> words;

    private bool hasActiveWord;
    private Word_CC activeWord;

    private void Start()
    {
        AddWord_CC();
        AddWord_CC();
        AddWord_CC();
        Debug.Log("hello word");
    }

    public void AddWord_CC()
    {
        Word_CC word = new Word_CC(WordGenerator_CC.GetRandomWord_CC());

        Debug.Log(word.word);
        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            //Check if letter was next
                //remove it from the word
        }
        else
        {
            foreach(Word_CC word in words)
            {
                if(word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }
    }
}
