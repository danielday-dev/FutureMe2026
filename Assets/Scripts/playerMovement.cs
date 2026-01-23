using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    public float groundDrag;
    public Camera playerCam;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        MyInput();
        SpeedControl();
        rb.linearDamping = groundDrag;
        findObjects();
        
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);

        if (flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.linearVelocity = new Vector3(limitedVel.x, rb.linearVelocity.y, limitedVel.z);
        }
    }

    private void findObjects()
    {
        if (tryInteract(out Interactable interactable))
        {
            /*
             * 
             * Here, it should update the HUD to show something like "E - use printer" etc.
             * 
             * 
             */
            if (Input.GetKeyDown(KeyCode.E)) //change thus
            { 
              //takes the player as an input, since most interactables
              //will use them.
                interactable.Execute(this.gameObject);
            }
            
            
        }

        
    }

    private bool tryInteract(out Interactable interactable)
    {

        /*
         * 
         * This does a spherecast every tick. not exactly optimised. Could replace with a constant collision box in front of you instead.
         * 
         * 
         */
        interactable = null;

        Vector3 loc = playerCam.transform.position;
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
        if (Physics.SphereCast(playerCam.transform.position, 0.5f, playerCam.transform.forward, out RaycastHit hitObj, 1.2f)) //10f is the interaction distance
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
