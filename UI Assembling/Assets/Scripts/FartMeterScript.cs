using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FartMeterScript : MonoBehaviour
{
    public PlayerScript player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float currSize = player.fart;

        Vector3 size = new Vector3(currSize, 1, 1);

        transform.localScale = size;
        // 574, 268, 0 is the middle of the screen
        Vector3 movement = new Vector3(1009, 488, 0);

        transform.position = movement;
    }
}
