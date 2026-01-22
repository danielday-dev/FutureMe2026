using UnityEngine;

public class Billboard : MonoBehaviour
{
    // Put this onto an object to make it always face the camera.
    

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform.position); //likely change this to whatever camera we end up using.
    }
}
