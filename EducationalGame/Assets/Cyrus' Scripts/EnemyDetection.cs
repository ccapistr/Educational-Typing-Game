using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    public LayerMask player;

    public bool detectedPlayer;

    public float angle = 0.25f;
    public Vector2 playerDetection;
    public Vector2 size;

    private Color debugColor = Color.yellow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        detectedPlayer = Physics2D.OverlapBox((Vector2)transform.position + playerDetection, size, angle, player);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        var position = new Vector2[] { playerDetection };
        Gizmos.DrawWireCube((Vector2)transform.position + playerDetection, size);
    }
}
