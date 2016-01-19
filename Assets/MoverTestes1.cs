using UnityEngine;
using System.Collections;

public class MoverTestes1 : MonoBehaviour {

    private Rigidbody rb;

    public float speed;

    Vector3 A = Quaternion.Euler(0, 30, 0) * Vector3.right;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.velocity = transform.forward * speed;
        transform.position += A;
        rb.velocity = Quaternion.Euler(0, 30, 0)*transform.forward * speed;
    }
}
