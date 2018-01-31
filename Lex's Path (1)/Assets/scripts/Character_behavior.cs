using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character_behavior : MonoBehaviour {

    float moveSpeed = 2f;
    public CircleCollider2D charcollider;

    Rigidbody2D charbody; 


	// Use this for initialization
	void Start () {
        charbody = GetComponent<Rigidbody2D>(); 
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(Input.GetAxis("Horizontal"), 0f), ForceMode2D.Impulse);

        

        if (this.GetComponent<Transform>().position.y < -5)
        { //when the position on the x axis is greater than x=10

            SceneManager.LoadScene("Game Over");
        }
    }
}

  
