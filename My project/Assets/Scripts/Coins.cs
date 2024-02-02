using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{

    public int value = 1;
    private int monedaTotal;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerMovement>())
        {
            monedaTotal = GameManager.instance.GetPoints();
            monedaTotal = value + monedaTotal;
            GameManager.instance.SetPoints(monedaTotal);
            Destroy(gameObject);
        }

    }
}