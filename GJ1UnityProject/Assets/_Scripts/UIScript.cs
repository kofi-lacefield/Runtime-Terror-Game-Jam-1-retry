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
    public int level = 0;
    int timer = 120;
    public int lives = 3;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public GameObject Level0Menu;
    public GameObject levelGUI;

    //public hat hatScript;
    //public Pumpkin pumpkinScript;
    //public Candle candleScript;
    //public Bat batScript;
    public GameObject hat;
    public GameObject pumpkin;
    public GameObject candle;
    public GameObject bat;
    //public Vector3[] spawnLocations;
    Vector3[] spawnLocations = new Vector3[8];// {new Vector3(46f, -12f, 0f), new Vector3(46f, -1f, 0f), new Vector3(40f, 11f, 0f), new Vector3(22f, -21f, 0f), new Vector3(46f, -12f, 0f), new Vector3(17f, 21f, 0f),  new Vector3(54f, -21f, 0f), new Vector3(27f, -1f, 0f)};
    public float enemySpeed = 0.5f;
    bool win = false;
    bool lose = false;
    public GameObject winText;
    public GameObject loseText;
    GameObject[] uiImages;
    GameObject[] uiText;
    //bool set = false;
    bool newLvl = true;
    public int witchAmount = 0;
    public int pumpkinAmount = 0;
    public int candleAmount = 0;
    public int batAmount = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Level0Menu.SetActive(true);
        //levelGUI.SetActive(true);
        //winText.SetActive(true);
        timerObj = GameObject.Find("Game Timer").GetComponent<Text>();
        heart1 = GameObject.Find("Heart1").GetComponent<Image>();
        heart2 = GameObject.Find("Heart2").GetComponent<Image>();
        heart3 = GameObject.Find("Heart3").GetComponent<Image>();
        spawnLocations[0] = new Vector3(46f, -12f, 0f);
        spawnLocations[1] = new Vector3(46f, -1f, 0f);
        spawnLocations[2] = new Vector3(40f, 11f, 0f);
        spawnLocations[3] = new Vector3(22f, -21f, 0f);
        spawnLocations[4] = new Vector3(46f, -12f, 0f);
        spawnLocations[5] = new Vector3(17f, 21f, 0f);
        spawnLocations[6] = new Vector3(54f, -21f, 0f);
        spawnLocations[7] = new Vector3(27f, -1f, 0f);
        uiImages = GameObject.FindGameObjectsWithTag("UI_Image");
        uiText = GameObject.FindGameObjectsWithTag("UI_Text");
        for (int i = 0; i < uiImages.Length; i++)
        {
            GameObject temp = uiImages[i];
            if (temp.GetComponent<Image>().enabled)
            {
                temp.GetComponent<Image>().enabled = !enabled;
            }
        }
        for (int i = 0; i < uiText.Length; i++)
        {
            GameObject temp = uiText[i];
            if (temp.GetComponent<Text>().enabled)
            {
                temp.GetComponent<Text>().enabled = !enabled;
            }
        }
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
            loseGame();
        }
        if (level == 0)
        {
            if (newLvl)
            {
                StopCoroutine(timerMethod());
                enemySpeed = 0.5f;
                Level0Menu.SetActive(true);
                levelGUI.SetActive(true);
                if (win)
                {
                    winText.SetActive(true);
                } else {
                    winText.SetActive(false);
                }
                if (lose)
                {
                    loseText.SetActive(true);
                } else {
                    loseText.SetActive(false);
                }
                newLvl = false;
            }
        }
        if (level == 1)
        {
            if (newLvl)
            {
                enemySpeed = 0.5f;
                Level0Menu.SetActive(false);
                levelGUI.SetActive(true);
                for (int i = 0; i < uiImages.Length; i++)
                {
                    GameObject temp = uiImages[i];
                    if (!temp.GetComponent<Image>().enabled)
                    {
                        temp.GetComponent<Image>().enabled = enabled;
                    }
                }
                for (int i = 0; i < uiText.Length; i++)
                {
                    GameObject temp = uiText[i];
                    if (!temp.GetComponent<Text>().enabled)
                    {
                        temp.GetComponent<Text>().enabled = enabled;
                    }
                }
                newLvl = false;
            }
        }
        if (level == 2)
        {
            if (newLvl)
            {
                enemySpeed = 0.75f;
                Level0Menu.SetActive(false);
                levelGUI.SetActive(true);
                newLvl = false;
            }
        }
        if (level == 3)
        {
            if (newLvl)
            {
                enemySpeed = 1f;
                Level0Menu.SetActive(false);
                levelGUI.SetActive(true);
                newLvl = false;
            } 
        }
        if (timer <= 0)
        {
            loseGame();
        }
    }

    IEnumerator timerMethod()
    {
        yield return new WaitForSeconds(1f);
        timer -= 1;
        StartCoroutine(timerMethod());
    }

    public void changeLevel()
    {
        StopCoroutine(timerMethod());
        witchAmount = 0;
        pumpkinAmount = 0;
        candleAmount = 0;
        batAmount = 0;

        int hatLocation = (int) Random.Range(0, 8);
        int pumpkinLocation = (int) Random.Range(0, 8);
        while (hatLocation == pumpkinLocation)
        {
            pumpkinLocation = (int) Random.Range(0, 8);
        }
        int candleLocation = (int) Random.Range(0, 8);
        while (candleLocation == pumpkinLocation || candleLocation == hatLocation)
        {
            candleLocation = (int) Random.Range(0, 8);
        }
        int batLocation = (int) Random.Range(0, 8);
        while (batLocation == pumpkinLocation || batLocation == hatLocation || batLocation == candleLocation)
        {
            batLocation = (int) Random.Range(0, 8);
        }
        
        hat.GetComponent<Transform>().position = spawnLocations[hatLocation];
        pumpkin.GetComponent<Transform>().position = spawnLocations[pumpkinLocation];
        candle.GetComponent<Transform>().position = spawnLocations[candleLocation];
        bat.GetComponent<Transform>().position = spawnLocations[batLocation];

        hat.SetActive(true);
        pumpkin.SetActive(true);
        candle.SetActive(true);
        bat.SetActive(true);

        timer = 120;
        level++;
        newLvl = true;
        StartCoroutine(timerMethod());
    }

    public void loseGame()
    {
        StopCoroutine(timerMethod());
        newLvl = true;
        lose = true;
        level = 0;
        for (int i = 0; i < uiImages.Length; i++)
        {
            GameObject temp = uiImages[i];
            if (temp.GetComponent<Image>().enabled)
            {
                temp.GetComponent<Image>().enabled = !enabled;
            }
        }
        for (int i = 0; i < uiText.Length; i++)
        {
            GameObject temp = uiText[i];
            if (temp.GetComponent<Text>().enabled)
            {
                temp.GetComponent<Text>().enabled = !enabled;
            }
        }
    }

    public void winGame()
    {
        StopCoroutine(timerMethod());
        newLvl = true;
        win = true;
        level = 0;
        for (int i = 0; i < uiImages.Length; i++)
        {
            GameObject temp = uiImages[i];
            if (temp.GetComponent<Image>().enabled)
            {
                temp.GetComponent<Image>().enabled = !enabled;
            }
        }
        for (int i = 0; i < uiText.Length; i++)
        {
            GameObject temp = uiText[i];
            if (temp.GetComponent<Text>().enabled)
            {
                temp.GetComponent<Text>().enabled = !enabled;
            }
        }
    }
}
