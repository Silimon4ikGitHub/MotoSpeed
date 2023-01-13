using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelScript : MonoBehaviour
{
    public GameObject gm;
    public WheelJoint2D wheel;
    

    void Start()
    {
        wheel = transform.gameObject.GetComponent<WheelJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
