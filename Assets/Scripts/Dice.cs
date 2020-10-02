using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    private int[] numbers = new int[] { 1,2,3,4,5,6 };
    eDiceType diceType;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    { 
        Roll();
    }

    private void Roll()
    { 
        System.Random result = new System.Random();
        Debug.Log(result.Next(1,7));
        Game.Instance.DiceResult();
    }
}
