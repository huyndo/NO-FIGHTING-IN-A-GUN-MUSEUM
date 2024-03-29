﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehaviour : MonoBehaviour
{
    public Image filledPart;
    public Image background;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowHealthFraction(float fraction)
    {
        filledPart.rectTransform.localScale = new Vector3(fraction, 1, 1);
        
        if (fraction < 1)
        {
            filledPart.enabled = true;
            background.enabled = true;
        }
        else
        {
            filledPart.enabled = false;
            background.enabled = false;
        }
    }
}
