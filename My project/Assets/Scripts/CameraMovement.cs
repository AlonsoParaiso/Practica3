using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMovement : MonoBehaviour
{
    public GameObject Pingu;
    public KeyCode resetGame, menu;

    private void Update()
    {
        if (Pingu != null)
        {
            transform.position = new Vector3(Pingu.transform.position.x,transform.position.y,transform.position.z);
        }

        if (Input.GetKeyDown(resetGame))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            AudioManager.instance.ClearAudio();
        }

        if (Input.GetKeyDown(menu)) {
            GameManager.instance.LoadScene("Menu");
        }
    }

}
