using UnityEngine;
using System.Collections;

[System.Serializable] // Necessário para aparecer no Unity
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;

    public float speed; // Usada para aumentar a velocidade da nave.
    public float tilt;
    public Boundary boundary; // Usada para colocar os limites da tela.

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;

    private AudioSource audioSource; // Declaração do tipo de dados de som

    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        }
        
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f , moveVertical); 
        rb = GetComponent<Rigidbody>();
        rb.velocity = movement * speed;

        // Usada para criar limites de áreas onde a nave pode ir
        rb.position = new Vector3
            (
                Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
                0.0f,
                Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
            );
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }
}
