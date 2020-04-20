using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;

    public Transform wordCanvas;



  public WordDisplay SpawnWord()
    {
        //Create a vector2 position for the word to spawn in (ideally above the character)


        GameObject wordobj = Instantiate(wordPrefab, wordCanvas);
        WordDisplay wordDisplay = wordobj.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
