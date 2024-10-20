using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCollisionNotifier : MonoBehaviour
{
    // public delegate void collision(GameObject collisionObject);
    // public event collision onAllCollisions;
    public delegate void collision();
    public event collision onSpidersGroup1Collision;
    public event collision onSpidersGroup2Collision;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "spiders_group_1":
                Debug.Log("collision detected with spiders_group_1");
                onSpidersGroup1Collision();
                break;
            case "spiders_group_2":
                Debug.Log("collision detected with spiders_group_2");
                onSpidersGroup2Collision();
                break;
        }
    }
}
