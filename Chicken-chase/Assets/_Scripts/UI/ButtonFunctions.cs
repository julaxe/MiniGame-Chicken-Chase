using System.Collections;
using System.Collections.Generic;
using _Scripts.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    public void GoToGameScene()
    {
       GameManager.Instance.ChangeState(GameState.Game);
    }
    public void GoToMenu()
    {
        GameManager.Instance.ChangeState(GameState.Menu);
    }
    public void GoToScore()
    {
        GameManager.Instance.ChangeState(GameState.Score);
    }
    public void GoToLeaderBoard()
    {
        //
    }
}
