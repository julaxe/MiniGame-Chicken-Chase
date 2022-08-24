using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{

    public static ScoreSystem Instance;

    private int GameScore = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this);
    }

    public void Score()
    {
        GameScore++;
    }

    public int GetScore()
    {
        return GameScore;
    }

    public void ResetScore()
    {
        GameScore = 0;
    }

    
}
