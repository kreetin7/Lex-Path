using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWall : MonoBehaviour {

    public float xMin;
    public float xMax;
    float xtarget;

    float speed = 3f; 



	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        /*if (this.GetComponent<Transform>().position.y > 10) {
                    transform.position += new Vector3(0f, -1.0f, 0f);
                }

                if (this.GetComponent<Transform>().position.x < -10)
                {
                    transform.position += new Vector3(0f, 1.0f, 0f); 
                }
                */
        // transform.position = new Vector3(Mathf.PingPong(Time.time, 3), transform.position.y, transform.position.z);

        if (Vector2.Distance(transform.position, new Vector2(xtarget, transform.position.y)) <= 0.01f)
        {

           
                if (xtarget <= -4.5)
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
