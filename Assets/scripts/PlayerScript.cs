using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 6.0f;
    public Transform camara;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 forward = camara.forward;
        Vector3 right = camara.right;
        forward.y = 0;
        right.y = 0;
        forward.Normalize();
        right.Normalize();
        Vector3 moveDirection = (forward * moveZ + right * moveX);
        //Debug.Log("Texto: " + moveX);
        rb.AddForce(moveDirection * moveSpeed, ForceMode.Acceleration);
    }
}