using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunk : MonoBehaviour
{
    public GameObject prefabWall;
    // Start is called before the first frame update
    void Start()
    {



        SpawnWallAt("spawn1");
        SpawnWallAt("spawn2");
        SpawnWallAt("spawn3");
  
    }

    private void SpawnWallAt(string name)
    {
        if(Random.Range(0, 400) < 50)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(prefabWall, position, Quaternion.identity);
     
        }

       
    }

   
}

   

