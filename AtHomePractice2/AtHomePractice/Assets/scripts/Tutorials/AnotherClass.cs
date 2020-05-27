using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int Apples;
    public int bananas;

    private int stapler;
    private int sellotape;

    public static void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }

    private void OfficeSort(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
}

//unity tutorial