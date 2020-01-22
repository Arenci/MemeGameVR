using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject ball;
    public Rigidbody rb;
    public GameObject myHand;
    private float thrust;
    private float maxSpeed;

    void Start()
    {
        thrust = 400;
        maxSpeed = 500;
    }

   

    public void LaunchBall()
    {          
        
            rb = ball.GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.AddForce(myHand.transform.forward * thrust);
            if (rb.velocity.magnitude > maxSpeed)
            {
                rb.velocity = rb.velocity.normalized * maxSpeed;
            }
            ball.transform.SetParent(null);
            this.GetComponent<Shoot>().enabled = false;
   
    }
}
