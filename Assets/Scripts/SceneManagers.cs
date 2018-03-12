using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagers : MonoBehaviour {

    public AudioSource UIClick;
    static SceneManagers Instance;
    public static string currentScene;
	void Start ()
    {
        currentScene = "MainMenu";
        
	    if(Instance != null)
        {
            Destroy(gameObject);
            
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
	}

    private void Update()
    {
        
    }

    public void changeToScene(string scene)
    {
        currentScene = scene;
        UIClick.Play();
       
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
       
    }

    public void ShowLeaderboards()
    {
        UIClick.Play();
        PlayGamesScript.ShowLeaderboardsUI();
       
    }

    public string getSceneName()
    {
        return currentScene;
    }
}
