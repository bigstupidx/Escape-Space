using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PlayGamesScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.Activate();

	}
	
	public static void SignIn()
    {
        Social.localUser.Authenticate(success => { });
    }

    public static void AddScoreToLeaderboard(string leaderboardId, long score)
    {
        Social.ReportScore(score, leaderboardId, succes => { });
    }

    public static void ShowLeaderboardsUI()
    {
        SignIn();
        Social.ShowLeaderboardUI();
    }
}
