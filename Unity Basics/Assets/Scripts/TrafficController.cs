using UnityEngine;
using System.Collections.Generic;
using DG.Tweening; // <-- This is the correct namespace

public class TrafficController : MonoBehaviour
{
    public List<GameObject> cars;

    private void Start()
    {
        Sequence traffic = DOTween.Sequence();
        traffic.Append(cars[0].transform.DOMoveZ(10, 2));
        traffic.Append(cars[1].transform.DOMoveX(0, 2));
        traffic.Append(cars[2].transform.DOMoveZ(-3, 2));
        traffic.Append(cars[1].transform.DOMoveX(4, 2));
    }
}