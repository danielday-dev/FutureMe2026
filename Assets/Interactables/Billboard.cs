using UnityEngine;

public class Billboard : MonoBehaviour
{
    // Put this onto an object to make it always face the camera.
    

    // Update is called once per frame
    void Update()
    {
        Vector3 target = Camera.main.transform.position;
        target.y = transform.position.y;
        transform.LookAt(target); //likely change this to whatever camera we end up using.
        
    }
}
