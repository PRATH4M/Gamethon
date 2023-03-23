using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadzone = -15;
    void Start()
    {


    }
    public void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadzone)
            Destroy(gameObject);
    }
    
}
