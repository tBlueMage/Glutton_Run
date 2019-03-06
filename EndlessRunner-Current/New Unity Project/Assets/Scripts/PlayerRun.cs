using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour
{

    public int speed;
    public float sideSpeed;
    public float exponentialSpeed;
    public Vector3 jump;
    public float jumpForce;
    public float shuffleMovement;
    private float pointOfTravel;
    private float travel;
    private float position;
    public float speedScale;
    private float attackRange = 3f;
    private bool isGrounded = true;
    private bool hasPressed = false;
    private bool fartPowerActive = false;
    public int fartPower;
    public int score = 0;
    public static int fat;
  
    public bool fartReady = false;
    public float fart;
    public ModelSwitch modelswitch;


    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        score += speed;
        Movement();
        FatCalculation();
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            fartPowerActive = false;
            //print("Collision");
        }
    }
    void Attack()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, attackRange))
        {
            Debug.Log(hit.transform.name);
        }
    }
    void Movement()
    {
        float moveVertical = Input.GetAxis("Vertical");
        if (isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity += Vector3.up * jumpForce;
                isGrounded = false;
            }
        }

        if (hasPressed == false)
        {
            if (Input.GetKeyDown("a") && pointOfTravel != -1)
            {
                pointOfTravel -= shuffleMovement;
            }
            if (Input.GetKeyDown("d") && pointOfTravel != 1)
            {
                pointOfTravel += shuffleMovement;
            }

            speedScale = pointOfTravel - transform.position.x;

            travel = (sideSpeed * speedScale);

            transform.position += new Vector3(travel, 0, 0);

            if (Input.GetKeyDown("f") && fartReady == true)
            {
                rb.velocity += Vector3.up * fartPower;
                rb.velocity += Vector3.forward * fartPower;
                fart = 0;
                fartPowerActive = true;
            }
            hasPressed = true;
        }
        if (!Input.GetKeyDown("a") && !Input.GetKeyDown("d") && !Input.GetKeyDown("f") && hasPressed == true)
        {
            hasPressed = false;
        }

        Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical);

        //rb.AddForce ((movement * speedZ));

        Vector3 pos = transform.position;

        pos.z += (speed + exponentialSpeed) * Time.deltaTime;
        transform.position = pos;
        exponentialSpeed += Time.deltaTime;

        if (exponentialSpeed >= 10)
        {
            exponentialSpeed = 10;
        }
    }
    void FatCalculation()
    {
        if(!fartPowerActive)
        {
            fat += (speed / 8);
        }

        if (fat > 1500)
        {
            fat = 1500;
        }

        if (fat < -900)
        {
            fat = -900;
        }
        if (fart < 1)
        {
            fart += .001f;
            fartReady = false;
        }
        else
        {
            fartReady = true;
        }
    }


}
