﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decoration : MonoBehaviour
{
    private Stats stats;
    public int HappinessIncrease;
    // Start is called before the first frame update
    void Start()
    {
        stats = FindObjectOfType<Stats>();
        if (HappinessIncrease <= 0)
        {
            HappinessIncrease = 50;
        }
        stats.happiness += HappinessIncrease;
        UIManager.instance.UpdateValues();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
