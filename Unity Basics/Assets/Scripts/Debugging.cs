using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugging : MonoBehaviour
{
    string fullName = "Yasin Küçüker";
    int tamSayi = 5;
    float ondalik = 5.5f;
    bool dogruMu = false;
    char karakter = 'c';

    int number1 = 6;
    int number2 = 7;
    int result;

    string kelime1 = "merhaba";
    string kelime2 = "dünya";
    string resultString;

    private void Start()
    {
        Debug.Log("Hello World!");
        print("Hello World2");
        Debug.Log(fullName);
        Debug.Log(tamSayi);
        Debug.Log(ondalik);
        Debug.Log(dogruMu);
        Debug.Log(karakter);

        result = number1 + number2;
        Debug.Log(result);
        result++;
        Debug.Log(result);
        resultString = kelime1 + kelime2;
        Debug.Log(resultString);

        Debug.Log("Yasin\nKüçüker");
    }
}
