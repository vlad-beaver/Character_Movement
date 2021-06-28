﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransformPositionWithInputSmoothly : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += Time.deltaTime * moveSpeed * Vector3.right;

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += Time.deltaTime * moveSpeed * Vector3.left;

        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += Time.deltaTime * moveSpeed * Vector3.forward;

        if (Input.GetKey(KeyCode.DownArrow))
            transform.position += Time.deltaTime * moveSpeed * Vector3.back;

        if (Input.GetKey(KeyCode.Space))
            transform.position = new Vector3(0, 0.5f, 0);
    }
}
