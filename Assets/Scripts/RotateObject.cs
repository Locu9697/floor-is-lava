using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddTorque(Vector3.up * 20 * Time.deltaTime, ForceMode.Impulse);
        transform.Rotate(Vector3.up, 20 * Time.deltaTime);
    }
}
