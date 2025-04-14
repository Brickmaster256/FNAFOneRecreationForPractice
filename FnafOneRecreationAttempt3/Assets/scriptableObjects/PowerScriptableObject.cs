using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Power Object")]
public class PowerScriptableObject : ScriptableObject
{
    public int power;
    
    public void SetPower(int amount)
    {
        power = amount;
    }

    public void UpdateScore(int amount)
    {
        power += amount;
    }
}
