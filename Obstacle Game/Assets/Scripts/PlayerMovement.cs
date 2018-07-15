
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // this is a reference to the Rigidbody component called rb
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
	// We are marking it as FixedUpdate because
    // we are using it to mess with physics
	// Update is called once per frame
	void FixedUpdate ()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);  // Add a force of 2000 on the z axis
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
    
        }
    }
}
