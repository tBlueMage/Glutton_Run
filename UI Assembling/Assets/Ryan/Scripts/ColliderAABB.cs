﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderAABB : MonoBehaviour
{

    public Vector3 halfSize;

    Vector3 min = Vector3.zero;
    Vector3 max = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        CalcEdges();
    }

    void CalcEdges()
    {
        min = transform.position - halfSize;
        max = transform.position + halfSize;
    }

    public bool CheckOverlap(ColliderAABB other)
    {
        if (min.x > other.max.x) return false;
        if (max.x < other.min.x) return false;

        if (min.y > other.max.y) return false;
        if (max.y < other.min.y) return false;

        if (min.z > other.max.z) return false;
        if (max.z < other.min.z) return false;

        return true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
