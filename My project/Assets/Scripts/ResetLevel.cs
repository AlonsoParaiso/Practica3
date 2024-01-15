using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)//si se colisiona se reinicia la escena
    {
        if (collision.GetComponent<PlayerMovement>())
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
