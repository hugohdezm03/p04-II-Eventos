using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCounter : MonoBehaviour
{
    public int lapCount = 0;

    public delegate void lapCounter(int lap);
    public event lapCounter onLapCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "meta")
        {
            lapCount++;
            onLapCount(lapCount);
        }
    }
}
