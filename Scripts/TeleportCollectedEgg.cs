using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCollectedEgg : MonoBehaviour
{
    public EggCollectNotifier eggCollectNotifier;
    // Start is called before the first frame update
    void Start()
    {
        eggCollectNotifier.onEggCollision += teleportEgg;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void teleportEgg(GameObject egg)
    {
        Rigidbody rb = egg.GetComponent<Rigidbody>();
        rb.isKinematic = true;

        float x = Random.Range(0.0f, 7.0f);
        float z = Random.Range(-5.0f, 5.0f);
        egg.transform.position = new Vector3(x, 0.5f, z);

        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        rb.isKinematic = false;
    }
}
