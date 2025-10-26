using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donguler : MonoBehaviour
{
    int number = 0;
    void Start()
    {
        // While
        while (number < 5)
        {
            number++;
            Debug.Log(number);
        }

        // For
        for (int i = 0; i < number; i++)
        {
            Debug.Log(i);
        }

        // do while
        do
        {
            number--;
            Debug.Log(number);
        } while (number>5);


    }
}
