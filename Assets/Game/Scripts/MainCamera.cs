using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject bike;


    void Update()
    {
        FollowBike();
    }
    void FollowBike()
    {
        transform.position = new Vector3 (bike.transform.position.x, transform.position.y, transform.position.z);
    }
}
