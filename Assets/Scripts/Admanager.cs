using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class Admanager : MonoBehaviour {

    private BannerView bannerView;

    string mainMenuID = "ca-app-pub-9428337456647443/3372648974";
    string GameOverId = "ca-app-pub-9428337456647443/5731492070";
  
	// Use this for initialization
	public void Start ()
    {
    
        //string testId = "ca-app-pub-3940256099942544/6300978111";
        //RequestBanner(testId);
        
        if(GameObject.Find("GameManager").GetComponent<SceneManagers>().getSceneName() == "MainMenu")
        {
            MainMenuAd();
        }
        else
        { 
            GameOverAd();
        }
	}

    private void RequestBanner(string Id)
    {
        //string adUnitId = "ca-app-pub-9428337456647443/3372648974";
       
        bannerView = new BannerView("ca-app-pub-3940256099942544/6300978111", AdSize.SmartBanner, AdPosition.Bottom);
    }

    private void OnDestroy()
    {
        bannerView.Destroy();

    }

    void MainMenuAd()
    {
        RequestBanner(mainMenuID);
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);

      
    }

    void GameOverAd()
    {

        RequestBanner(GameOverId);
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);
    }
}
