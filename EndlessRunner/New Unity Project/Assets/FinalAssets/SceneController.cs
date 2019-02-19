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
        scoreText.text = "Distance: " + playerScript.score;

        if(playerScript.fartReady)
        {
            if(colorCountDown < 0)
            {
                float randoR = Random.Range(0.0f, 1.0f);
                float randoG = Random.Range(0.0f, 1.0f);
                float randoB = Random.Range(0.0f, 1.0f);

                Color randoColor = new Color(randoR, randoG, randoB);

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
