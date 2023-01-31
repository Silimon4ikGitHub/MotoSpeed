using UnityEngine;

public class WheelScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotateForce;
    [SerializeField] private Rigidbody2D bikeBodyRB;
    [SerializeField] private JointMotor2D motor;

    private float _force;
    private WheelJoint2D _wheel;
    
    void Start()
    {
        _wheel = transform.gameObject.GetComponentInParent<WheelJoint2D>();
        motor = _wheel.motor;
    }

    void Update()
    {
        UseMotorByButton();
        RotateBike();
    }

    void UseMotorByButton()
    {
        _force = -Input.GetAxis("Horizontal");
        motor.motorSpeed = speed * _force;
        _wheel.motor = motor;
    }

    void RotateBike()
    {
        bikeBodyRB.AddTorque(_force * -rotateForce);
    }
}
