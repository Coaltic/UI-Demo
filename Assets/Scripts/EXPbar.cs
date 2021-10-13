using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EXPbar : MonoBehaviour
{
    public Character character;

    
    public GameObject experienceBar;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        experienceBar.GetComponent<Slider>().value = character.experience;
    }
}
