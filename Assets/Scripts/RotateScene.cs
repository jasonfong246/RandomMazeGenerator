using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.EventSystems.EventTrigger;

namespace ShareefSoftware
{
    public class RotateScene : MonoBehaviour
    {
        [SerializeField] private Transform cameraTarget;
        [SerializeField] private Transform target;
        public float rotationSpeed = 25.0f;
        private bool toggleRun = false;

        public void Start()
        {
            // Set the camera to the center of the maze
            float centerX = (target.GetChild(0).position.x + target.GetChild(target.childCount - 1).position.x) / 2.0f;
            float centerY = 110.0f;
            float centerZ = (target.GetChild(0).position.z + target.GetChild(target.childCount - 1).position.z) / 2.0f;
            cameraTarget.transform.position = new Vector3(centerX, centerY, centerZ);                        
        }

        public void ToggleRun()
        {
            toggleRun = true;
        }
        public void ToggleStop()
        {
            toggleRun = false;
        }

        public void Update()
        {

            if (toggleRun)
            {
                // Rotate the maze around the centre by getting the last and first child of the maze
                float centerX = (target.GetChild(0).position.x + target.GetChild(target.childCount - 1).position.x) / 2.0f;
                float centerY = (target.GetChild(0).position.y + target.GetChild(target.childCount - 1).position.y) / 2.0f;
                float centerZ = (target.GetChild(0).position.z + target.GetChild(target.childCount - 1).position.z) / 2.0f;               
                Vector3 centerPosition = new Vector3(centerX, centerY, centerZ);
                target.gameObject.transform.RotateAround(centerPosition, Vector3.up, rotationSpeed * Time.deltaTime);
            }
        }
    }
}
