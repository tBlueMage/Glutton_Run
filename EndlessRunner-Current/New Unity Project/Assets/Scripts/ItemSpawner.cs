using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    private int objectProbability;
    public GameObject apple;
    public GameObject musclePowder;
    public GameObject iceCream;
    public int difficulty;

    private int item;
    // Start is called before the first frame update
    void Start()
    {
        calcDifficulty();

        if (difficulty == 1)
        {

            SpawnObjectAt("item1");


            SpawnObjectAt("item2");


            SpawnObjectAt("item3");
            SpawnObjectAt("item4");
            SpawnObjectAt("item5");
        }



        if (difficulty == 2)
        {

            SpawnObjectAt2("item1");
            SpawnObjectAt2("item2");
            SpawnObjectAt2("item3");
            SpawnObjectAt2("item4");
            SpawnObjectAt2("item5");
        }

        if (difficulty == 3)
        {

            SpawnObjectAt3("item1");
            SpawnObjectAt3("item2");
            SpawnObjectAt3("item3");
            SpawnObjectAt3("item4");
            SpawnObjectAt3("item5");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObjectAt(string name)
    {
        objectProbability = Random.Range(0, 100);

        if (objectProbability > 1 && objectProbability <= 75)
        {

            Vector3 position = transform.Find(name).position;
            position.y += .25f;
            Instantiate(iceCream, position, Quaternion.identity);
        }
        if (objectProbability > 99 && objectProbability <= 100)
        {
            Vector3 position = transform.Find(name).position;
            position.y += .25f;
            Instantiate(musclePowder, position, Quaternion.identity);
        }
        if (objectProbability > 75 && objectProbability <= 99)
        {
            Vector3 position = transform.Find(name).position;
            position.y += .25f;
            Instantiate(apple, position, Quaternion.identity);
        }

    }

    private void SpawnObjectAt2(string name)
    {
        objectProbability = Random.Range(0, 100);
        
        if (objectProbability > 1 && objectProbability <= 60)
        {

            Vector3 position = transform.Find(name).position;
            position.y += .25f;
            Instantiate(iceCream, position, Quaternion.identity);
        }
        
        if (objectProbability> 99 && objectProbability <= 100)
        {
            Vector3 position = transform.Find(name).position;
            position.y += .25f;
            Instantiate(musclePowder, position, Quaternion.identity);
        }
        
        if (objectProbability > 60 && objectProbability <= 99)
        {
            Vector3 position = transform.Find(name).position;
            position.y += .25f;
            Instantiate(apple, position, Quaternion.identity);
        }
       
    }
    private void SpawnObjectAt3(string name)
    {
        
        objectProbability = Random.Range(0, 100);

        if (objectProbability > 1 && objectProbability <= 60)
        {

            Vector3 position = transform.Find(name).position;
            position.y += .25f;
            Instantiate(iceCream, position, Quaternion.identity);
        }
        
        if (objectProbability> 99 && objectProbability <= 100)
        {
            Vector3 position = transform.Find(name).position;
            position.y += .25f;
            Instantiate(musclePowder, position, Quaternion.identity);
        }
        
        if (objectProbability > 60 && objectProbability <= 99)
        {
            Vector3 position = transform.Find(name).position;
            position.y += .25f;
            Instantiate(apple, position, Quaternion.identity);
        }
        
    }
    private void calcDifficulty()
    {
        GameObject player = GameObject.Find("Player");
        PlayerRun playerRun = player.GetComponent<PlayerRun>();

        if (playerRun.score >= 10000&& playerRun.score <= 20000)
        {
            difficulty = 2;
            Debug.Log(playerRun.score);
        }
        if (playerRun.score >= 20000)
        {
            difficulty = 3;
            Debug.Log(playerRun.score);
        }
    }

}
