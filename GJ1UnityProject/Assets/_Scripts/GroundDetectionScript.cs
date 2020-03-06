using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetectionScript : MonoBehaviour
{
    public EnemyScript enemyScript;
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Ingredient")
        {
            enemyScript.switchDir = true;
        }
    }
}
