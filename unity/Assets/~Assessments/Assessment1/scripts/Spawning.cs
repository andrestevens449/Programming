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

    //allowing unity to add tags to the objects used to be duplicated, as the game goes on.
    void Start ()
    {
        walls = GameObject.FindGameObjectsWithTag("wall");
        ground = GameObject.FindGameObjectWithTag("Ground");
	}

    //the raycast needs to hit empty space to be able to build new objects.
    public void FixedUpdate()
    {
        origin = transform.position;
        
        RaycastHit2D hit = Physics2D.Raycast(origin, rayDirection * rayDistance);

        if (hit.collider == null)
        {
            Spawn();
        }
        //allows me to see the raycast in the editor to see whats happening with the spawning system.
        Debug.DrawRay(origin, rayDirection * rayDistance);
    }

    //spawning the ground and walls to be preset randomly to make a level as you go.
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
