using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ShareefSoftware
{
    public class RotateSceneHandler
    {
        private RotateScene rotateScene;
        private int index = 0;

        public RotateSceneHandler(InputAction rotateSceneAction, RotateScene rotate)
        {
            //Rotates the maze when the button "0" is pressed
            this.rotateScene = rotate;
            rotateSceneAction.performed += RotateScene_performed;
            rotateSceneAction.Enable();
        }

        private void RotateScene_performed(InputAction.CallbackContext obj)
        {

            index++;
            if (index % 2 != 0)
            {
                this.rotateScene.ToggleRun();
            }
            else
            {
                this.rotateScene.ToggleStop();
            }
        }
    }
}      
    

