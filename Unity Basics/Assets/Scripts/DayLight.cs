using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayLight : MonoBehaviour
{
    
    void Start()
    {
        transform.DORotateQuaternion(Quaternion.Euler(200, transform.localRotation.y,0),5).SetLoops(-1, LoopType.Yoyo);
    }

  
}
