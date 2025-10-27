using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metotlar : MonoBehaviour
{
    int number1, number2;
    int result;

    public List<int> myNumbers = new List<int>();
    public List<string> myPersonal = new List<string>();

    private void Start()
    {
        Toplama();
        UserName("Yaso");
        Debug.Log(Cikarma(6, 8));
        ForLoopExample(myNumbers);
    }

    private void Toplama()
    {
        result = number1 + number2;
        Debug.Log(result);
    }

    private int Cikarma(int number1, int number2)
    {
        return number1 - number2;
    }

    private void UserName(string name)
    {
        Debug.Log(name);
    }

    private void ForLoopExample(List<int> list){
        for(int i=0;i< list.Count; i += 2)
        {
            Debug.Log("FOR LOOP Index: " + i  + " FOR LOOP Value: " + list[i]);
        }
        Debug.Log("List length : " + list.Count);
    }
}
