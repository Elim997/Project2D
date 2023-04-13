using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CurrentPlayer", menuName = "Scriptable Objects/Player/Current")]
public class CurrentPlayerSO : ScriptableObject
{
    public PlayerDetailsSO palyerDetails;
    public string playerName;

}
