using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    [SerializeField] private string[] isimler = new string[4];
    public string[] isimler2 = new string[] { "yasin", "küçüker", "cem", "ali" };
    public int[] array2 = new int[] {3, 5, 7};
    void Start()
    {
        Debug.Log(isimler2[0]);
        for(int i = 0; i < isimler2.Length; i++)
        {
            Debug.Log(isimler2[i]);
        }
    }
}
