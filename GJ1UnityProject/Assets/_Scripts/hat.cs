using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hat : MonoBehaviour
{
    //Image BWWitchHat;
    public Sprite WitchColor;
    public Sprite BW;
    public int WitchAmount;
    public UIScript uIScript;
    public bool ui;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            uIScript.witchAmount += 1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (ui)
        {
            gameObject.GetComponent<Image>().sprite = BW;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (uIScript.witchAmount == 1) {
            gameObject.GetComponent<Image>().sprite = WitchColor;
        } else {
            if (ui)
            {
                gameObject.GetComponent<Image>().sprite = BW;
            }
        }
    }
}
