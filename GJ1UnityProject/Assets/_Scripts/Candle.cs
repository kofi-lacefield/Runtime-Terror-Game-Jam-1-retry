using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Candle : MonoBehaviour
{
    Image BWCandle;
    public Sprite CandleColor;
    public static int CandleAmount;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            CandleAmount += 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        BWCandle = GameObject.Find("BWCandle").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CandleAmount == 1) {
            BWCandle.sprite = CandleColor;

        }
    }
}
