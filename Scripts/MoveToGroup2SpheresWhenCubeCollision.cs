using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToGroup2SpheresWhenCubeCollision : MonoBehaviour
{
    public float force = 10.0f;
    public CollisionNotifier collisionNotifier;
    private GameObject[] spheres;
    // Start is called before the first frame update
    void Start()
    {
        collisionNotifier.onCubeCollision += moveToGroup2Spheres;
        spheres = GameObject.FindGameObjectsWithTag("spheres_group_2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void moveToGroup2Spheres()
    {
        // Get the the average position of the two group 2 spheres
        Vector3 averagePosition = new Vector3(0.0f, 0.0f, 0.0f);
        foreach (GameObject sphere in spheres)
        {
            averagePosition += sphere.transform.position;
        }
        averagePosition /= spheres.Length;
        GetComponent<Rigidbody>().AddForce((averagePosition - transform.position).normalized * force, ForceMode.Impulse);
    }
}
