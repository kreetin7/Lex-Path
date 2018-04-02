using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum CLIPS { Screaming, WallBump, Doorbell, Bouncy }
public class Character_behavior : MonoBehaviour {

    public float LoadGameOverTimer = 1.5f;

    private SpriteRenderer Sprite;
    float moveSpeed = 4.0f;

    public Dictionary<CLIPS, AudioClip> AudioLibrary;
    AudioSource audiosource;
    AudioClip clipE;
    AudioClip clipP;
    AudioClip clipD;
    AudioClip clipB; 
    //public bool UnlockLevel2; 



    // Use this for initialization
    void Start () {
        // UnlockLevel2 = false; 
        Sprite = transform.Find("Witch Sprite").GetComponent<SpriteRenderer>();

        AudioLibrary = new Dictionary<CLIPS, AudioClip>();
        AudioLibrary.Add(CLIPS.Screaming, Resources.Load<AudioClip>("audio/cat-scream"));
        AudioLibrary.Add(CLIPS.WallBump, Resources.Load<AudioClip>("audio/wood"));
        AudioLibrary.Add(CLIPS.Doorbell, Resources.Load<AudioClip>("audio/doorbell"));
        AudioLibrary.Add(CLIPS.Bouncy, Resources.Load<AudioClip>("audio/slime"));
        audiosource = GetComponent<AudioSource>();
        clipE = AudioLibrary[CLIPS.Screaming];
        clipP = AudioLibrary[CLIPS.WallBump];
        clipD = AudioLibrary[CLIPS.Doorbell]; 
    }

    // Update is called once per frame
    void Update () {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(moveSpeed * Input.GetAxis("Horizontal"), 0f), ForceMode2D.Impulse);



        if (this.GetComponent<Transform>().position.y < -10)
        { //when the position on the x axis is greater than x=10

            SceneManager.LoadScene("Game Over");
        }

        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Goal")
        {
            GameManager.Manager.CurrentLevel++;
            Debug.Log("Current Level" + GameManager.Manager.CurrentLevel);
            Debug.Log("here");
            SceneManager.LoadScene("Level" + GameManager.Manager.CurrentLevel);
            audiosource.PlayOneShot(AudioLibrary[CLIPS.Doorbell]);
        }
       

       if (collision.gameObject.tag.Equals ("Wall"))
        {
            audiosource.PlayOneShot(AudioLibrary[CLIPS.Screaming]);

            collision.gameObject.GetComponent<Wall_Behavior>().SetScared(true);
            Invoke("GameOverPlz", LoadGameOverTimer);
            Sprite.sortingOrder = 0; 
            
            
        }

       if (collision.gameObject.tag.Equals("PathPiece"))
        {
            audiosource.PlayOneShot(AudioLibrary[CLIPS.WallBump]); 
        }

       if (collision.gameObject.tag.Equals("BouncyPiece"))
        {
            audiosource.PlayOneShot(AudioLibrary[CLIPS.Bouncy]);
        }
        
    }

    public void GameOverPlz()
    {
        SceneManager.LoadScene("Game Over");
        Debug.Log("Shit");
    }
    

 
}


  
