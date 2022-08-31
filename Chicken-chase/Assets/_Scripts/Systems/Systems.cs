using UnityEngine;

namespace _Scripts.Systems
{
    public class Systems : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}