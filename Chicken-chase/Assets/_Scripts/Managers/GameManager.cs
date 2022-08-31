using System;
using _Scripts.Systems;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Scripts.Managers
{
    public class GameManager : StaticInstance<GameManager> {
        public static event Action<GameState> OnBeforeStateChanged;
        public static event Action<GameState> OnAfterStateChanged;

        private readonly string gameSceneName = "Game_Scene";
        private readonly string menuSceneName = "Menu_Scene";
        private readonly string scoreSceneName = "Score_Scene";

        public GameState State { get; private set; }

        // Kick the game off with the first state
        void Start() => ChangeState(GameState.Menu);

        public void ChangeState(GameState newState) {
            OnBeforeStateChanged?.Invoke(newState);

            State = newState;
            switch (newState) {
                case GameState.Menu:
                    HandleMenu();
                    break;
                case GameState.Game:
                    HandleGame();
                    break;
                case GameState.Score:
                    HandleScore();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
            }

            OnAfterStateChanged?.Invoke(newState);
        
            Debug.Log($"New state: {newState}");
        }

        private void HandleMenu() {
            //Start music or something
            
        }

        private void HandleGame() 
        {
            ScoreManager.Instance.SetPause(false);
            SceneManager.LoadScene(gameSceneName);
        }

        private void HandleScore() 
        {
            ScoreManager.Instance.SetPause(true);
            SceneManager.LoadScene(scoreSceneName);
        }
    
    }

    [Serializable]
    public enum GameState {
        Menu = 0,
        Game,
        Score
    }
}