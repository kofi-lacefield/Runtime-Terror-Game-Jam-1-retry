using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject Player;

    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)//private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Player.GetComponent<Move2D>().isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)//private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")//collider
        {
            Player.GetComponent<Move2D>().isGrounded = false;
        }
    }
}
