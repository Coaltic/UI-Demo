using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public GameObject healthColour;
    //public GameObject miniHealthColour;
    public GameObject healthBar;
    //public GameObject miniHealthBar;

    void Start()
    {
        health = 100;
        healthColour.GetComponent<Image>().color = new Color32(74, 227, 14, 255);
    }

    void Update()
    {
        UpdateHealth();
    }

    void UpdateHealth()
    {
        healthBar.GetComponent<Slider>().value = health;
        //miniHealthBar.GetComponent<Slider>().value = health;

        if (health < 80 && health > 60)
            healthColour.GetComponent<Image>().color = new Color32(167, 227, 16, 255);

        if (health < 60 && health > 40)
            healthColour.GetComponent<Image>().color = new Color32(227, 176, 9, 255);

        if (health < 40 && health > 20)
            healthColour.GetComponent<Image>().color = new Color32(240, 86, 48, 255);

        if (health < 20)
            healthColour.GetComponent<Image>().color = new Color32(204, 40, 0, 255);
    }

    public void Heal()
    {
        health = health + 10;
        UpdateHealth();
    }

    public void Damage()
    {
        health = health - 10;
        UpdateHealth();
    }

}

