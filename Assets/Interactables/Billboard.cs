using UnityEngine;

public class Billboard : MonoBehaviour
{
    // Put this onto an object to make it always face the camera.
    [SerializeField] Camera cam;

    // Update is called once per frame
    void Update()
    {
        Vector3 target = cam.transform.position;
        target.y = transform.position.y;
        transform.LookAt(target); //likely change this to whatever camera we end up using.
        transform.Rotate(new Vector3(90, 0, 0));
    }
}
