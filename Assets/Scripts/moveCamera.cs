using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class moveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    // Update is called once per frame
    private void Update()
    {
        //print(cameraPosition.position);
        //print(transform.position);
        transform.position = cameraPosition.position;
    }
}
