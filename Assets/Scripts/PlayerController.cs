using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15;
    private float turnSpeed = 20;
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        // Input Manager를 통해 차량을 이동, 가속시킨다
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // forwardInput 값에 따라 차량을 앞으로, 뒤로 이동시킨다
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // horizontalInput 값에 따라 차량을 회전시킨다
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
