using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    private Rigidbody rb;
    public int speed;
    public int score;
    public int fat;
    public float fart;
    public bool fartReady = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
         

        fat += (speed * 1);

        if (fart < 1)
        {
            fart += .001f;
        }
        else
        {
            fartReady = true;
        }

        Vector3 movement = new Vector3(0, 0, 1);

        transform.position += (movement * speed);

        score += speed;
    }
}
