using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assessment1
{
    public class Player : MonoBehaviour
    {

        private Rigidbody2D mybody;
        public float speed;
        public float jumpPower;

        // Use this for initialization
        void Start()
        {
            mybody = gameObject.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            float move = Input.GetAxis("Horizontal");
            mybody.velocity = new Vector2(move * speed, mybody.velocity.y);

            if(Input.GetKey(KeyCode.Space))
            {
                mybody.velocity = new Vector2(mybody.velocity.x, jumpPower);
            }
        }
    }
}