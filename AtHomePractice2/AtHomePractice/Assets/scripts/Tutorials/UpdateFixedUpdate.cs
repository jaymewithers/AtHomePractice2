﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateFixedUpdate : MonoBehaviour
{
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate time" + Time.deltaTime);
    }

    private void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}

// unity tutorial
