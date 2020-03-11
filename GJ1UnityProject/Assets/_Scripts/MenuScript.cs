using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject instructions;
    // Start is called before the first frame update
    void Start()
    {
        titleMenu();
    }

    public void titleMenu()
    {
        titleScreen.SetActive(true);
        instructions.SetActive(false);
    }

    public void instructionsMenu()
    {
        titleScreen.SetActive(false);
        instructions.SetActive(true);
    }
}
