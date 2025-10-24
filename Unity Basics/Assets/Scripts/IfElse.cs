using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour
{
    int number = 5;
    int x = 20, y = 10;
    // Start is called before the first frame update
    void Start()
    {
        if (number == 5)
            Debug.Log("Sayı 5'e eşittir.");
        else
            Debug.Log("Sayı 5'e eşit değildir.");

        var result = x > y ? "x is greater than y" : "x less than y";
        print(result);
    }

}
