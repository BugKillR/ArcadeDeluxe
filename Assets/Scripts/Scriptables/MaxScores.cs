using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Game Score", menuName = "Score")]
public class MaxScores : ScriptableObject
{
    public string gameName;
    public float score;
}
