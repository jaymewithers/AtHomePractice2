using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject other;


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(other, 3f);
        }
    }
}

// unity tutorial