using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject ball;
    public GameObject myHand;
    public float thrust;
    public Rigidbody rb;
    Vector3 ballInHand = new Vector3(-0.500000f, -0.300f, 0.38000f);
    public void Start()
    {
        rb = ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
         if (Input.GetButton("Fire2") && ball.transform.localPosition == ballInHand)
        {
            ball.GetComponent<EventTrigger>().enabled = false;
            
            myHand.GetComponentInParent<PlayerWalk>().enabled = true;


            Invoke("reactivateEvent", 2);
            
        }


    }

    public void grabBall()
    {
        
        rb.useGravity = false;
        rb.velocity = Vector3.zero;
        ball.transform.SetParent(myHand.transform);
        ball.transform.localPosition = ballInHand;

        myHand.GetComponentInParent<PlayerWalk>().enabled = false;
    }

    private void reactivateEvent()
    {
        ball.GetComponent<EventTrigger>().enabled = true;
    }
}
