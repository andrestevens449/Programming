using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour 
{
    public Vector2 origin;
    public Vector2 rayDirection = Vector2.down;
    public float rayDistance = 20f;
    public GameObject[] walls;
    public GameObject ground;

    void Start ()
    {
        walls = GameObject.FindGameObjectsWithTag("wall");
        ground = GameObject.FindGameObjectWithTag("Ground");
	}

    public void FixedUpdate()
    {
        origin = transform.position;
        
        RaycastHit2D hit = Physics2D.Raycast(origin, rayDirection * rayDistance);

        if (hit.collider == null)
        {
            Spawn();
        }
        Debug.DrawRay(origin, rayDirection * rayDistance);
    }

    public void Spawn()
    {
        Vector3 spawnPoint = new Vector3(transform.position.x, 0, 0);
        Instantiate(ground, spawnPoint, Quaternion.identity);
        for(int i = 0; i < walls.Length; i++)
        {
            spawnPoint = new Vector3(spawnPoint.x + 16.5f, 0, 0);
            Instantiate(walls[Random.Range(0, 2)], spawnPoint, Quaternion.identity);
        }
    }
}
