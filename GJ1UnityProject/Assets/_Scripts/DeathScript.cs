using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    Transform playerTrans;
    UIScript uiScript;
    bool inside = false;
    // Start is called before the first frame update
    void Start()
    {
        playerTrans = GameObject.FindWithTag("Player").GetComponent<Transform>();
        uiScript = GameObject.FindWithTag("GameController").GetComponent<UIScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (!inside)
        {
            uiScript.lives--;
            inside = true;
        }
        playerTrans.position = new Vector3 (-22.98f, 1.05f, 0f);
    }

    private void OnTriggerExit2D (Collider2D other)
    {
        inside = false;
    }
}
