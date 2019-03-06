using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public GameObject prefabChunk;
    public Transform player;
    public Text scoreText;
    public PlayerRun playerScript;
    private int colorCountDown = 30;
    public Text fartText;
    private int currColor = 1;

    List<GameObject> chunks = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(chunks.Count > 0)
        {
            if (player.position.z - chunks[0].transform.position.z > 14)
            {
                Destroy(chunks[0]);
                chunks.RemoveAt(0);
            }
        }

        while (chunks.Count < 5)
        {
            // spawn a new chunk
            Vector3 position = Vector3.zero;

            if(chunks.Count > 0)
            {
                position = chunks[chunks.Count - 1].transform.Find("Connector").position;
            }

            GameObject obj = Instantiate(prefabChunk, position, Quaternion.identity);
            chunks.Add(obj);

        }
        scoreText.text = "Distance: " + (int)Mathf.Round((playerScript.score)/100) + " feet";

        if(playerScript.fartReady)
        {
            if(colorCountDown < 0)
            {

                Color randoColor;

                
                currColor++;

                if(currColor > 3)
                {
                    currColor = 0;
                }

                if(currColor == 1)
                {
                    randoColor = new Color(0,1,1,1);
                } else if (currColor == 2)
                {
                    randoColor = new Color(1, 1, 1, 1);
                } else
                {
                    randoColor = new Color(1,0.92f,0.016f);
                }


                fartText.color = randoColor;

                colorCountDown = 30;
            }
            else
            {
                colorCountDown--;
            }
            fartText.text = "Fart Ready";
        }
        else
        {
            fartText.text = "";
        }
    }
}
