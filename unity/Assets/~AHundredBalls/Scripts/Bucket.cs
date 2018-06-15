using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AHundredBalls
{
    public class Bucket : MonoBehaviour
    {
        public float movementSpeed = 10.0f;
        private Rigidbody2D rigid2D;
        private Renderer[] renderers;
        public Vector2 direction = Vector2.right;


        void Start()
        {
            rigid2D = GetComponent<Rigidbody2D>();
            renderers = GetComponentsInChildren<Renderer>();
        }

        // Use this for initialization
        void Update()
        {
            HandlePosition();
            HandleBoundary();
            
        }

        void HandlePosition()
        {
            rigid2D.velocity = Vector3.right * movementSpeed;
        }

        void HandleBoundary()
        {
            Vector3 transformPos = transform.position;
            Vector3 viewportPos = Camera.main.WorldToViewportPoint(transformPos);

            if(IsVisible() == false && viewportPos.x > 0)
            {
                Destroy(gameObject);
            }

        }
        bool IsVisible()
        {
            foreach (var renderer in renderers)
            {
                if(renderer.isVisible)
                {
                    return true;
                }
            }
            return false;
        }
    }
}