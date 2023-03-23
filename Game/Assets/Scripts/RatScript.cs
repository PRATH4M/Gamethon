using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public Transform groundCheckTransform;
    public float groundCheckRadius;
    public LayerMask GroundMask;
    public float velocity = 20;
    public Crash crash;
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    
    void Update()
    {
 
        
        if(Input.touchCount > 0 && Input.touchCount < 3)
        {
            Touch touch = Input.GetTouch(0);
            myRigidBody.velocity = Vector2.up * velocity;
        }
        else if(Input.GetMouseButton(0))
        {
            myRigidBody.velocity = Vector2.up * velocity;
        }
    }
    bool onground()
        {
        return Physics2D.OverlapCircle(groundCheckTransform.position, groundCheckRadius, GroundMask);
        }
    
}

