﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomrorate2 : MonoBehaviour {

    public float tumble;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }

}
