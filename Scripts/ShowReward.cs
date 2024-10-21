using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// using UnityEngine.UI;
using TMPro;
public class ShowReward : MonoBehaviour
{
    public EggCollect eggCollectNotifier;
    public GameObject reward_object;
    public TextMeshProUGUI reward_text;
    // Start is called before the first frame update
    void Start()
    {
        eggCollectNotifier.onScoreReward += showReward;
        if (reward_object == null)
        {
            reward_object = GameObject.FindWithTag("reward");
        }
        reward_text = reward_object.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void showReward(int score)
    {   
        reward_text.enabled = true;
        StartCoroutine(hideReward());
    }

    IEnumerator hideReward()
    {
        yield return new WaitForSeconds(2);
        reward_text.enabled = false;
    }
}
