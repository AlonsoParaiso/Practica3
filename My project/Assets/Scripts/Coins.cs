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
        if (collision.GetComponent<PlayerMovement>())//la moneda suma a la puntuacion total y tiene sonido y luego se destruye
        {
            AudioManager.instance.PlayAudio(audioClip, "coinSound", false, 0.6f);
            monedaTotal = GameManager.instance.GetPoints();
            monedaTotal = value + monedaTotal;
            GameManager.instance.SetPoints(monedaTotal);
            Destroy(gameObject);
        }

    }
}