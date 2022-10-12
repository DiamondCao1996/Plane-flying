using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateX : MonoBehaviour
{
    public float rotateSpeed = 100.0f;

    public GameObject plane;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    [Obsolete("Obsolete")]
    void Update()
    {
        transform.RotateAround(Vector3.forward, rotateSpeed*Time.deltaTime);
    }
}
