using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour {

    public static UIScript Instance { get; private set; }

    // Use this for initialization
    void Start()
    {
        Instance = this;
    }

    public void ShowLeaderboards()
    {
        PlayGamesScript.ShowLeaderboardsUI();
    }

    public void RateUs()
    {
        Application.OpenURL("market://details?id=com.TarikAB.Jojo/");
    }
}
