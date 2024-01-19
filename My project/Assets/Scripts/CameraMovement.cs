using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject Pingu;
    
    private void Update()
    {
        transform.position = new Vector3(Pingu.transform.position.x,transform.position.y,transform.position.z);
    }

}
