using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    public GameObject collidingMesh;
    private float counter = 6f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;

        if(counter <= 0)
        {
            Destroy(gameObject);
        }
        /*
        Screw this part in particular.
        if(playerScript.position - transform.position.z > 14)
        {
            Destroy(gameObject);
            print("isRunning");
        }
        */
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            if(tag == "iceCream")
            {
                FindObjectOfType<AudioManager>().Play("eating");
                Destroy(gameObject);
                PlayerRun.fat -= 50;
            }
            if(tag == "apple")
            {
                FindObjectOfType<AudioManager>().Play("eating");
                Destroy(gameObject);
                PlayerRun.fat += 20;
            }
            if(tag == "brickWall")
            {
                GameObject player = GameObject.Find("Player");
                PlayerRun playerRun = player.GetComponent<PlayerRun>();
                playImpactSound();
                playerRun.exponentialSpeed *= .5f;
                Destroy(gameObject);
            }
            if (tag == "steelWall")
            {
                GameObject player = GameObject.Find("Player");
                PlayerRun playerRun = player.GetComponent<PlayerRun>();
                playImpactSound();
                playerRun.exponentialSpeed = 0;
                Destroy(gameObject);
            }
            if (tag == "garbageBags")
            {
                GameObject player = GameObject.Find("Player");
                PlayerRun playerRun = player.GetComponent<PlayerRun>();
                playImpactSound();
                playerRun.exponentialSpeed = 0;
                Destroy(gameObject);
            }
            if (tag == "musclePowder")
            {
                GameObject player = GameObject.Find("Player");
                FindObjectOfType<AudioManager>().Play("eating");
                if (PlayerRun.fat > 300)
                {
                    PlayerRun.fat -= 800;
                    if(PlayerRun.fat < 300)
                    {
                        PlayerRun.fat = 300;
                    }
                }
                if (PlayerRun.fat < 300)
                {
                    PlayerRun.fat += 800;
                    if (PlayerRun.fat > 300)
                    {
                        PlayerRun.fat = 300;
                    }
                }
                Destroy(gameObject);
            }
        }
    }

    private void playImpactSound()
    {
        if (ModelSwitch.modelNumber == 1)
        {
            FindObjectOfType<AudioManager>().Play("fatHurt2");
        }
        if (ModelSwitch.modelNumber == 2)
        {
            FindObjectOfType<AudioManager>().Play("strongHurt3");
        }
        if (ModelSwitch.modelNumber == 3)
        {
            FindObjectOfType<AudioManager>().Play("skinnyHurt3");
        }
    }
}
