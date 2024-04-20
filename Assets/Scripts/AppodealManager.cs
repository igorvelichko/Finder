using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class AppodealManager : MonoBehaviour
{
    private const string APP_KEY = "95b220c39e6b72809ce1fc855ee7bff960eae4716faef3f9";
    [SerializeField] private bool isTesting;

    private void Start()
    {
        Initialization();
    }

    public void ShowInterAbs()
    {
        if (Appodeal.canShow(Appodeal.INTERSTITIAL))
            Appodeal.show(Appodeal.INTERSTITIAL);
    }

    private void Initialization()
    {
        Appodeal.setTesting(isTesting);

        Appodeal.disableLocationPermissionCheck();

        Appodeal.muteVideosIfCallsMuted(true);

        Appodeal.initialize(APP_KEY, Appodeal.INTERSTITIAL);
    }



}
