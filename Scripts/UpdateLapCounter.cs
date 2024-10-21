using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class UpdateLapCounter : MonoBehaviour
{
    public GameObject lapCounter_object;
    public TextMeshProUGUI lapCounter_text;
    public LapCounter lapCounter;
    // Start is called before the first frame update
    void Start()
    {
        lapCounter.onLapCount += updateLapCounter;
        if (lapCounter_object == null)
        {
            lapCounter_object = GameObject.FindWithTag("lap_counter");
        }
        lapCounter_text = lapCounter_object.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateLapCounter(int lap)
    {
        lapCounter_text.text = $"Vuelta => {lap}";
    }
}
