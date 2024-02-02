using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (!instance)
        {
            instance = this;//se instancia el objecto
            DontDestroyOnLoad(gameObject);// no se destruye entre cargas
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public AudioSource PlayAudio(AudioClip audioClip, string gameObjectName, bool isLoop = false, float volume = 1.0f)
    {
        GameObject auidoObject = new GameObject(gameObjectName);
        auidoObject.AddComponent<AudioSource>();
    }
}
