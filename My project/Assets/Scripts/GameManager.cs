using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int TotalPoints { get { return totalPoints; } }
    private int totalPoints;

    public void PlusCoins(int puntosASumar)
    {
        totalPoints += puntosASumar;
    }
}