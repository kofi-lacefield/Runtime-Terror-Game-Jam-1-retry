using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bat : MonoBehaviour
{
    //Image BWBat;
    public Sprite BatColor;
    public Sprite BW;
    public int BatAmount;
    public UIScript uIScript;
    public bool ui;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            uIScript.batAmount += 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (ui)
        {
            gameObject.GetComponent<Image>().sprite = BW;
        }
        //BWBat = GameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (uIScript.batAmount == 1) {
            gameObject.GetComponent<Image>().sprite = BatColor;
        } else {
            if (ui)
            {
                gameObject.GetComponent<Image>().sprite = BW;
            }
        }
    }
}
