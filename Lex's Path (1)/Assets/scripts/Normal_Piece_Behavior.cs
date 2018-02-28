using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Normal_Piece_Behavior : MonoBehaviour
{


    //  Vector2 point;  
    // Use this for initialization
    bool dragging = false;
    float distance;

    void OnMouseEnter()
    {

    }

    void OnMouseExit()
    {

    }
    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
    }

    void OnMouseUp()
    {
        dragging = false;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        

        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Wall"))
        {
            Destroy(this.gameObject);
        }
    }




}

