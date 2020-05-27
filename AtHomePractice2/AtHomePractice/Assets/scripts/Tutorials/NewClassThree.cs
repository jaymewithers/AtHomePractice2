using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewClassThree : MonoBehaviour
{
    public int cupsInTheSink = 4;
    void Start()
    {
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
    }
}
