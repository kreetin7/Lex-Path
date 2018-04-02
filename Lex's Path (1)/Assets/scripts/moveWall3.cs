using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWall3 : MonoBehaviour {
    float ytarget;
    public float yMax;
    public float yMin;

    float moveSpeed = 3;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Vector2.Distance(transform.position, new Vector2(transform.position.x, ytarget)) <= 0.01f)
        {


            if (ytarget <= 2)
            {
                ytarget = yMax;
                transform.localScale = new Vector3(1, 1, 1);
            }
            else
            {
                ytarget = yMin;
                transform.localScale = new Vector3(1, -1, 1);
            }


        }

        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, ytarget), moveSpeed * Time.deltaTime);
    }
}
