using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;

    public Transform wordCanvas;

    public Rigidbody2D player;

  public WordDisplay SpawnWord()
    {
        Vector2 wordPosition = new Vector2(player.position.x, player.position.y + 0.5f);

        GameObject wordobj = Instantiate(wordPrefab, wordPosition, Quaternion.identity, wordCanvas);
        WordDisplay wordDisplay = wordobj.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
