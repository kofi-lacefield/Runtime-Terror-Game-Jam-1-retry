using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetectionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public EnemyScript enemyScript;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            enemyScript.switchDir = true;
        }
    }
}
