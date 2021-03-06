﻿using UnityEngine;

public class Health : MonoBehaviour
{
    public int healthValue = 2;

    private void OnTriggerEnter(Collider other)
    {
        healthValue--;
        if (healthValue > 0)
            return;
        Destroy(gameObject, 0.5f);
    }
}