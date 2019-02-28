using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointerScript : MonoBehaviour
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
        float fatNorm = (PlayerRun.fat - (-900f)) / 2400f;
        //float finalFat = 30f + (PlayerRun.fat / 25);
        // 574, 268, 0 is the middle of the screen
        slider.value = Mathf.Clamp(fatNorm, 0 ,1);
    }
}
