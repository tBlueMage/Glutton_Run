using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour
{

    public float speed;
    public Vector3 jump;
    public float jumpForce;
    public float shuffleMovement;
    private float attackRange = 3f;
    private bool isGrounded = true;
    private bool hasPressed = false;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");
        if (isGrounded)
        {
            if(Input.GetButtonDown("Jump"))
            {
                rb.velocity +=  Vector3.up * jumpForce;
                isGrounded = false;
            }
        }

        if (hasPressed == false)
        {
            if(Input.GetKeyDown("a"))
            {
                transform.position += new Vector3(-shuffleMovement, 0, 0);
            }
            if(Input.GetKeyDown("d"))
            {
                transform.position += new Vector3(shuffleMovement, 0, 0);
            }
            hasPressed = true;
        }
        if(!Input.GetKeyDown("a") && !Input.GetKeyDown("d") && hasPressed == true)
        {
            hasPressed = false;
        }

        Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical);

        //rb.AddForce ((movement * speedZ));

        Vector3 pos = transform.position;
        
        pos.z += speed*Time.deltaTime;
        transform.position = pos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            print("Collision");
        }
    }

    void Attack()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, attackRange))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
