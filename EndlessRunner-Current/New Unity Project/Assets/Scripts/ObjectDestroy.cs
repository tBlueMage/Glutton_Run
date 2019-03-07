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
        GameObject player = GameObject.Find("Player");
        Transform playerPos = player.GetComponent<Transform>();

        if (playerPos.position.z - transform.position.z > 14)
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
            GameObject player = GameObject.Find("Player");
            PlayerRun playerRun = player.GetComponent<PlayerRun>();
            ModelSwitch modelSwitch = player.GetComponent<ModelSwitch>();
            if (tag == "iceCream")
            {
                FindObjectOfType<AudioManager>().Play("eating");
                Destroy(gameObject);
                playerRun.fart += .1f;
                PlayerRun.fat -= 200;
            }
            if(tag == "apple")
            {
                FindObjectOfType<AudioManager>().Play("eating");
                Destroy(gameObject);
                playerRun.fart += .1f;
                PlayerRun.fat += 40;
            }
            if(tag == "brickWall")
            {

                playImpactSound();
                if(ModelSwitch.modelNumber != 1)
                {
                    playerRun.exponentialSpeed *= .5f;
                }
                PlayerRun.fat -= 500;
                Destroy(gameObject);
            }
            if (tag == "steelWall")
            {

                playImpactSound();
                if (ModelSwitch.modelNumber != 1)
                {
                    playerRun.exponentialSpeed = 0f;
                }
                PlayerRun.fat -= 500;
                Destroy(gameObject);
            }
            if (tag == "garbageBags")
            {

                playImpactSound();
                if (ModelSwitch.modelNumber != 1)
                {
                    playerRun.exponentialSpeed = 0f;
                }
                PlayerRun.fat -= 500;
                Destroy(gameObject);
            }
            if (tag == "musclePowder")
            {
                playerRun.fart += .1f;
                FindObjectOfType<AudioManager>().Play("eating");
                if (PlayerRun.fat > 300)
                {
                    PlayerRun.fat -= 500;
                    if(PlayerRun.fat < 300)
                    {
                        PlayerRun.fat = 300;
                    }
                }
                if (PlayerRun.fat < 300)
                {
                    PlayerRun.fat += 500;
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
