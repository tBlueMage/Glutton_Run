using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{

    ColliderAABB player;
    GameObject p;
    static public List<ColliderAABB> walls = new List<ColliderAABB>();

    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.Find("Player");
        player = GameObject.Find("Player").GetComponent<ColliderAABB>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        DoCollisionDetection();
    }

    void DoCollisionDetection()
    {
        foreach(ColliderAABB wall in walls)
        {
            bool result = player.CheckOverlap(wall);
            
            //Trigger any Event after this...
        }
    }
}
