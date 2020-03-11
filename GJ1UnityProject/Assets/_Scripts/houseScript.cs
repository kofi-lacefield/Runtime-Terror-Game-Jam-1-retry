using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class houseScript : MonoBehaviour
{
    public UIScript uIScript;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
           if (uIScript.witchAmount == 1 && uIScript.pumpkinAmount == 1 && uIScript.candleAmount == 1 && uIScript.batAmount == 1)
           {
               if (uIScript.level == 3)
               {
                   uIScript.winGame();
               } else {
                    uIScript.changeLevel();
               }
           }
        }
    }
}
