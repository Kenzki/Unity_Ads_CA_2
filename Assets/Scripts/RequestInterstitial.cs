﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.UI;

public class RequestInterstitial : MonoBehaviour
{
    private InterstitialAd interstitial;

    public void Start()
    {
#if UNITY_ANDROID
        string appId = "ca-app-pub-7646243595626534~1191490416";
#elif UNITY_IPHONE
            string appId = "ca-app-pub-3940256099942544~1458002511";
#else
            string appId = "unexpected_platform";
#endif

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);


    }

    public void ShowInterstitial()
    {
        RequestInterstitialAd();
    }

    private void RequestInterstitialAd()
    {
#if UNITY_ANDROID
        string interstitialId = "ca-app-pub-3940256099942544/1033173712";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
            string adUnitId = "unexpected_platform";
#endif
        if(interstitial !=null)
            interstitial.Destroy();

        interstitial = new InterstitialAd(interstitialId);
        interstitial.OnAdLoaded += HandleOnAdLoaded;

        interstitial.LoadAd(CreateNewRequest());
    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        if(interstitial.IsLoaded())
        interstitial.Show();
    }


    private AdRequest CreateNewRequest()
    {
        return new AdRequest.Builder().Build();
    }

}
