using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    
    public int health;
    public int experience;


    void Start()
    {
        health = 100;
        experience = 0;
    }

    void Update()
    {
       if (health <= 0)
       {
            health = 0;
       }

        if (health >= 100)
        {
            health = 100;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    

}

