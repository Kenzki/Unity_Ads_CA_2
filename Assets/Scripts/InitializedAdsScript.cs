using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;


public class InitializedAdsScript : MonoBehaviour
{
    string gameId = "3483584";
    bool testMode = true;

    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
    }
}
