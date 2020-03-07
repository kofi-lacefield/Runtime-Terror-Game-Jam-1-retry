using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hat : MonoBehaviour
{
    Image BWWitchHat;
    public Sprite WitchColor;
    public static int WitchAmount;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           
            WitchAmount += 1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        BWWitchHat = GameObject.Find("BWWitchHat").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (WitchAmount == 1) {
            BWWitchHat.sprite = WitchColor;

        }
    }
}
