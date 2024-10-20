using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToCylinderWhenCubeCollision : MonoBehaviour
{
    public float force = 10.0f;
    public CollisionNotifier collisionNotifier;
    private GameObject cylinder;
    // Start is called before the first frame update
    void Start()
    {
        collisionNotifier.onCubeCollision += moveToCylinder;
        cylinder = GameObject.Find("Cylinder");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void moveToCylinder()
    {
        GetComponent<Rigidbody>().AddForce((cylinder.transform.position - transform.position).normalized * force, ForceMode.Impulse);
    }
}
