using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonguOrnek : MonoBehaviour
{
    int sayac = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            if(i % 2 == 0)
            {
                Debug.Log(i);
            }
        }

        for(int i=0; i<10; i += 2)
        {
            Debug.Log(i);
        }

        while(sayac < 10)
        {
            sayac += 2;
            Debug.Log(sayac);
        }
    }

}
