using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    Text timerObj;
    Image heart1;
    Image heart2;
    Image heart3;
    int timer = 0;
    public int lives = 3;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    // Start is called before the first frame update
    void Start()
    {
        timerObj = GameObject.Find("Game Timer").GetComponent<Text>();
        heart1 = GameObject.Find("Heart1").GetComponent<Image>();
        heart2 = GameObject.Find("Heart2").GetComponent<Image>();
        heart3 = GameObject.Find("Heart3").GetComponent<Image>();
        StartCoroutine(timerMethod());
    }

    // Update is called once per frame
    void Update()
    {
        timerObj.text = "Game Timer: " + timer;
        if (lives == 3)
        {
            heart1.sprite = fullHeart;
            heart2.sprite = fullHeart;
            heart3.sprite = fullHeart;
        }
        if (lives == 2)
        {
            heart1.sprite = fullHeart;
            heart2.sprite = fullHeart;
            heart3.sprite = emptyHeart;
        }
        if (lives == 1)
        {
            heart1.sprite = fullHeart;
            heart2.sprite = emptyHeart;
            heart3.sprite = emptyHeart;
        }
        if (lives == 0)
        {
            heart1.sprite = emptyHeart;
            heart2.sprite = emptyHeart;
            heart3.sprite = emptyHeart;
            Application.Quit();
        }

    }

    IEnumerator timerMethod()
    {
        yield return new WaitForSeconds(1f);
        timer += 1;
        StartCoroutine(timerMethod());
    }
}
