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
    }

    public void GotoLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void GotoLevel3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void GotoLevel4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void GotoLevel5()
    {
        SceneManager.LoadScene("Level5");
    }

    public void GotoLevel6()
    {
        SceneManager.LoadScene("Level6");
    }

    public void GotoLevel7()
    {
        SceneManager.LoadScene("Level7");
    }
}
