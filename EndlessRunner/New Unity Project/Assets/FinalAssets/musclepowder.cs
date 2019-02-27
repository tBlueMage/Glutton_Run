using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musclepowder : MonoBehaviour
{
    public GameObject Icecream;

    void Start()
    {



        SpawnWallAt("spawn7");
        SpawnWallAt("spawn8");
        SpawnWallAt("spawn9");


    }

    private void SpawnWallAt(string name)
    {
        if (Random.Range(0, 800) < 50)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(Icecream, position, Quaternion.identity);
        }
    }

}