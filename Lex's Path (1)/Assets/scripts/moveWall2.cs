using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWall2 : MonoBehaviour {

    public float xMin;
    public float xMax;
    float xtarget;

    float speed = 3f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector2.Distance(transform.position, new Vector2(xtarget, transform.position.y)) <= 0.01f)
        {


            if (xtarget <= 4.5)
            {
                xtarget = xMax;

            }
            else
            {
                xtarget = xMin;

            }
        }





        transform.position = Vector2.MoveTowards(transform.position, new Vector2(xtarget, transform.position.y), speed * Time.deltaTime);
    }
}

