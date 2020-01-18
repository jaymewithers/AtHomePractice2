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
        
    Void Start ()
    {
        Debug.Log("Alpha is set to: " + alpha);
        alpha = 29;
            
        myOtherClass = new AnotherClass();
        AnotherClass.FruitMachine(alpha, myOtherClass.Apples);
        }

        void Example (int pens, int crayons)
        {
            int answer;
            answer = pens * crayons * alpha;
            Debug.Log(answer);
        }
}