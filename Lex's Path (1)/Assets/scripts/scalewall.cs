using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalewall : MonoBehaviour {

    bool incScale;
    float xTarget;
    float yTarget;
    public float scalespeed;
    public float scalesize;


	// Use this for initialization
	void Start () {
        incScale = true; 
	}
	
	// Update is called once per frame
	void Update () {

        if (incScale)
        {
            if (xTarget < scalesize)
            {
                xTarget += scalespeed;
                yTarget += scalespeed; 
            }

            else
            {
                incScale = false; 
            }


        }

        else
        {
            if (xTarget > 0)
            {
                xTarget -= scalespeed;
                yTarget -= scalespeed; 
            }

            else
            {
                incScale = true; 
            }
        }

        transform.localScale = new Vector3(1 + xTarget, 1 + yTarget, 1);
       // if (Vector2.Scale (new Vector2 ())
	}
}
