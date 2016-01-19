using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

    private Rigidbody rb;

    public float Tumble;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * Tumble;// Quão rápido o objeto gira.
    }
}
