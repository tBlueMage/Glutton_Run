using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickWall : MonoBehaviour
{
    public GameObject brickWall;

    void Start()
    {



        SpawnWallAt("spawn10");
        SpawnWallAt("spawn11");
        SpawnWallAt("spawn12");


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