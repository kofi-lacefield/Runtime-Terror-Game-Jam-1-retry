using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pumpkin : MonoBehaviour
{
    Image BWPumpkin;
    public Sprite PumpkinColor;
    public static int PumpkinAmount;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            PumpkinAmount += 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        BWPumpkin = GameObject.Find("BWPumpkin").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PumpkinAmount == 1) {
            BWPumpkin.sprite = PumpkinColor;
        }
    }
}
