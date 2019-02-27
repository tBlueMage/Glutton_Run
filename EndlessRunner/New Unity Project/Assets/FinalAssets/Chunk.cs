using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public GameObject apple;
    public GameObject brickWall;
    public GameObject garbageBags;
    public GameObject iceCream;
    public GameObject musclePowder;
    public GameObject steelWall;
    private int lane;
    private int objectProbability;

    // Start is called before the first frame update
    void Start()
    {
        lane = Random.Range(1, 3);

        if(lane == 1)
        {
            SpawnObjectAt("spawn1");
        }

        if (lane == 2)
        {
            SpawnObjectAt("spawn2");
        }

        if (lane == 3)
        {
            SpawnObjectAt("spawn3");
        }
    }

    private void SpawnObjectAt(string name)
    {
        objectProbability = Random.Range(0,100);
        if (objectProbability <= 25)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(brickWall, position, Quaternion.identity);
        }
        if (objectProbability > 25 && objectProbability <= 38)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(steelWall, position, Quaternion.identity);
        }
        if (objectProbability > 38 && objectProbability <= 50)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(garbageBags, position, Quaternion.identity);
        }
        if (objectProbability > 50 && objectProbability <= 70)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(iceCream, position, Quaternion.identity);
        }
        if (objectProbability > 70 && objectProbability <= 80)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(musclePowder, position, Quaternion.identity);
        }
        if (objectProbability > 80 && objectProbability <= 100)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(apple, position, Quaternion.identity);
        }

    }

}
