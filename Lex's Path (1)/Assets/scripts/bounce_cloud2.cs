using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce_cloud2 : MonoBehaviour {
    private bool CloudDown;
    public float CloudMoveSpeed = 0.1f;
    public float moveThreshold = 0.1f;
    float initPosX;

    // Use this for initialization
    void Start () {
        initPosX = transform.position.x;
        int randomNum = Random.Range(0, 10);
        if (randomNum > 5)
        {
            CloudDown = true;
        }
        else
        {
            CloudDown = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (CloudDown)
        {
           
            transform.Translate(Vector2.down * CloudMoveSpeed * Time.deltaTime);
        }

        else
        {
            transform.Translate(-Vector2.down * CloudMoveSpeed * Time.deltaTime);
        }

        if (transform.position.x <= initPosX - moveThreshold)
        {
            CloudDown = true;
        }

        if (transform.position.x >= initPosX + moveThreshold)
        {
            CloudDown = false;
        }
    }
}
