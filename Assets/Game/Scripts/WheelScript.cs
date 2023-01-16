using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private JointMotor2D motor;

    private WheelJoint2D _wheel;
    private float _force;
    
    void Start()
    {
        _wheel = transform.gameObject.GetComponentInParent<WheelJoint2D>();
        motor = _wheel.motor;
    }

    void Update()
    {
        _force = -Input.GetAxis("Horizontal");
        motor.motorSpeed = speed * _force;
        _wheel.motor = motor;
    }
    void AddMotoreSpeed()
    {
       
    }
}
