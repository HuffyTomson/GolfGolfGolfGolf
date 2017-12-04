using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBall : MonoBehaviour
{
    public Transform gravityCenter;

    public float gravityForce = 20;

    Rigidbody _rigidbody;
    Rigidbody rigidbody
    {
        get
        {
            if (_rigidbody == null)
                _rigidbody = GetComponent<Rigidbody>();

            return _rigidbody;
        }
    }

    void FixedUpdate ()
    {
        Vector3 gravityDirection = (gravityCenter.position - transform.position).normalized;
        rigidbody.AddForce(gravityDirection * gravityForce, ForceMode.VelocityChange);
    }
}
