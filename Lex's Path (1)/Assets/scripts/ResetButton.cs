using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ResetButton : MonoBehaviour {

   
    void OnMouseDown()
    {
        Invoke("LoadScene1", 1.0f); 
    }

    
    public void LoadScene1()
    {
        SceneManager.LoadScene("Scene 1-lvl 1");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
