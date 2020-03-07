using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bat : MonoBehaviour
{
    Image BWBat;
    public Sprite BatColor;
    public static int BatAmount;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            BatAmount += 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        BWBat = GameObject.Find("BWBat").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BatAmount == 1) {
            BWBat.sprite = BatColor;
        }
    }
}
