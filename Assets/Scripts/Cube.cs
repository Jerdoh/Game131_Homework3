using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [Header("Static Values")]
    public CubeStats cube;

    [Header("Calculated Values")]
    public int health;
    public int damageTaken;
    public int damageDone;

    [Header("Stat")]
    public string stat = "Enter stat here";
}
