using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public GameObject streetLight;
    public GameObject building;
    public GameObject building2;
    public GameObject apple;
    public GameObject brickWall;
    public GameObject garbageBags;
    public GameObject iceCream;
    public GameObject musclePowder;
    public GameObject steelWall;
    private int lane;
    private float wallOffset = 0;
    private int objectProbability;

    // Start is called before the first frame update
    void Start()
    {
        lane = Random.Range(1, 4);
        if(lane == 1)
        {
            SpawnObjectAt("spawn1");
        }

        else if (lane == 2)
        {
            SpawnObjectAt("spawn2");
        }

        else if (lane == 3)
        {
            SpawnObjectAt("spawn3");
        }

        SpawnStreetLightAt("streetLight RM");
        SpawnStreetLightAt("streetLight LM");
        SpawnBuildingAt("Building L");
        SpawnBuildingAt("Building R");
        //SpawnBuilding2At("Building IF");
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
            position.y += .25f;
            Instantiate(iceCream, position, Quaternion.identity);
        }
        if (objectProbability > 70 && objectProbability <= 80)
        {
            Vector3 position = transform.Find(name).position;
            position.y += .25f;
            Instantiate(musclePowder, position, Quaternion.identity);
        }
        if (objectProbability > 80 && objectProbability <= 100)
        {
            Vector3 position = transform.Find(name).position;
            position.y += .25f;
            Instantiate(apple, position, Quaternion.identity);
        }

    }


    private void SpawnStreetLightAt(string name)
    {
        Vector3 position = transform.Find(name).position;

        /*
        if (name == "streetLight LF" || name == "streetLight LM" || name == "streetLight LB")
        {
            ;
        }
        */
        Instantiate(streetLight, position, (Quaternion.identity));
    }
    private void SpawnBuildingAt(string name)
    {
        Vector3 position = transform.Find(name).position;
        Instantiate(building, position, Quaternion.identity);
    }
    private void SpawnBuilding2At(string name)
    {
        Vector3 position = transform.Find(name).position;
        Instantiate(building, position, Quaternion.identity);
    }

}
