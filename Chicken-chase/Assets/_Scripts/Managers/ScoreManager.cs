using UnityEngine;

namespace _Scripts.Managers
{
    public class ScoreManager : Singleton<ScoreManager>
    {
        private int GameScore = 0;

        private float _timer;

        private bool isPaused;

        private void Update()
        {
            if (isPaused) return;
            if (_timer >= 1.0f)
            {
                _timer = 0.0f;
                Score();
            }

            _timer += Time.deltaTime;
        }

        private void Score()
        {
            GameScore++;
        }

        public int GetScore()
        {
            return GameScore;
        }

        public void SetPause(bool value) => isPaused = value;

        public void ResetScore()
        {
            GameScore = 0;
        }

    
    }
}
