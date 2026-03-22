using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;

    [SerializeField]
    private Transform propeller;

    private float propellerSpeed=float.MaxValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput=Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward* Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(new Vector3(verticalInput,0f,0f) * rotationSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0f,horizontalInput,0f) *rotationSpeed* Time.deltaTime);

        propeller.Rotate(new Vector3(0f,0f,propellerSpeed));
    }
}
