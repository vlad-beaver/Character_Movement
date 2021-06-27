using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float Speed = 1f;

    private Rigidbody Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        float value = Input.GetAxis("Vertical");
        if (value != 0)
            Rigidbody.AddForce(0, 0, value * Time.fixedDeltaTime * 1000f);

    }
}
