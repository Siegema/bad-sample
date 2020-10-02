using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : Singleton<Game>
{
    public List<Action> actions = new List<Action>();
    public List<GameObject> players = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DiceResult()
    {
        Debug.Log("Here");
    }
}
