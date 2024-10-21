using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Group1SpidersMoveTo : MonoBehaviour
{
    private static int spiders_counter = 0;
    public GameObject targetEgg;
    public float force = 15.0f;
    public GameObject referenceObjectOnGroup1Collision;
    public GameObject referenceObjectOnGroup2Collision;
    public NewCollisionNotifier collisionNotifier;
    // Start is called before the first frame update
    void Start()
    {
        collisionNotifier.onSpidersGroup1Collision += moveToReferenceOnGroup1Object;
        collisionNotifier.onSpidersGroup2Collision += moveToReferenceOnGroup2Object;
        collisionNotifier.onEggsCollision += teletransporToTargetEgg;
        
        // Por defecto el objeto de referencia al chocar con el grupo 1 es el primer huevo del grupo 2
        if (referenceObjectOnGroup1Collision == null)
        {
            referenceObjectOnGroup1Collision = GameObject.FindGameObjectsWithTag("eggs_group_2")[0];
        }

        // Por defecto el objeto de referencia al chocar con el grupo 2 es el primer huevo del grupo 1
        if (referenceObjectOnGroup2Collision == null)
        {
            referenceObjectOnGroup2Collision = GameObject.FindGameObjectsWithTag("eggs_group_1")[0];
        }

        // Por defecto el objeto de referencia al chocar con el huevo de tipo 1 es el primer huevo del grupo 1
        if (targetEgg == null)
        {
            targetEgg = GameObject.FindGameObjectsWithTag("eggs_group_1")[0];
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void moveToReferenceOnGroup1Object()
    {
        GetComponent<Rigidbody>().AddForce((referenceObjectOnGroup1Collision.transform.position - transform.position).normalized * force, ForceMode.Impulse);
    }

    void moveToReferenceOnGroup2Object()
    {
        GetComponent<Rigidbody>().AddForce((referenceObjectOnGroup2Collision.transform.position - transform.position).normalized * force, ForceMode.Impulse);
    }

    void teletransporToTargetEgg()
    {
        if(spiders_counter >= GameObject.FindGameObjectsWithTag("spiders_group_1").Length)
        {
            spiders_counter = 0;
        }

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        transform.position = targetEgg.transform.position + new Vector3(0.0f + (Group1SpidersMoveTo.spiders_counter * 5.5f), 0.0f, -2.5f);
        Group1SpidersMoveTo.spiders_counter++;

        rb.isKinematic = false;

        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
