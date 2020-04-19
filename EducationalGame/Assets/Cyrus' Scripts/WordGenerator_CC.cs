using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator_CC : MonoBehaviour
{
    public static string[] wordList_CC = { "word", "Talk", "The", "spot", "love", "smash", "anger", "organic" };

    public static string GetRandomWord_CC()
    {
        int RandomIndex = Random.Range(0, wordList_CC.Length);
        string RandomWord = wordList_CC[RandomIndex];

        return RandomWord;

    }
}
