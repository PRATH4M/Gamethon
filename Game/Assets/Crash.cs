using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{
    public LogicScript logic;
    public bool crashOccurred = false;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }


    public void OnCollisionEnter2D(Collision2D collision)
    { 
        crashOccurred = true;
        logic.gameover();
    }
}
