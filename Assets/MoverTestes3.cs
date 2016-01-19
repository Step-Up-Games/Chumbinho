using UnityEngine;
using System.Collections;

public class MoverTestes3 : MonoBehaviour {

    /*private Rigidbody rb;

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Quaternion.Euler(0, 30, 0) * transform.forward * speed;
    }*/

    public float MoveSpeed = 5.0f;

    public float frequency = 20.0f;  // Speed of sine movement
    public float magnitude = 0.5f;   // Size of sine movement
    private Rigidbody rb;
    private Vector3 pos;

    void Start()
    {
        pos = transform.position;
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * MoveSpeed;

    }

    void Update()
    {
        //pos += transform.forward * Time.deltaTime * MoveSpeed;
        transform.position = pos + transform.right * Mathf.Sin(Time.time * frequency) * magnitude;
    }

}
