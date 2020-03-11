using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pumpkin : MonoBehaviour
{
    //Image BWPumpkin;
    public Sprite PumpkinColor;
    public int PumpkinAmount;
    public UIScript uIScript;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            uIScript.pumpkinAmount += 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //BWPumpkin = GameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (uIScript.pumpkinAmount == 1) {
            gameObject.GetComponent<Image>().sprite = PumpkinColor;
        }
    }
}
