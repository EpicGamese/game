using System.Collections.Specialized;

using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // This is a referenceto the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 35f;

    // We marked this as "Fixed"Update becuase we
    // are using it to mess with physics.
    void FixedUpdate()
    {   

       
        




        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce, 0, 0 * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce, 0, 0 * Time.deltaTime);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody> ().AddForce(Vector3.up * 300);
        }
    }



}
