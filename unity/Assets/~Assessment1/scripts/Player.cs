using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float jumpHeight;
    // storing rigid body in rigid 2D
    public Rigidbody2D rigid2D;
    public bool canJump = true;
    public float movementSpeed;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ground")
        {
            canJump = true;
        }

        if (col.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(0);
        }
    }

    // Use this for initialization
    void Start ()
    {
       rigid2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey (KeyCode.Space) && canJump == true)
        {
            rigid2D.AddForce(Vector2.up * jumpHeight);
            canJump = false;
        }
        //your able to press the d letter or right arrow to move right
        if(Input.GetKey (KeyCode.D)|| Input.GetKey (KeyCode.RightArrow))
        {
            rigid2D.AddForce(Vector2.right * movementSpeed);
        }
	}
}
