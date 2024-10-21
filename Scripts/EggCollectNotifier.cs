using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCollectNotifier : MonoBehaviour
{
    public delegate void eggCollision(GameObject egg);

    public event eggCollision onEggCollision;
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
        if (collision.gameObject.tag == "eggs_group_1" ||
            collision.gameObject.tag == "eggs_group_2")
        {
            onEggCollision(collision.gameObject);
        }
    }
}
