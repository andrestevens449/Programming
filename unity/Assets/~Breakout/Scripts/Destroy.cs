using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Breakout
{

    public class Destroy : MonoBehaviour
    {
        public static int score = 0;
        public Text scoreText;

        //when destroying one block you gain one point, adds up on screen
        //making a score that is greater than "0"
        void OnCollisionEnter2D(Collision2D coll)
        {
            if (coll.gameObject.tag == "Block")
            {
                Destroy(coll.gameObject);
                score++;
                scoreText.text = score.ToString();
                Debug.Log(score);
            }

            if (coll.gameObject.tag == "Reset")
            {
                SceneManager.LoadScene(0);
            }
        }


        // starting the game off with the starting score "0"
        void Start()
        {
            score = 0;
        }

    }
}