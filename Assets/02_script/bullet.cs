using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float ms;

    void Update()
    {
        transform.Translate(transform.forward*ms*Time.deltaTime);    
    }
}
