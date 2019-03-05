using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public GameObject streetLight;
    public GameObject building;
    private float rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnStreetLightAt("streetLight RM");
        SpawnStreetLightAt("streetLight LM");
        SpawnBuildingAt("Building L");
        SpawnBuildingAt("Building R");
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
