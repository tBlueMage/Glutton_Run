using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public GameObject prefabChunk;
    public GameObject player;
    public PlayerRun playerRun;
    public Transform playerTransform;
    public Text scoreText;
    public Text fartText;
    public GameObject indicator;
    private int colorCountdown = 30;


    List<GameObject> chunks = new List<GameObject>();

    void Start()
    {
        
    }

    private void Update()
    {
        if(chunks.Count > 0)
        {
            if(playerTransform.position.z-chunks[0].transform.position.z > 60)
            {
                Destroy(chunks[0]);
                chunks.RemoveAt(0);
            }
        }

        while(chunks.Count < 5)
        {
            Vector3 position = Vector3.zero;

            if(chunks.Count > 0)
            {
                position = chunks[chunks.Count - 1].transform.Find("Connector").position;
            }

            GameObject obj = Instantiate(prefabChunk, position, Quaternion.identity);
            chunks.Add(obj);
        }

        setScoreText();

        if(playerRun.fartReady)
        {
            if (colorCountdown < 0)
            {
                float randoR = Random.Range(0.0f, 1.0f);
                float randoG = Random.Range(0.0f, 1.0f);
                float randoB = Random.Range(0.0f, 1.0f);

                Color randoColor = new Color(randoR, randoG, randoB);

                fartText.color = randoColor;

                colorCountdown = 30;
            }
            else
            {
                colorCountdown--;
            }
            fartText.text = "Fart Ready";
        }
        else
        {
            fartText.text = "";
        }
  
    }

    void setScoreText()
    {
        int score = player.GetComponent<PlayerRun>().score;
        scoreText.text = "Distance: " + score;
    }

}
