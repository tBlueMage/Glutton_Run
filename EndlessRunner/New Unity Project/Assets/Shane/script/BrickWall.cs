﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickWall : MonoBehaviour
{
    public GameObject brickWall;

    void Start()
    {



        SpawnWallAt("spawn16");
        SpawnWallAt("spawn17");
        SpawnWallAt("spawn18");


    }

    private void SpawnWallAt(string name)
    {
        if (Random.Range(0, 600) < 50)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(brickWall, position, Quaternion.identity);
        }
    }
   
}