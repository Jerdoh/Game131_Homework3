using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CubeData", menuName = "Cube Stat Block", order = 1)]
public class CubeStats : ScriptableObject
{
    public int strength = 1;
    public int body = 1;
    public int will = 1;
    public string displayName = "Not Set";
}
