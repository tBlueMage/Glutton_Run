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
    public GameObject itemspawn;
    public PlayerRun playerRun;

    private int lane;
    public int bopo;
    private float wallOffset = 0;
    private int objectProbability;
    // Start is called before the first frame update
 

    void Start()
    {

        lane = Random.Range(1, 4);
        if (lane == 1)
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

    void SpawnObjectAt(string name)
    {

  objectProbability = Random.Range(0, 100);
        Debug.Log(bopo);
        if (bopo <= 500)
        {
            if (objectProbability <= 5)
            {
                Vector3 position = transform.Find(name).position;
                Instantiate(itemspawn, position, Quaternion.identity);
            }
            if (objectProbability > 5 && objectProbability <= 25)
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
            if (objectProbability > 50 && objectProbability <= 76)
            {
                Vector3 position = transform.Find(name).position;
                position.y += .25f;
                Instantiate(iceCream, position, Quaternion.identity);
            }
            if (objectProbability > 76 && objectProbability <= 82)
            {
                Vector3 position = transform.Find(name).position;
                position.y += .25f;
                Instantiate(musclePowder, position, Quaternion.identity);
            }
            if (objectProbability > 82 && objectProbability <= 100)
            {
                Vector3 position = transform.Find(name).position;
                position.y += .25f;
                Instantiate(apple, position, Quaternion.identity);
            }
        }


        if (bopo >= 500)
        {
            if (objectProbability <= 100)
            {
                Vector3 position = transform.Find(name).position;
                Instantiate(itemspawn, position, Quaternion.identity);
            }
            /*
                if (objectProbability > 5 && objectProbability <= 25)
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
            if (objectProbability > 50 && objectProbability <= 76)
            {
                Vector3 position = transform.Find(name).position;
                position.y += .25f;
                Instantiate(iceCream, position, Quaternion.identity);
            }
            if (objectProbability > 76 && objectProbability <= 82)
            {
                Vector3 position = transform.Find(name).position;
                position.y += .25f;
                Instantiate(musclePowder, position, Quaternion.identity);
            }
            if (objectProbability > 82 && objectProbability <= 100)
            {
                Vector3 position = transform.Find(name).position;
                position.y += .25f;
                Instantiate(apple, position, Quaternion.identity);
            }
            */
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


}






