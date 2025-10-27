using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheck : MonoBehaviour
{
    public List<string> enemyNames = new List<string>();

    private void Start()
    {
        if (CheckEnemyCount(enemyNames))
            Debug.Log("LEVEL COMPLETED!");
        else
            Debug.Log("LEVEL CONTINUE");
    }

    private bool CheckEnemyCount(List<string> enemyNames)
    {
        bool state;
        if(enemyNames.Count < 1)
              state = true;
        else
            state = false;
        return state;
    }
}
