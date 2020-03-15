using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;

    public bool switchDir = false;

    public float movementSpeed;
    GameObject player;
    //CircleCollider2D collider2D;
    public UIScript uiScript;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        //collider2D = getComponent<CircleCollider2D>();
        //uiScript = GameObject.FindWithTag("GameController").GetComponent<UIScript>();
        movementSpeed = uiScript.enemySpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (switchDir && movementSpeed != 0f)
        {
            StartCoroutine(turn());
        }
        Vector3 movement = new Vector3(1f, 0f, 0f);
        transform.position += movement * Time.deltaTime * movementSpeed;
    }

    IEnumerator turn()
    {
        // switch sprite direction
        mySpriteRenderer = GetComponent<SpriteRenderer>();

        float pastMovementSpeed = movementSpeed;
        movementSpeed = 0f;
        yield return new WaitForSeconds(1f);

        mySpriteRenderer.flipX = !mySpriteRenderer.flipX;

        movementSpeed = -pastMovementSpeed;
        switchDir = false;
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            uiScript.lives--;
            player.GetComponent<Transform>().position = new Vector3 (-22.98f, 1.05f, 0f);
        }
    }
}
