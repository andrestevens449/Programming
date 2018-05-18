using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AHundredBalls

{
    public class Spawner : MonoBehaviour
    {
        public GameObject prefab;
        public float spawnDelay = 1f;

        // Use this for initialization
        void Start()
        {
            StartCoroutine(Spawn());
        }
        
        IEnumerator Spawn()
        {
            yield return new WaitForSeconds(spawnDelay);

            Instantiate(prefab, transform.position, transform.rotation);

            StartCoroutine(Spawn());

        }
        
    }
}