using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siniflar : MonoBehaviour
{
    Calculator myCalculator;
    private void Start()
    {
        myCalculator = new Calculator();
        myCalculator.Toplama(6, 7);
        myCalculator.Cikarma(3, 5);
        myCalculator.Carpma(2, 3);
        myCalculator.Bolme(4, 5);
    }
}
public class Calculator
{
    public void Toplama(int x, int y)
    {
        Debug.Log(x + y);
    }
    public void Cikarma(int x, int y)
    {
        Debug.Log(x - y);
    }
    public void Carpma(int x, int y)
    {
        Debug.Log(x * y);
    }
    public void Bolme(int x, int y)
    {
        Debug.Log(x / y);
    }
}
