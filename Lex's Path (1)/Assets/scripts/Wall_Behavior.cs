﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wall_Behavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.FindWithTag ("Player") == null)
        {
            SceneManager.LoadScene("Game Over"); 
        }
		
	}
   
   
}
