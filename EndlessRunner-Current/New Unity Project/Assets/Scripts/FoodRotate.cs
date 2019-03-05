using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodRotate : MonoBehaviour
{
    public float rotationSpeed;
    public float amplitude = 0.5f;
    public float frequency = 1f;

    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    private Rigidbody rb;

    void Start()
      
    {
        rb = GetComponent<Rigidbody>();
        posOffset = transform.position;

    }

    void Update()
    {
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }
}

