using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftSpriteCurse : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    public UIScript canvasObj;

    void Update()
    {
        
        if (canvasObj.level == 1)
        {
            myAnimationController.SetBool("isLevel1", true);
        }
        if (canvasObj.level == 2)
        {
            myAnimationController.SetBool("isLevel1", false);

            myAnimationController.SetBool("isLevel2", true);
        }
        if (canvasObj.level == 3)
        {
            myAnimationController.SetBool("isLevel2", false);

            myAnimationController.SetBool("isLevel3", true);
        }
    }
}
