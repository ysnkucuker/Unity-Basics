using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    [SerializeField] private List<int> numbers = new List<int>();

    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            numbers.Add(i);
        }
        numbers.Insert(5, 5);
        numbers.RemoveAt(2);

        for (int i = 0; numbers.Count > i; i++)
        {
            Debug.Log(numbers[i]);
        }

        numbers.Clear();
        if (numbers.Count == 0)
            Debug.Log("List is clear.");
    }
}
