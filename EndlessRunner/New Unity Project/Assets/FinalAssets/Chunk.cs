using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public GameObject prefabWall;
    // Start is called before the first frame update
    void Start()
    {
        ColliderAABB collider = GetComponent<ColliderAABB>();

        /*
        CollisionManager.walls.Add(collider);


        SpawnWallAt("Spawn1");
        SpawnWallAt("Spawn2");
        SpawnWallAt("Spawn3");
        */
    }

    private void SpawnWallAt(string name)
    {
        if(Random.Range(0, 100) < 50)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(prefabWall, position, Quaternion.identity);
        }
    }
}
