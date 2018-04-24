using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum CLIPS { Screaming, WallBump, Doorbell, Bouncy }
public class Character_behavior : MonoBehaviour {

    public float LoadGameOverTimer = 1.5f;

    public bool magic;
     public Animator anim2; 

    Collider2D collide; 

    private SpriteRenderer Sprite;
    float moveSpeed = 4.0f;

    public Dictionary<CLIPS, AudioClip> AudioLibrary;
    AudioSource audiosource;
    AudioClip clipE;
    AudioClip clipP;
    AudioClip clipD;
    AudioClip clipB;


     void OnMouseDown()
    {
        magic = true; 
    }

    // Use this for initialization
    void Start () {

        anim2 = GetComponentInChildren<Animator>();
        magic = false;
        SetMagic(magic);

        collide = GetComponent<Collider2D>();
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

    public void SetMagic(bool m)
    {
        magic = m;
        anim2.SetBool("magic", magic); 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

       

        if (collision.gameObject.tag == "Goal")
        {
            GameManager.Manager.CurrentLevel++;
            Debug.Log("Current Level" + GameManager.Manager.CurrentLevel);
            Debug.Log("here");
            if (SceneManager.GetActiveScene().name == "tutorial3")
            {
                GameManager.Manager.tutorialDone = true;
                GameManager.Manager.CurrentLevel = 1;
            }
            if (GameManager.Manager.tutorialDone == false)
            {
               
                SceneManager.LoadScene("tutorial" + GameManager.Manager.CurrentLevel);

            }


            else
            {
                
                SceneManager.LoadScene("Level" + GameManager.Manager.CurrentLevel);
            }
            audiosource.PlayOneShot(AudioLibrary[CLIPS.Doorbell]);
        }
       
        if (collision.gameObject.tag == "GoalFinal")
        {
            SceneManager.LoadScene("Win Screen");
            audiosource.PlayOneShot(AudioLibrary[CLIPS.Doorbell]);
        }

     

       if (collision.gameObject.tag.Equals ("Wall"))
        {
            audiosource.PlayOneShot(AudioLibrary[CLIPS.Screaming]);

            collision.gameObject.GetComponent<Wall_Behavior>().SetScared(true);
            Invoke("GameOverPlz", LoadGameOverTimer);
            Sprite.sortingOrder = 0;
            collide.enabled = !collide.enabled;

            Screen_Shake.shakeTimer = 0.7f;
            Screen_Shake.shakeScreen = true;
            Screen_Shake.playOnce = true;
            
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


  
