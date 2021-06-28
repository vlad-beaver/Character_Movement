using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithForceUsingTransformRotation : MonoBehaviour
{
private Rigidbody _rigidbody;

    [SerializeField] private float _movementForce = 10f;

    private void Awake() => _rigidbody = GetComponent<Rigidbody>();

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            _rigidbody.AddForce(_movementForce * transform.forward);

        if (Input.GetKey(KeyCode.S))
            _rigidbody.AddForce(_movementForce * -transform.forward);

        if (Input.GetKey(KeyCode.D))
            _rigidbody.AddForce(_movementForce * transform.right);

        if (Input.GetKey(KeyCode.A))
            _rigidbody.AddForce(_movementForce * -transform.right);
    }
}
