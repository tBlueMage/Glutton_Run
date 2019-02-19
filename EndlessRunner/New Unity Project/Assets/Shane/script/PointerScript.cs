using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerScript : MonoBehaviour
{

    public PlayerRun player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int finalFat = 30 + (PlayerRun.fat / 25);
        // 574, 268, 0 is the middle of the screen
        Vector3 movement = new Vector3(550 + finalFat, 485, 0);

        transform.position = (movement);
    }
}
