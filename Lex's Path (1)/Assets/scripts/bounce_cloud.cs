using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce_cloud : MonoBehaviour {
    [SerializeField]private bool spriteHorizontal;
    [SerializeField]private bool CloudDown;
    public float CloudMoveSpeed = 0.1f;
    public float moveThreshold = 0.1f;
    float initPosY;
    float initPosX;

	// Use this for initialization
	void Start () {
        if (transform.rotation.eulerAngles.z == 90)
        {
            spriteHorizontal = false;
        }
        else
        {
            spriteHorizontal = true;
        }


        initPosY = transform.position.y;
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
                if(spriteHorizontal)
                    transform.Translate(Vector2.down * CloudMoveSpeed * Time.deltaTime);
                else
                    transform.Translate(Vector2.left * CloudMoveSpeed * Time.deltaTime);

            }

            else
            {
                if(spriteHorizontal)
                    transform.Translate(-Vector2.down * CloudMoveSpeed * Time.deltaTime);
                else
                    transform.Translate(-Vector2.left * CloudMoveSpeed * Time.deltaTime);

            }


            if (transform.position.y >= initPosY + moveThreshold)
            {
                CloudDown = true;
            }

            if (transform.position.y <= initPosY - moveThreshold)
            {
                CloudDown = false;
            }
       

        
	}
}
