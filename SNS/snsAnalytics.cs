using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class snsAnalytics : MonoBehaviour
{
    int share = 0;

    public void Pushsns()
    {
        share += 1;

        Analytics.CustomEvent("sns-share", new Dictionary<string, object>
        {
            { "share", share },

        });
    }
}