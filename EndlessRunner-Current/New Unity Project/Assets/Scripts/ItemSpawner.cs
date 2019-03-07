using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    private int objectProbability;
    public GameObject apple;
    public GameObject musclePowder;
    public GameObject iceCream;

    private int item;
    // Start is called before the first frame update
    void Start()
    {
            SpawnObjectAt("item1");
            SpawnObjectAt("item2");
            SpawnObjectAt("item3");
            SpawnObjectAt("item4");
            SpawnObjectAt("item5");
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
}
