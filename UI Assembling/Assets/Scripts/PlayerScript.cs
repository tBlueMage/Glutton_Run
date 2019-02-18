using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    private Rigidbody rb;
    public int speed;
    public int score;
    public float fat;

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
         

        fat += (speed * .1f);

        Vector3 movement = new Vector3(0, 0, 1);

        transform.position += (movement * speed);

        score += speed;
    }
}
