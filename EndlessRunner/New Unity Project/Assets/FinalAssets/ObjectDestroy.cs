using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    public GameObject collidingMesh;
    private float counter = 10;
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
                Destroy(gameObject);
                PlayerRun.fat -= 100;
            }
            if(tag == "apple")
            {
                Destroy(gameObject);
                PlayerRun.fat += 30;
            }
            if(tag == "brickWall")
            {
                GameObject player = GameObject.Find("Player");
                PlayerRun playerRun = player.GetComponent<PlayerRun>();
                
                playerRun.exponentialSpeed *= .5f;
                Destroy(gameObject);
            }
            if (tag == "steelWall")
            {
                GameObject player = GameObject.Find("Player");
                PlayerRun playerRun = player.GetComponent<PlayerRun>();
                print("ye");
                playerRun.exponentialSpeed = 0;
                Destroy(gameObject);
            }
        }
    }
}
