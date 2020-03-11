using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class houseScript : MonoBehaviour
{
    public hat hatScript;
    public Pumpkin pumpkinScript;
    public Candle candleScript;
    public Bat batScript;
    public UIScript uIScript;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
           if (hatScript.WitchAmount == 1 && pumpkinScript.PumpkinAmount == 1 && candleScript.CandleAmount == 1 && batScript.BatAmount == 1)
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
