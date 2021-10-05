using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour
{

    public GameObject mainCamera;
    public GameObject signCamera;

    public GameObject signText;
    public GameObject closeText;

    public GameObject player;

    public bool bySign;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bySign)
        {
            if (Input.GetKey(KeyCode.E))
            {
                signText.SetActive(false);
                closeText.SetActive(true);

                signCamera.SetActive(true);
                mainCamera.SetActive(false);

                player.SetActive(false);

                
            }

            if (Input.GetKey(KeyCode.X))
            {
                signText.SetActive(true);
                closeText.SetActive(false);

                signCamera.SetActive(false);
                mainCamera.SetActive(true);

                player.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        signText.SetActive(true);
        bySign = true;
        
    }

    private void OnTriggerExit(Collider other)
    {
        bySign = false;
        signText.SetActive(false);
        signCamera.SetActive(false);
        mainCamera.SetActive(true);
    }
}
