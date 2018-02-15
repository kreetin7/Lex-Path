using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character_behavior : MonoBehaviour {

    float moveSpeed = 0.5f;
    public CircleCollider2D charcollider;

   


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(moveSpeed * Input.GetAxis("Horizontal"), 0f), ForceMode2D.Impulse);



        if (this.GetComponent<Transform>().position.y < -10)
        { //when the position on the x axis is greater than x=10

            SceneManager.LoadScene("Game Over");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Goal7")
        {
            Invoke("LoadWinScene", 1.0f);
        }
        if (collision.gameObject.tag == "Goal3")
        {
            Invoke("Loadlvl4", 1.0f);
        }

        if (collision.gameObject.tag == "Goal1")
        {
            Invoke("LoadLvl2", 1.0f);
        }

        if (collision.gameObject.tag == "Goal2")
        {
            Invoke("Loadlvl3", 1.0f); 
        }

        if (collision.gameObject.tag == "Goal4"){

            Invoke("Loadlvl4", 1.0f);
        }

        if (collision.gameObject.tag == "Goal5"){

            Invoke("Loadlvl6", 1.0f);
        }

        if (collision.gameObject.tag == "Goal6")
        {
            Invoke("Loadlvl7", 1.0f);
        }

       if (collision.gameObject.tag.Equals ("Wall"))
        {
            Destroy(this.gameObject);
            
        }
        
    }

    void LoadWinScene ()
    {
        SceneManager.LoadScene("Win Screen");
    }

    void LoadLvl2 ()
    {
        SceneManager.LoadScene("Level2");
    }

    void Loadlvl3()
    {
        SceneManager.LoadScene("Level3");
    }

    void Loadlvl4()
    {
        SceneManager.LoadScene("Level4");
    }
    void Loadlvl5()
    {
        SceneManager.LoadScene("Level5");
    }

    void Loadlvl6()
    {
        SceneManager.LoadScene("Level6");
    }

    void Loadlvl7()
    {
        SceneManager.LoadScene("Level7");
    }
}


  
