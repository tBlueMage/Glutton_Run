using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorScript : MonoBehaviour
{

    public PlayerScript player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int finalFat = 30+(player.fat/25);
        // 574, 268, 0 is the middle of the screen
        Vector3 movement = new Vector3(524+finalFat, 456, 0);

        transform.position = (movement);
    }
}
