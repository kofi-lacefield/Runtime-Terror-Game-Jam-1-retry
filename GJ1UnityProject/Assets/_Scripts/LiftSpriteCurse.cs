using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftSpriteCurse : MonoBehaviour
{
    public Sprite NotCursed;
    public int numRequiredIngred = 1; // test amt = 1 (will change later)

    void Update()
    {
        
        if (IngredientText.ingredientAmount == numRequiredIngred)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = NotCursed;
        }
    }
}
