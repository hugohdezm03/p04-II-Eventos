using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Group2SpidersLookAt : MonoBehaviour
{
    public GameObject targetToLookAt;
    public NewCollisionNotifier collisionNotifier;
    // Start is called before the first frame update
    void Start()
    {
        collisionNotifier.onEggsCollision += lookAtTarget;
        if(targetToLookAt == null)
        {
            targetToLookAt = GameObject.FindWithTag("eggs_group_2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void lookAtTarget()
    {
        // Arañas físicas
        Vector3 targetPosition = targetToLookAt.transform.position - transform.position;
        GetComponent<Rigidbody>().MoveRotation(Quaternion.LookRotation(targetPosition, Vector3.up));
    }
}
