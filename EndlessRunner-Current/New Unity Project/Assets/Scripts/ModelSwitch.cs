using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSwitch : MonoBehaviour
{
    public GameObject strongRunning;
    public GameObject fatRunning;
    public GameObject skinnyRunning;
    public PlayerRun playerScript;

    public static int modelNumber;

    // Start is called before the first frame update
    void Start()
    {
        modelNumber = 1;
        strongRunning.SetActive(false);
        skinnyRunning.SetActive(false);
    }

    void ModelChange()
    {
        if (PlayerRun.fat >= 0 && PlayerRun.fat <= 600)
        {
            fatRunning.SetActive(false);
            skinnyRunning.SetActive(false);
            strongRunning.SetActive(true);
            modelNumber = 2;
            playerScript.speed = 9;
            // print("Model 2 : Muscle");
        }
        else if (PlayerRun.fat > 600)
        {
            strongRunning.SetActive(false);
            fatRunning.SetActive(false);
            skinnyRunning.SetActive(true);
            modelNumber = 3;
            playerScript.speed = 12;
           // print("Model 3 : Lean");
        }
        else if (PlayerRun.fat < 0)
        {
            skinnyRunning.SetActive(false);
            strongRunning.SetActive(false);
            fatRunning.SetActive(true);
            modelNumber = 1;
            playerScript.speed = 5;
           // print("Model 1 : Fat");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            PlayerRun.fat -= 500;

        }

        if (Input.GetButtonDown("Fire2"))
        {
            PlayerRun.fat += 500;
        }

        print(PlayerRun.fat);

        ModelChange();
    }
}
