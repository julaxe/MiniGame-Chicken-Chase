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
            GameScore++;
            Debug.Log(GameScore);
        }
    }
}
