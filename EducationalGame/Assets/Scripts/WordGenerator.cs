using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = {"word", "Talk", "The", "spot", "love", "smash", "anger", "organic"};


   public static string GetRandomWord() // Method for getting random word from string array
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
