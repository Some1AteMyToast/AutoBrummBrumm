using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAr : MonoBehaviour
{
    public float acceleration;
    public float rotationSpeed;
    public float maxSpeed;

    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        AddSpeed();
        AddRotation();
        AdjustVelocity();
    }

    void AddSpeed()
    {
        if(rigid.velocity.magnitude < maxSpeed)
        {
            float inputForward = Input.GetAxis("Vertical");
            rigid.AddForce(transform.forward * acceleration * inputForward);
        }
    }

    void AddRotation()
    {
        float rotation = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, rotation * rotationSpeed, 0));
    }

    void AdjustVelocity()
    {
        Vector3 velocity = rigid.velocity;

        float direction = Vector3.Dot(transform.forward, velocity.normalized);

        if (direction > 0)
        {
            velocity = transform.forward * velocity.magnitude;
        }
        if (direction < 0)
        {
            velocity = -transform.forward * velocity.magnitude;
        }

        rigid.velocity = velocity;
    }
}
