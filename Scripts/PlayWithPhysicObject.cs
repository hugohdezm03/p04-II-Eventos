using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWithPhysicObject : MonoBehaviour
{
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        if (moveHorizontal != 0 || moveVertical != 0)
        {
            Vector3 direction = new Vector3(moveHorizontal, 0.0f, moveVertical);
            GetComponent<Rigidbody>().AddForce(direction * speed, ForceMode.Force);
        }
    }
}
