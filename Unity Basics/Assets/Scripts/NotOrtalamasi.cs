using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotOrtalamasi : MonoBehaviour
{
    int not1, not2, not3;
    float notOrtalamasi;
    string mesaj;
    void Start()
    {
        not1 = 26;
        not2 = 75;
        not3 = 100;

        notOrtalamasi = (not1 + not2 + not3) / 3;
        Debug.Log("Not Ortalamas� : " + notOrtalamasi);

        if (notOrtalamasi < 49)
            mesaj = "S�n�fta kald�.";
        else if (notOrtalamasi >= 49 && notOrtalamasi <= 75)
            mesaj = "Te�ekk�r ald�.";
        else
            mesaj = "Takdir ald�.";

        print(mesaj);
        
    }

 
}
