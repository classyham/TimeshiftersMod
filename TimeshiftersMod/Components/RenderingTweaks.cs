using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using System.Collections;
using UnityEngine.SceneManagement;

namespace TimeshiftersMod.Components
{
    class RenderingTweaks : MonoBehaviour
    {
        void Awake()
        {
            SceneManager.sceneLoaded += OnLevelLoaded;
            
        }

        void OnLevelLoaded(Scene scene, LoadSceneMode mode)
        {
            QualitySettings.vSyncCount = 1;
        }

        /*
        void OnGUI()
        {
            GUI.Label(new Rect(10,10,100,40),"Vsync On");
        }
        */
    }
}
