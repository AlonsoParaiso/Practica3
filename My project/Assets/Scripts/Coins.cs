using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{

    public int value = 1;
    private int monedaTotal;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            monedaTotal = GameManager.instance.GetPoints();
            monedaTotal = value+monedaTotal;
            GameManager.instance.SetPoints(monedaTotal);
            Destroy(this.gameObject);
        }

    }
}