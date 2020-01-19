using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    public int alpha = 5;

    private int beta = 0;
    private int gamma = 5;

    private AnotherClass myOtherClass;

    public void Start ()
    {
        Debug.Log("Alpha is set to: " + alpha);
        alpha = 29;
            
        myOtherClass = gameObject.AddComponent<AnotherClass>();
        AnotherClass.FruitMachine(alpha, myOtherClass.Apples);
        }

    private void Example (int pens, int crayons)
        {
            var answer = pens * crayons * alpha;
            Debug.Log(answer);
        }
}

class ScopeAndAccessModifiersImpl : ScopeAndAccessModifiers
{
}