using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    private EnemyDetection enemy;
    public bool playerTyping = false;

    public bool allWordsTyped;

    public WordManager wordManager;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<EnemyDetection>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy.detectedPlayer && playerTyping == false)
        {
            playerTyping = true;
            Debug.Log("hello word");
            wordManager.AddWord();
            
            player.GetComponent<CharacterScript>().enabled = false;
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        }
        if (wordManager.playerFinishedTyping && enemy.detectedPlayer)
        {
            FinishedTyping();
        }
        if (allWordsTyped && enemy.detectedPlayer)
        {
            allWordsTyped = false;
            Destroy(gameObject);
        }
    }

    public void FinishedTyping()
    {
        playerTyping = false;
        allWordsTyped = true;
        player.GetComponent<CharacterScript>().enabled = true;
        wordManager.playerFinishedTyping = false;
    }
}
