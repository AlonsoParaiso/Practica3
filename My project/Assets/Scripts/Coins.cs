using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{

    public int value = 1;
    private int monedaTotal;
    public AudioClip audioClip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerMovement>())
        {
            AudioManager.instance.PlayAudio(audioClip, "coinSound", false);
            monedaTotal = GameManager.instance.GetPoints();
            monedaTotal = value + monedaTotal;
            GameManager.instance.SetPoints(monedaTotal);
            Destroy(gameObject);
        }

    }
}