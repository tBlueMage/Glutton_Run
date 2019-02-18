using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour
{

    public float speed = 10;
    public Vector3 jump;
    public float jumpForce = 2;
    private bool isGrounded = true;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(0, 9, true);

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      

        if (isGrounded)
        {
            if(Input.GetButtonDown("Jump"))
            {
                rb.velocity = Vector3.up * jumpForce;
            }
            if (Input.GetButtonDown("d"))
            {
                rb.velocity = Vector3.right * speed;
            }
            if (Input.GetButtonDown("a"))
            {
                rb.velocity = Vector3.left * speed;
            }

        }

        Vector3 pos = transform.position;
        pos.z += speed * Time.deltaTime;
        transform.position = pos;



    }


}
