using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horsePower = 50;
    [SerializeField] private float turnSpeed = 20;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float forwardInput;
    [SerializeField] GameObject centerOfMass;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = centerOfMass.transform.position;
    }

    void FixedUpdate()
    {
        // Input Manager를 통해 차량을 이동, 가속시킨다
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // forwardInput 값에 따라 차량을 앞으로, 뒤로 이동시킨다
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        rb.AddRelativeForce(Vector3.forward * forwardInput * horsePower);
        // horizontalInput 값에 따라 차량을 회전시킨다
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
