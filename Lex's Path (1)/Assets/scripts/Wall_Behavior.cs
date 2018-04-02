using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Wall_Behavior : MonoBehaviour {

    [SerializeField] private bool scared;
    private Animator anim;
    // Use this for initialization
    void Start () {
        anim = GetComponentInChildren<Animator>();
        scared = false;
        SetScared(scared);
    }
	

    public void SetScared(bool b)
    {
        scared = b;
        anim.SetBool("Scared", scared);

    }

    // Update is called once per frame
    void Update () {
                /*  if (GameObject.FindWithTag ("Player") == null)
          {
              SceneManager.LoadScene("Game Over");
              Debug.Log("dead");
          }
          */
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        scared = true; 
    }


}
