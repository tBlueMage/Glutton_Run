using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FartMeterScript : MonoBehaviour
{
    public PlayerRun player;
    public Slider slider; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float currSize = player.fart;

        slider.value = currSize;
    }
}
