using System;
using UnityEngine;

namespace _Scripts.Environment
{
    public class RotateBehaviour : MonoBehaviour
    {
        [SerializeField] private Vector3 rotationSpeed;

        private float speedRotationFactor = 0.0f;

        private void Start()
        {
            //try and error value
            speedRotationFactor = 0.5f / 0.0361f;
        }

        private void Update()
        {
            var rotation = rotationSpeed * Time.timeScale;
            transform.Rotate(rotation);
            var newSpeed = rotation.y / speedRotationFactor;
            transform.Translate(Vector3.down * (newSpeed));
        }
    }
}