using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class InterstitialAdsScript : MonoBehaviour
{

    string gameId = "3483584";
    bool testMode = true;

    void Start()
    {
        // Initialize the Ads service:
        Advertisement.Initialize(gameId, testMode);
        // Show an ad:
        Advertisement.Show();
    }
}
