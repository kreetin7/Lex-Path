using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Normal_Piece_Behavior : MonoBehaviour
{

    
   
    // Use this for initialization
    bool dragging = false;
    float distance;

    public GameObject particles;

   

  
    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
        //Character_behavior.Animator.magic = true;
    }

    void OnMouseUp()
    {
        dragging = false;
    }
    void Start()
    {
        
        particles = transform.GetChild(1).gameObject;
        particles.SetActive (false);

    }

    // Update is called once per frame
    void Update()
    {

        
        

        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
            particles.SetActive(true);

        }
        else
        {
            particles.SetActive(false);
        }
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
      
    }




}

