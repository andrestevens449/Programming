using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

namespace GoneHome
{
    public class GameManager : MonoBehaviour
    {
        // Switches to next scene when called
        public void NextLevel()
        {
            // Get the current loaded scene
            Scene currentScene = SceneManager.GetActiveScene();
            // Load the one next to it (using buildIndex)
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }


        // Added new levels, GameManager, Player fix and Death

        // Restart the damn level
        public void ResetLevel()
        {
            // Find all enemies within the game
            FollowEnemy[] enemies = FindObjectsOfType<FollowEnemy>();
            // Loop through all of them
            for (int i = 0; i < enemies.Length; i++)
            {
                // Reset them!
                enemies[i].Reset();
            }

            // Find the player
            Player player = FindObjectOfType<Player>();
            // Reset them!
            player.Reset();
        }
    }
}