using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Analyticstest : MonoBehaviour
{
    public void OnGameOver()
    {
        Debug.Log("ongameover");
        int totalPotions = 5;
        int totalCoins = 100;
        Analytics.CustomEvent("gameOver", new Dictionary<string, object>
        {
            { "potions", totalPotions },
            { "coins", totalCoins }
        });
    }
}