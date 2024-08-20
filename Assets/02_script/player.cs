using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float ms;
    private void FixedUpdate()
    {
        move();
    }
    private void move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * ms * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * ms * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * ms * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * ms * Time.deltaTime);
        }
    }
}
