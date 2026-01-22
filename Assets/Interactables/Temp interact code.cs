using UnityEngine;

public class Tempinteractcode : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        { //0 is left click. 1 is right click. 
            if (tryInteract(out Interactable interactable))
            {
                interactable.Execute(this.gameObject);
                //takes the player as an input, since most interactables
                //will use them.
            }
        }
    }

    private bool tryInteract(out Interactable interactable)
    {
        interactable = null;

        Vector3 loc = Camera.main.transform.position;
        float radius = 0.5f;

        //Ray rcast = new Ray(transform.position + rayOffset, playerCam.transform.forward);

        //Overlap check first, since raycasts dont pick up if you are inside of it
        Collider[] overlappedEnts = Physics.OverlapSphere(loc, radius);
        foreach (Collider col in overlappedEnts)
        {
            if (col.TryGetComponent(out interactable))
            {
                return true;
            }
        }

        //spherecast adds some leniancy so you dont have to aim well. might be useful for fast moving stuff.
        if (Physics.SphereCast(Camera.main.transform.position, 0.5f, Camera.main.transform.forward, out RaycastHit hitObj, 10f)) //10f is the interaction distance
        {
            interactable = hitObj.collider.GetComponent<Interactable>();
            if (interactable != null)
            {
                return true;
            }

            return false;
        }
        return false;
    }
}
