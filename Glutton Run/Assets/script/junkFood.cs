using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class junkFood : MonoBehaviour
{
    public GameObject Icecream;

    void Start()
    {



    SpawnWallAt("spawn4");
    SpawnWallAt("spawn5");
    SpawnWallAt("spawn6");


}

private void SpawnWallAt(string name)
{
    if (Random.Range(0, 200) < 50)
    {
        Vector3 position = transform.Find(name).position;
        Instantiate(Icecream, position, Quaternion.identity);
    }
}
}

