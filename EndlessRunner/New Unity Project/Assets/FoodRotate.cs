using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodRotate : MonoBehaviour
{
    public GameObject FoodPrefab;
    private GameObject test;

    public int movementStage = 0;
    public float timer;
    public float timerTarget;
    public float moveHorizontal;
    public float moveVertical;
    public float speed;
    public float degreesPerSecond = 15.0f;
    public float amplitude = 0.5f;
    public float frequency = 1f;

    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    private Rigidbody rb;

    void Start()
      
    {
        timer = 0;
        rb = GetComponent<Rigidbody>();
        posOffset = transform.position;

    }

    void Awake()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

    }

    void Update()
    {
        timer += Time.deltaTime;

        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        transform.Rotate(Vector3.up, speed * Time.deltaTime);

        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;


    }
}

