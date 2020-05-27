﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnableAndDisenable : MonoBehaviour
{
    private Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}

// unity tutorial