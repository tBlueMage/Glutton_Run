using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steelWall : MonoBehaviour
{
    public GameObject steelwall;

    void Start()
    {



        SpawnWallAt("spawn1");
        SpawnWallAt("spawn2");
        SpawnWallAt("spawn3");


    }

    private void SpawnWallAt(string name)
    {
        if (Random.Range(0, 800) < 50)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(steelwall, position, Quaternion.identity);
        }
    }
   
}
