using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    //singleton 
    public static GameManager Manager;

    public bool tutorialDone; 

    public int CurrentLevel = 1; 
  
	// Use this for initialization
	void Start () {
      
        if (Manager == null)
        {
            Manager = this;
            DontDestroyOnLoad(gameObject); 
        }

        else
        {
            Destroy(this.gameObject);
        }

        tutorialDone = false; 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)){

            SceneManager.LoadScene("Load Screen");
        }

        Debug.Log(CurrentLevel);
	}
}
