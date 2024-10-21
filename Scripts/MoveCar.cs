using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public float speed = 25.0f;
    public float rotationSpeed = 100.0f;
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
            Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical);
            transform.Translate(movement * speed * Time.deltaTime, Space.Self);
            Vector3 rotation = new Vector3(0.0f, moveHorizontal, 0.0f);
            transform.Rotate(rotation * rotationSpeed * Time.deltaTime, Space.Self);
        }
    }
}
