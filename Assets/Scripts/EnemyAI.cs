using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public bool left;
    public bool right;

    public Character player;
    public Character enemy;

    public GameObject respawnLocation;

    public float speed;

    void Start()
    {
        left = true;
        speed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (left)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (right)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.health -= 10;
            enemy.health -= 20;

            if (enemy.health <= 0)
            {
                enemy.gameObject.SetActive(false);
                enemy.transform.position = respawnLocation.transform.position;
                enemy.health = 100;
                enemy.gameObject.SetActive(true);

            }
        }
        else
        {
            if (left)
            {
                Debug.Log("triggered");
                left = false;
                right = true;
            }
            else if (right)
            {
                left = true;
                right = false;
            }
        }
        
    }
}
