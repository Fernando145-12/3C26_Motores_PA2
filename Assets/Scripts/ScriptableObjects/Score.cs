using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class Score : ScriptableObject
{
    public int CurretScore;
    public int MaxScore;

    public void UpdateMaxScore()
    {
        if(CurretScore >= MaxScore)
        {
            MaxScore = CurretScore;
            return true;
        }
        else
        {
            return false;
        }
    }
    public void ResetActualScore()
    {
        CurretScore = 0;
    }
}
