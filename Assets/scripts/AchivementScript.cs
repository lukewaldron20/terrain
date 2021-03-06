﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchivementScript : MonoBehaviour
{
    public GameObject deathBadge;
    public GameObject SurviveBadge;

    // Start is called before the first frame update
    void Start() {
        deathBadge.SetActive(false);
    }

    void OnEnable()
    {
        EventManager.StartListening("GoblinsKilled", revelDeathBadge);
    }

    void OnDisable()
    {
        EventManager.StopListening("GoblinsKilled", revelDeathBadge);
    }

    void revelDeathBadge()
    {
        deathBadge.SetActive(true);
    }
}