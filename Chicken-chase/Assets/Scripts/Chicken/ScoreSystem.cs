using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public static int GameScore = 0;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Score")
        {
            ScoreSystem.GameScore++;
            Debug.Log(ScoreSystem.GameScore);
        }
    }
}
