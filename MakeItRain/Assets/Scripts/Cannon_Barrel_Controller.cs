using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_Barrel_Controller : MonoBehaviour
{
    public float Speed;
    private Transform CannonTransform;
    private JointMotor2D JointMotor2D;
    public Camera Camera;
    private Rigidbody2D Rgbd;
    private void Start()
    {
        Rgbd = GetComponent<Rigidbody2D>();
        CannonTransform = GetComponent<Transform>();
    }

    //private void Update()
    //{


    //}

    private void FixedUpdate()
    {
        // Get mouse X Y 
        // Convert into angles relative to base position coordinates of cannon barrel
        // Smooth via lerp
        // Rotate tube to new angle

        //var mousePos = Input.mousePosition;
        //var mouseAngleFromCannon = Vector3.Angle(CannonTransform.position, mousePos);
        //var x = Quaternion.Euler(CannonTransform.position);

        Debug.Log(CannonTransform.rotation);
        Debug.Log(CannonTransform.rotation.z);
        //Camera.s

        if (Input.GetKey("w") && CannonTransform.rotation.z >= -0.9 && CannonTransform.rotation.z <= -0.40)
            CannonTransform.Rotate(Vector3.forward);
        if (Input.GetKey("s") && CannonTransform.rotation.z >= -0.86 && CannonTransform.rotation.z <= -0.35)
            CannonTransform.Rotate(Vector3.back);
    }
}
