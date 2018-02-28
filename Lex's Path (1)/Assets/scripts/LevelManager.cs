using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager: MonoBehaviour {
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GotoLevelSelect()
    {
        SceneManager.LoadScene("Load Screen");
    }

    public void GotoStart()
    {
        SceneManager.LoadScene("Start Screen");
    }

    public void GotoLevel1()
    {
        SceneManager.LoadScene("Level1");
        GameManager.Manager.CurrentLevel = 1; 
    }

    public void GotoLevel2()
    {
            SceneManager.LoadScene("Level2");
        GameManager.Manager.CurrentLevel = 2; 
    }

    public void GotoLevel3()
    {
        SceneManager.LoadScene("Level3");
        GameManager.Manager.CurrentLevel = 3; 
    }

    public void GotoLevel4()
    {
        SceneManager.LoadScene("Level4");
        GameManager.Manager.CurrentLevel = 4; 
    }

    public void GotoLevel5()
    {
        SceneManager.LoadScene("Level5");
        GameManager.Manager.CurrentLevel= 5; 
    }

    public void GotoLevel6()
    {
        SceneManager.LoadScene("Level6");
        GameManager.Manager.CurrentLevel = 6; 
    }

    public void GotoLevel7()
    {
        SceneManager.LoadScene("Level7");
        GameManager.Manager.CurrentLevel = 7; 
    }

    public void GotoLevel8()
    {
        SceneManager.LoadScene("Level8");
        GameManager.Manager.CurrentLevel = 8; 
    }

    public void GotoLevel9 ()
    {
        SceneManager.LoadScene("Level9");
        GameManager.Manager.CurrentLevel = 9; 
    }

    public void GotoLevel10 ()
    {
        SceneManager.LoadScene("Level10");
        GameManager.Manager.CurrentLevel = 10; 
    }

    public void GotoLevel11()
    {
        SceneManager.LoadScene("Level11");
        GameManager.Manager.CurrentLevel = 11; 
    }

    public void GotoLevel12()
    {
        SceneManager.LoadScene("Level12");
        GameManager.Manager.CurrentLevel = 12; 
    }

    public void GotoLevel13 ()
    {
        SceneManager.LoadScene("Level13");
        GameManager.Manager.CurrentLevel = 13; 
    }

    public void GotoLevel14 ()
    {
        SceneManager.LoadScene("Level14");
        GameManager.Manager.CurrentLevel = 14; 
    }

    public void GotoLevel15 ()
    {
        SceneManager.LoadScene("Level15");
        GameManager.Manager.CurrentLevel = 15; 
    }

    public void GotoMenu ()
    {
        SceneManager.LoadScene("Start Screen");
    }

    public void GoToCurrentLevel()
    {
        SceneManager.LoadScene(GameManager.Manager.CurrentLevel);
    }
}
