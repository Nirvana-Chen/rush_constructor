using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Completed
{
    public class Restart : MonoBehaviour
    {
        public GameObject gameManager;          //GameManager prefab to instantiate.


        void Update()
        {
            //Check if a GameManager has already been assigned to static variable GameManager.instance or if it's still null
            if (Input.GetKeyDown(KeyCode.R))
            {
                //#if UNITY_EDITOR
                //                UnityEditor.EditorApplication.isPlaying = false;
                //#else
                //        Application.Quit();
                //#endif
                GameManager.instance.level = 1;
                GameManager.instance.playerFoodPoints = 100;
                GameManager.instance.InitGame();
            }
        }
    }
}