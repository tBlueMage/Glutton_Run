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

    public int difficulty;

    private int lane;
    private float wallOffset = 0;
    private int objectProbability;
    // Start is called before the first frame update


    void Start()
    {
        calcDifficulty();

        if (difficulty == 1)
        {
            lane = Random.Range(1, 4);
            if (lane == 1)
            {
                D1SpawnObjectAt("spawn1");
            }

            else if (lane == 2)
            {
                D1SpawnObjectAt("spawn2");
            }

            else if (lane == 3)
            {
                D1SpawnObjectAt("spawn3");
            }
        }
        if (difficulty == 2)
        {
            lane = Random.Range(1, 4);
            if (lane == 1)
            {
                D2SpawnObjectAt("spawn1");
            }

            else if (lane == 3)
            {
                D2SpawnObjectAt("spawn2");
            }

            else if (lane == 3)
            {
                D2SpawnObjectAt("spawn3");
            }
        }
        if (difficulty == 3)
        {
            lane = Random.Range(1, 4);
            if (lane == 1)
            {
                D3SpawnObjectAt("spawn1");
            }

            else if (lane == 2)
            {
                D3SpawnObjectAt("spawn2");
            }

            else if (lane == 3)
            {
                D3SpawnObjectAt("spawn3");
            }
        }

        SpawnStreetLightAt("streetLight RM");
        SpawnStreetLightAt("streetLight LM");
        SpawnBuildingAt("Building L");
        SpawnBuildingAt("Building R");
    }


    void D1SpawnObjectAt(string name)
    {
        objectProbability = Random.Range(0, 100);



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

    void D2SpawnObjectAt(string name)
    {
        objectProbability = Random.Range(0, 100);



        if (objectProbability <= 10)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(itemspawn, position, Quaternion.identity);
        }

        if (objectProbability > 10 && objectProbability <= 30)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(brickWall, position, Quaternion.identity);
        }
        if (objectProbability > 30 && objectProbability <= 50)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(steelWall, position, Quaternion.identity);
        }
        if (objectProbability > 50 && objectProbability <= 60)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(garbageBags, position, Quaternion.identity);
        }
        if (objectProbability > 60 && objectProbability <= 80)
        {
            Vector3 position = transform.Find(name).position;
            position.y += .25f;
            Instantiate(iceCream, position, Quaternion.identity);
        }
        if (objectProbability > 80 && objectProbability <= 95)
        {
            Vector3 position = transform.Find(name).position;
            position.y += .25f;
            Instantiate(musclePowder, position, Quaternion.identity);
        }
        if (objectProbability > 95 && objectProbability <= 100)
        {
            Vector3 position = transform.Find(name).position;
            position.y += .25f;
            Instantiate(apple, position, Quaternion.identity);
        }


    }


    void D3SpawnObjectAt(string name)
    {
        objectProbability = Random.Range(0, 100);



        if (objectProbability <= 10)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(itemspawn, position, Quaternion.identity);
        }

        if (objectProbability > 10 && objectProbability <= 35)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(brickWall, position, Quaternion.identity);
        }
        if (objectProbability > 35 && objectProbability <= 60)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(steelWall, position, Quaternion.identity);
        }
        if (objectProbability > 60 && objectProbability <= 85)
        {
            Vector3 position = transform.Find(name).position;
            Instantiate(garbageBags, position, Quaternion.identity);
        }
        if (objectProbability > 85 && objectProbability <= 90)
        {
            Vector3 position = transform.Find(name).position;
            position.y += .25f;
            Instantiate(iceCream, position, Quaternion.identity);
        }
        if (objectProbability > 90 && objectProbability <= 95)
        {
            Vector3 position = transform.Find(name).position;
            position.y += .25f;
            Instantiate(musclePowder, position, Quaternion.identity);
        }
        if (objectProbability > 95 && objectProbability <= 100)
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

    private void calcDifficulty()
    {
        GameObject player = GameObject.Find("Player");
        PlayerRun playerRun = player.GetComponent<PlayerRun>();

        if ((playerRun.score / 100) >= 250 && (playerRun.score / 100) <= 500)
        {
            difficulty = 2;
        }

        if ((playerRun.score / 100) > 500)
        {
            difficulty = 3;
        }

        Debug.Log(difficulty);
    }

}






