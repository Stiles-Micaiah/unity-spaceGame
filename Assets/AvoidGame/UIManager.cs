﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public ScoreKeeper ScoreKeeper;
    public TextMeshProUGUI CurrentScoreContainer;
    public TextMeshProUGUI HighScoreContainer;

    // Update is called once per frame
    void Update()
    {
        if (CurrentScoreContainer != null)
        {
            CurrentScoreContainer.text = $"Score: {ScoreKeeper.CurrentScore}";
        }
        HighScoreContainer.text = $"Highest: {ScoreKeeper.HighScore}";
    }
}