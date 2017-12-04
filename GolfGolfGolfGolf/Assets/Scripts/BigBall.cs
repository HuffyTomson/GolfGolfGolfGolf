using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBall : MonoBehaviour
{
    public float forceRange = 1;
    public float torqueRange = 3;

    public float horizontalForce = 10;
    public float verticalForce = 10;

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

    private void FixedUpdate()
    {
        //rigidbody.AddForce(new Vector3(Random.Range(-forceRange, forceRange), Random.Range(-forceRange, forceRange), Random.Range(-forceRange, forceRange)), ForceMode.Acceleration);
        //rigidbody.AddTorque(new Vector3(Random.Range(-torqueRange, torqueRange), Random.Range(-torqueRange, torqueRange), Random.Range(-torqueRange, torqueRange)), ForceMode.Acceleration);

        rigidbody.AddForce(Input.GetAxis("Horizontal") * Camera.main.transform.right * horizontalForce, ForceMode.Force);
        rigidbody.AddForce(Input.GetAxis("Vertical") * Camera.main.transform.forward * verticalForce, ForceMode.Force);
    }
}
