using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Character character;

    public GameObject healthColour;
    public GameObject healthBar;

    void Start()
    {
        
        healthColour.GetComponent<Image>().color = new Color32(74, 227, 14, 255);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealth();
    }

    void UpdateHealth()
    {
        healthBar.GetComponent<Slider>().value = character.health;
        //miniHealthBar.GetComponent<Slider>().value = health;

        if (character.health < 80 && character.health > 60)
            healthColour.GetComponent<Image>().color = new Color32(167, 227, 16, 255);

        if (character.health < 60 && character.health > 40)
            healthColour.GetComponent<Image>().color = new Color32(227, 176, 9, 255);

        if (character.health < 40 && character.health > 20)
            healthColour.GetComponent<Image>().color = new Color32(240, 86, 48, 255);

        if (character.health < 20)
            healthColour.GetComponent<Image>().color = new Color32(204, 40, 0, 255);
    }
}
