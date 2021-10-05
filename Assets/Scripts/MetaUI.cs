using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetaUI : MonoBehaviour
{
    //public GameObject canvas;

    public Player player;
    public Image img;
    public float timerMax = 2.0f;
    public bool inWater = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerStay(Collider other)
    {
        if (inWater)
        {
            Debug.Log("timer started");
            timerMax -= Time.deltaTime;

            if (timerMax <= 0.0f)
            {
                player.health -= 10;
                timerMax = 2.0f;
            }
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        inWater = true;
        StartCoroutine(FadeImage(false));
    }

    private void OnTriggerExit(Collider other)
    {
        inWater = false;
        StartCoroutine(FadeImage(true));
    }

    IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 0.5f; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                img.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
        // fade from transparent to opaque
        else
        { 
            img.color = new Color(1, 1, 1, 0.5f);

            
        }
    }
}
