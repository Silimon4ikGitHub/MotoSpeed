using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject bike;


    private void Update()
    {
        FollowBike();
    }

    private void FollowBike()
    {
        transform.position = new Vector3 (bike.transform.position.x, transform.position.y, transform.position.z);
    }
}
