using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelScript : MonoBehaviour
{
    public GameObject gm;
    public WheelJoint2D wheel;
    public JointMotor2D motor;

    public float speed;
    public float force;
    

    void Start()
    {
        wheel = transform.gameObject.GetComponent<WheelJoint2D>();
        motor = wheel.motor;
    }

    // Update is called once per frame
    void Update()
    {
        force = Input.GetAxis("Horizontal");
        motor.motorSpeed = speed * force;
        wheel.motor = motor;
    }
    void AddMotoreSpeed()
    {
       
    }
}
