using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSwitch : MonoBehaviour
{
    public GameObject strongRunning;
    public GameObject fatRunning;
    public GameObject skinnyRunning;

    private int modelNumber;

    // Start is called before the first frame update
    void Start()
    {
        modelNumber = 1;
        strongRunning.SetActive(false);
        skinnyRunning.SetActive(false);
    }

    void ModelChange()
    {
        if(modelNumber == 1)
        {
            fatRunning.SetActive(false);
            skinnyRunning.SetActive(true);
            modelNumber = 2;
        }
        else if(modelNumber == 2)
        {
            skinnyRunning.SetActive(false);
            strongRunning.SetActive(true);
            modelNumber = 3;
        }
        else if(modelNumber == 3)
        {
            strongRunning.SetActive(false);
            fatRunning.SetActive(true);
            modelNumber = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ModelChange();
            print("Working?");
        }
    }
}
