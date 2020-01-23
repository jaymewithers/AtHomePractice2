using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;
    
    void Update()
    {
        transform.LookAt(target);
    }
}

// apply to camera then drag in object you want camera to follow to target variable field

// unity tutorial