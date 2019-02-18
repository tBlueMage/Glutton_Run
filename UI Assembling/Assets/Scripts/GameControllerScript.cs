using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public GameObject prefabChunk;
    public GameObject player;
    public Transform playerTransform;
    public Text scoreText;
    public GameObject indicator;


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

  
    }

    void setScoreText()
    {
        int score = player.GetComponent<PlayerScript>().score;
        scoreText.text = "Distance: " + score;
    }

}
