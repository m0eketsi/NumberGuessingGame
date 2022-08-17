using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    private int guess;
    private int minValue = 1;
   private int maxValue = 10;

    void Start()
    {
        Debug.Log("Welcome to our Number Guessing Game.");
        Debug.Log("The number range is from " + minValue + "and" + maxValue);
    }

    void Update()
    {
        
    }
}
