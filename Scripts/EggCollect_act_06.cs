using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCollect : MonoBehaviour
{
    private GameObject score_text;
    public delegate void scoreChange(int score);
    public event scoreChange onScoreChange;
    public NewCollisionNotifier collisionNotifier;
    public int group_1_score = 5;
    public int group_2_score = 10;
    public int player_score = 0;
    // Start is called before the first frame update
    void Start()
    {
        collisionNotifier.onEggsGroup1Collision += collectEggGroup1;
        collisionNotifier.onEggsGroup2Collision += collectEggGroup2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void collectEggGroup1()
    {
        player_score += group_1_score;
        Debug.Log("Player score: " + player_score);
        onScoreChange(player_score);
    }

    void collectEggGroup2()
    {
        player_score += group_2_score;
        Debug.Log("Player score: " + player_score);
        onScoreChange(player_score);
    }
}
