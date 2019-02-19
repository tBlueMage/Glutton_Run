using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodFoodDestroyed : MonoBehaviour
{
    private PlayerRun playerScript;
    private bool isDead = false;
    private float counter = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;

        if (counter <= 0)
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
            Debug.Log("hit");
            isDead = true;
            Destroy(gameObject);
            PlayerRun.fat -= 100;
        }
    }
}