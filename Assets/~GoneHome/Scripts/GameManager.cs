﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

namespace GoneHome
{
    public class GameManager : MonoBehaviour
    {
        public void NextLevel()
        {
            Scene currentScene = SceneManager.GetActiveScene();

            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }

        public void ResetLevel()
        {
            Scene currentscene = SceneManager.GetActiveScene();

            SceneManager.LoadScene(currentscene.buildIndex);
        }
    }
}