using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float movementForce = 1000f;

	// Use this for initialization
	void Start ()
    {

        Debug.Log("SUP!!!");

	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        // add a forward force
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, movementForce * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -movementForce * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(movementForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-movementForce * Time.deltaTime, 0, 0);
        }
    }
}
