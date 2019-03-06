using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverToTitle : MonoBehaviour
{
    private int cdTimer = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cdTimer--;
        
        if(cdTimer<=0)
        {
            SceneManager.LoadScene("TitleScreen");
        }
    }
}
