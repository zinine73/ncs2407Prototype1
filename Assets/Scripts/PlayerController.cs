using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15;
    void Update()
    {
        // 차량을 앞으로 이동시킨다
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
