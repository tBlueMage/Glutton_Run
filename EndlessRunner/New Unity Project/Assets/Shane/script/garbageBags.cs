using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garbageBags : MonoBehaviour
{
    public GameObject garbage;

    void Start()
    {



        SpawnWallAt("spawn13");
        SpawnWallAt("spawn14");
        SpawnWallAt("spawn15");


    }

    private void SpawnWallAt(string name)
    {
        if (Random.Range(0, 1200) < 50)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(garbage, position, Quaternion.identity);
        }
    }


}