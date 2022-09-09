using System;
using UnityEngine;

namespace _Scripts.Environment
{
    public class ScrollTexture : MonoBehaviour
    {
        [SerializeField] private float scrollSpeedX;
        [SerializeField] private float scrollSpeedY;

        private MeshRenderer meshRenderer;
        private void Awake()
        {
            meshRenderer = GetComponent<MeshRenderer>();
        }

        private void Update()
        {
            var timeSinceStartUp = Time.realtimeSinceStartup;
            meshRenderer.material.mainTextureOffset = new Vector2(timeSinceStartUp * scrollSpeedX,
                timeSinceStartUp * scrollSpeedY);
        }
    }
}