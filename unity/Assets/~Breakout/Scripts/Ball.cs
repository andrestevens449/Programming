using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breakout
{
    public class Ball : MonoBehaviour
    {
        public float speed = 5f;

        private Vector3 velocity;

        public void Fire(Vector3 direction)
        {
            velocity = direction * speed;
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            ContactPoint2D contact = collision.contacts[0];

            Vector3 reflect = Vector3.Reflect(velocity, contact.normal);

            velocity = reflect.normalized * speed;
        }

        // Update is called once per frame
        void Update()
        {
            transform.position += velocity * Time.deltaTime;
        }
    }
}