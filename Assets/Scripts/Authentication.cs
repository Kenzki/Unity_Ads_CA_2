﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;

public class Authentication : MonoBehaviour
{
    public static PlayGamesPlatform platform;

    void Start()
    {
        if(platform == null)
        {
            PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.DebugLogEnabled = true;

            platform = PlayGamesPlatform.Activate();
        }

        Social.Active.localUser.Authenticate(success =>
            {
                if (success)
            {
                    Debug.Log("Logged Success");
            }
                else
                {
                    Debug.Log("Failed Login");
                }
            
            });

    }


}
