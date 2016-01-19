using UnityEngine;
using System.Collections;

public class MoverTestes2 : MonoBehaviour {

    private Rigidbody rb;

    public float speed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.velocity = transform.forward * speed;
        rb.velocity = Quaternion.Euler(0, -30, 0) * transform.forward * speed;
    }
}
