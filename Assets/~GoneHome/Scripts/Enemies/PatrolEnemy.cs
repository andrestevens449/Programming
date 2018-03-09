using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoneHome
{
    public class PatrolEnemy : MonoBehaviour
    {
        public Transform waypointGroup;
        public float movementSpeed = 5f;
        public float closeness = 1f;


        private Transform[] waypoints;
        private int currentIndex = 0;


        // Use this for initialization
        void Start()
        {
            int length = waypointGroup.childCount;
            waypoints = new Transform[length];
            for (int i = 0; i < length; i++)
            {
                waypoints[i] = waypointGroup.GetChild(i);
            }
        }

        // Update is called once per frame
        void Update()
        {
            Transform current = waypoints[currentIndex];

            Vector3 position = transform.position;
            Vector3 direction = current.position - position;
            position += direction.normalized * movementSpeed * Time.deltaTime;
            transform.position = position;

            float distance = Vector3.Distance(current.position, position);
            if(distance <= closeness)
            {
                currentIndex++;
            }

            if(currentIndex >= waypoints.Length)
            {
                currentIndex = 0;
            }
        }
    }
}