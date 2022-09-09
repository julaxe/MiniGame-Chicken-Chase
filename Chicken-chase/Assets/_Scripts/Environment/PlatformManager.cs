using System;
using System.Collections.Generic;
using UnityEngine;

namespace _Scripts.Environment
{
    public class PlatformManager : MonoBehaviour
    {
        [SerializeField] private float twistedPlatformHeight = 130.0f;
        [SerializeField] private Vector3 startingPoint;
        [SerializeField] private Vector3 endingPoint;
        

        public List<GameObject> listOfPlatform = new List<GameObject>();

        private Queue<GameObject> platformQueue;

        private void Start()
        {
            
        }

        private void Update()
        {
            CheckPosition();
        }

        private void CheckPosition()
        {
            foreach (var platform in listOfPlatform)
            {
                if (platform.transform.localPosition.y <= endingPoint.y)
                {
                    platform.transform.localPosition = startingPoint;
                    return;
                }
            }
        }
    }
}