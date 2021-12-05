using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public GameObject ball;
    public Rigidbody rb;
    public float speed = 10.0f;

    private float xInput;
    private float zInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0.0f, zInput) * speed);
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

}
