using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character_behavior : MonoBehaviour {
  
    float moveSpeed = 4.0f;
    //public bool UnlockLevel2; 
   


	// Use this for initialization
	void Start () {
        // UnlockLevel2 = false; 
        
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

        if (collision.gameObject.tag == "Goal")
        {
            GameManager.CurrentLevel++;
            Debug.Log("Current Level" + GameManager.CurrentLevel);
            Debug.Log("here");
            SceneManager.LoadScene("Level" + GameManager.CurrentLevel);
            
        }
        /*if (collision.gameObject.tag == "Goal7")
        {
            Invoke("LoadWinScene", 1.5f);
            
                }
        if (collision.gameObject.tag == "Goal3")
        {
            Invoke("Loadlvl4", 1.0f);
        }

        if (collision.gameObject.tag == "Goal1")
        {
           // Level2 = true; 
            Invoke("LoadLvl2", 1.5f);
        }

        if (collision.gameObject.tag == "Goal2")
        {
            Invoke("Loadlvl3", 1.5f); 
        }

        if (collision.gameObject.tag == "Goal4"){

            Invoke("Loadlvl4", 1.5f);
        }

        if (collision.gameObject.tag == "Goal5"){

            Invoke("Loadlvl6", 1.5f);
        }

        if (collision.gameObject.tag == "Goal6")
        {
            Invoke("Loadlvl7", 1.5f);
        }
        */

       if (collision.gameObject.tag.Equals ("Wall"))
        {
            Destroy(this.gameObject);
            GameManager.CurrentLevel = 1; 
            
        }
        
    }

  /*  void LoadWinScene ()
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
    */
}


  
