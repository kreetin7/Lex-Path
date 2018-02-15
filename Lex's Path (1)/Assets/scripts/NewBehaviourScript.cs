using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour {

     public void OnMouseDown()
    {
        Invoke("LoadScene2", 1.0f);
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("scene 2 - lvl 2");
    }

    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
