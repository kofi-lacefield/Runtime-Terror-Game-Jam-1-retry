using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Candle : MonoBehaviour
{
    //Image BWCandle;
    public Sprite CandleColor;
    public Sprite BW;
    public int CandleAmount;
    public UIScript uIScript;
    public bool ui;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            uIScript.candleAmount += 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (ui)
        {
            gameObject.GetComponent<Image>().sprite = BW;
        }
        //BWCandle = GameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (uIScript.candleAmount == 1) {
            gameObject.GetComponent<Image>().sprite = CandleColor;
        } else {
            if (ui)
            {
                gameObject.GetComponent<Image>().sprite = BW;
            }
        }
    }
}
