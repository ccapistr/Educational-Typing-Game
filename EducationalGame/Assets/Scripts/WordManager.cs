using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{

   public List <Word> words;

    public WordSpawner wordSpawner;
   

    private bool hasActiveWord;
    private Word ActiveWord;

    public PlayerDetection player;

    private void Start()
    {
        //AddWord();
        //AddWord();
        //AddWord();
    }

    public void AddWord() // Method for pulling Random Word 
    {


        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if (ActiveWord.GetNextLetter() == letter)
            {
                ActiveWord.TypeLetter();


            }
            // check if letter was next 
            //Remove it from the word

        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    ActiveWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && ActiveWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(ActiveWord);

            //When word has been removed, set player movement active again
            player.FinishedTyping();
        }


    }



}
